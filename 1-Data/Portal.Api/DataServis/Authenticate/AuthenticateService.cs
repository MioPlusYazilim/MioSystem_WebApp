using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Portal.Model;
using MioPortal.Util;
using Portal.Api.Data.Context;
using Portal.Api.Data.Entity.GlobalEntity;
using Portal.Api.Helpers.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portal.Api.DataServis
{
    public interface IAuthenticateService
    {
        Task<SaveResult> Login(string userName, string password);
        Task<SaveResult> RefreshToken(string refreshToken);
        Task<SaveResult> ForgatPassword(string email);
        Task<SaveResult> ResetPassword(passwordResetRequest model);
        string Sifrele(string text);
        string SifreCoz(string text);
    }
    public class AuthenticateService : IAuthenticateService
    {
        IConfiguration configuration;
        ISessionService sessionService;
        GlobalDataContext globalDataContext;
        public AuthenticateService(IConfiguration _configuration,ISessionService _sessionService, GlobalDataContext _context)
        {
            configuration = _configuration;
            sessionService = _sessionService;
            globalDataContext = _context;
        }
        public async Task<SaveResult> Login(string username, string password)
        {
            SaveResult result = new SaveResult();
            return await Task.Run(() =>
             {
                 using (CryptoManager engine = new CryptoManager(""))
                 {
                     username = engine.Encrypt(username);
                     password = engine.Encrypt(password);
                 }
                 var clientUser = globalDataContext.ClientUsers.FirstOrDefault(x => x.UserName.Equals(username) && x.UserPass.Equals(password) && x.Active);
                 if(clientUser == null) {
                     result.isSuccess = false;
                 }
                 else
                 {
                     result.isSuccess = true;
                     result.returnValue= GetLoginResponse(clientUser);
                 }
                 return result;

             });
        }

        public async Task<SaveResult> RefreshToken(string refreshToken)
        {
            SaveResult result = new SaveResult();
            return await Task.Run(() =>
            {
                var clientUser = globalDataContext.ClientUsers.FirstOrDefault(x => x.RefreshToken.Equals(refreshToken) && x.RefreshTokenExpireDate.Value.Date > DateTime.Now.Date);
                if (clientUser == null)
                {
                    result.isSuccess = false;
                }
                else
                {
                    result.isSuccess = true;
                    result.returnValue = GetLoginResponse(clientUser);
                }
                return result;
            });
        }

        LoginResponse GetLoginResponse(ClientUser clientUser)
        {
            var response = new LoginResponse();
            if (clientUser == null)
                return response;

            var client = globalDataContext.Clients.FirstOrDefault(x => x.ClientKey == clientUser.ClientKey);
            if (client == null)
                return response;


            string connstr = string.Empty;
            using (CryptoManager engine = new CryptoManager(""))
                connstr = engine.Decrypt(client.ClientValue);

            using (ClientDataContext dbContext = new ClientDataContext(connstr))
            {
                var employee = dbContext.Employees.Include(i => i.employeeParameters).FirstOrDefault(x => x.ID == clientUser.EmployeeID);
                if (employee == null)
                    return new LoginResponse();
                var company = dbContext.Companies.FirstOrDefault(x => x.ID == employee.CompanyID);
                response.companyID = employee.CompanyID;
                response.companyName = company.CodeName;
                response.companyCode = company.Code;
                response.authoryGroup = employee.employeeParameters.AuthoryGroup;
                response.authoryLevel = employee.employeeParameters.AuthoryLevel;

                response.employeeID = employee.ID;
                response.fullName = employee.LongName;
                response.email = employee.Email;
                response.profileImagePath = string.Empty;
                var authories = dbContext.RoleAuthories.Where(x => x.RoleID == employee.employeeParameters.AuthoryRole).ToList();
                var translations = (from nv in globalDataContext.Navigations
                                    join tr in globalDataContext.NavigationTranslations on nv.ID equals tr.ParentID
                                    where tr.LanguageCode == sessionService.sessionInfo.Language
                                    select (new NavigationRole()
                                    {
                                        id = 0,
                                        menuTag = nv.MenuTag,
                                        modulID = nv.ModulID,
                                        formType = nv.MenuFormType,
                                        menuCardType = nv.MenuCardType ?? 0,
                                        isInternational = nv.IsInternational,
                                        menuName = tr.MenuName,
                                        editFormName = nv.EditFormName,
                                        editFormPath = nv.EditFormPath,
                                        listFormName = nv.ListFormName,
                                        formCaption = tr.FormCaption,
                                        editFormCaption = tr.EditFormCaption,
                                        allowList = false,
                                        allowNew = false,
                                        allowEdit = false,
                                        allowDelete = false,
                                        allowPrint = false,
                                        reportIDs = ""
                                    })).ToList();

                response.navigationRoles = (from au in authories
                                                join nv in translations on au.MenuID equals nv.menuTag
                                                select (new NavigationRole()
                                                {
                                                    id = au.ID,
                                                    menuTag = au.MenuID,
                                                    modulID = nv.modulID,
                                                    formType = nv.formType,
                                                    menuCardType = nv.menuCardType,
                                                    isInternational = nv.isInternational,
                                                    menuName = nv.menuName,
                                                    editFormName = nv.editFormName,
                                                    editFormPath = nv.editFormPath,
                                                    listFormName = nv.listFormName,
                                                    formCaption = nv.formCaption,
                                                    editFormCaption = nv.editFormCaption,
                                                    allowList = au.AllowList,
                                                    allowNew = au.AllowNew,
                                                    allowEdit = au.AllowEdit,
                                                    allowDelete = au.AllowDelete,
                                                    allowPrint = au.AllowPrint,
                                                    reportIDs = au.ReportIDs
                                                })).ToList();


                response.navigationsMain = GetUserNavigationTree(response.navigationRoles);
                response.navigationsSettings = GetUserSettingsNavigationTree(response.navigationRoles);

                var token = new TokenHandler(configuration).CreateAccessToken(employee, clientUser.ClientKey);

                response.token = token.AccessToken;
                response.refreshToken = token.RefreshToken;

                clientUser.RefreshToken = token.RefreshToken;
                clientUser.RefreshTokenExpireDate = token.Expiration.AddMinutes(15);
            }

            globalDataContext.SaveChanges();

            return response;
        }

        private List<NavigationM> GetUserNavigationTree(List<NavigationRole> authories)
        {
            var authListIDs = authories.Select(x => x.menuTag).ToList();
            var defaultMenulist = (from menu in globalDataContext.Navigations
                                   join translation in globalDataContext.NavigationTranslations on menu.ID equals translation.ParentID
                                   where translation.LanguageCode.Equals(sessionService.sessionInfo.Language) && menu.MenuActive
                                   select new NavigationM()
                                   {
                                       id = menu.ID,
                                       modulID = menu.ModulID,
                                       parentID = menu.ParentID,
                                       menuLevel = menu.MenuLevel,
                                       menuOrder = menu.MenuOrder,
                                       formType = menu.MenuFormType,
                                       menuIcon = menu.MenuIcon,
                                       menuLink = menu.MenuLink,
                                       menuTag = menu.MenuTag,
                                       menuCardType = menu.MenuCardType ?? 0,
                                       isInternational = menu.IsInternational,
                                       menuName = translation.MenuName ?? "",
                                       formCaption = translation.FormCaption ?? "",
                                       editFormCaption = translation.EditFormCaption ?? "",
                                       editFormName = menu.EditFormName ?? "",
                                       listFormName = menu.ListFormName ?? "",
                                       menuPath = menu.MenuPath ?? "",
                                       allowList = false,
                                       allowDelete = false,
                                       allowEdit = false,
                                       allowNew = false,
                                       allowPrint = false,
                                       reportIDs = ""
                                   }).ToList();

                //defaultMenulist = defaultMenulist.OrderBy(o => o.menuLevel).ThenBy(o => o.menuOrder).ToList();
                var menuitemList = defaultMenulist.Where(x => authListIDs.Contains(x.menuTag) && x.formType > 1);

                foreach (var menuitem in menuitemList)
                {
                    var auth = authories.FirstOrDefault(x => x.menuTag == menuitem.menuTag);
                    menuitem.allowList = auth.allowList;
                    menuitem.allowNew = auth.allowNew;
                    menuitem.allowEdit = auth.allowEdit;
                    menuitem.allowDelete = auth.allowDelete;
                    menuitem.allowPrint = auth.allowPrint;
                    menuitem.reportIDs = auth.reportIDs;
                }

                List<NavigationM> MenuLevel0 = new List<NavigationM>();
                List<NavigationM> MenuLevel1 = new List<NavigationM>();

                foreach (var item in menuitemList)
                {
                    try
                    {
                        var mlv1 = MenuLevel1.FirstOrDefault(x => x.id == item.parentID);
                        if (mlv1 == null)
                        {
                            mlv1 = defaultMenulist.FirstOrDefault(x => x.id == item.parentID);
                            if (mlv1 != null)
                                MenuLevel1.Add(mlv1);
                        }
                        if (mlv1 != null)
                            mlv1.items.Add(item);
                    }
                    catch (System.Exception ex)
                    {
                    }

                }
                foreach (var item in MenuLevel1)
                {
                    try
                    {
                        var mlv0 = MenuLevel0.FirstOrDefault(x => x.id == item.parentID);
                        if (mlv0 == null)
                        {
                            mlv0 = defaultMenulist.FirstOrDefault(x => x.id == item.parentID);
                            if (mlv0 != null)
                                MenuLevel0.Add(mlv0);
                        }
                        if (mlv0 != null)
                            mlv0.items.Add(item);
                    }
                    catch (System.Exception ex)
                    {
                    }

                }
                return MenuLevel0;
        }

        private List<NavigationM> GetUserSettingsNavigationTree(List<NavigationRole> authories)
        {
                var authListIDs = authories.Select(x => x.menuTag).ToList();
                var defaultMenulist = (from menu in globalDataContext.Navigations
                                       join translation in globalDataContext.NavigationTranslations on menu.ID equals translation.ParentID
                                       where translation.LanguageCode.Equals(sessionService.sessionInfo.Language) && menu.MenuActive
                                       select new NavigationM()
                                       {
                                           id = menu.ID,
                                           modulID = menu.ModulID,
                                           parentID = menu.ParentID,
                                           menuLevel = menu.MenuLevel,
                                           menuOrder = menu.MenuOrder,
                                           formType = menu.MenuFormType,
                                           menuIcon = menu.MenuIcon,
                                           menuLink = menu.MenuLink,
                                           menuTag = menu.MenuTag,
                                           menuCardType = menu.MenuCardType ?? 0,
                                           isInternational = menu.IsInternational,
                                           menuName = translation.MenuName ?? "",
                                           formCaption = translation.FormCaption ?? "",
                                           editFormCaption = translation.EditFormCaption ?? "",
                                           editFormName = menu.EditFormName ?? "",
                                           listFormName = menu.ListFormName ?? "",
                                           menuPath = menu.MenuPath ?? "",
                                           allowList = false,
                                           allowDelete = false,
                                           allowEdit = false,
                                           allowNew = false,
                                           allowPrint = false,
                                           reportIDs = ""
                                       }).ToList();

                var menuitemList = defaultMenulist.Where(x => authListIDs.Contains(x.menuTag) && x.menuLevel == 2 && x.formType == 1);

                foreach (var menuitem in menuitemList)
                {
                    var auth = authories.FirstOrDefault(x => x.menuTag == menuitem.menuTag);
                    menuitem.allowList = auth.allowList;
                    menuitem.allowNew = auth.allowNew;
                    menuitem.allowEdit = auth.allowEdit;
                    menuitem.allowDelete = auth.allowDelete;
                    menuitem.allowPrint = auth.allowPrint;
                    menuitem.reportIDs = auth.reportIDs;
                }

                List<NavigationM> MenuLevel0 = new List<NavigationM>();
                List<NavigationM> MenuLevel1 = new List<NavigationM>();

                foreach (var item in menuitemList)
                {
                    try
                    {
                        var mlv1 = MenuLevel1.FirstOrDefault(x => x.id == item.parentID);
                        if (mlv1 == null)
                        {
                            mlv1 = defaultMenulist.FirstOrDefault(x => x.id == item.parentID);
                            if (mlv1 != null)
                                MenuLevel1.Add(mlv1);
                        }
                        if (mlv1 != null)
                            mlv1.items.Add(item);
                    }
                    catch (System.Exception ex)
                    {
                    }

                }
                foreach (var item in MenuLevel1)
                {
                    try
                    {
                        var mlv0 = MenuLevel0.FirstOrDefault(x => x.id == item.parentID);
                        if (mlv0 == null)
                        {
                            mlv0 = defaultMenulist.FirstOrDefault(x => x.id == item.parentID);
                            if (mlv0 != null)
                                MenuLevel0.Add(mlv0);
                        }
                        if (mlv0 != null)
                            mlv0.items.Add(item);
                    }
                    catch (System.Exception ex)
                    {
                    }

                }
                return MenuLevel0;
        }
        public async Task<SaveResult> ForgatPassword(string email)
        {
            SaveResult saveResult = new SaveResult();

            var user = globalDataContext.ClientUsers.FirstOrDefault(x => x.EMail == email);
            if (user == null)
                return saveResult;
            var tokenhandler = new TokenHandler(configuration);
            user.ResetPasswordToken = tokenhandler.CreateRefreshToken();
            user.ResetPasswordTokenExpireDate = System.DateTime.Now.AddHours(24);
            try
            {
                await globalDataContext.SaveChangesAsync();
                saveResult.isSuccess = true;
            }
            catch (Exception ex)
            {
                saveResult.isSuccess = false;
                saveResult.errorMessage = ex.Message;
            }
            return saveResult;
        }
        public async Task<SaveResult> ResetPassword(passwordResetRequest model)
        {
            SaveResult saveResult = new SaveResult();
            try
            {
                var user = globalDataContext.ClientUsers.FirstOrDefault(x => x.ResetPasswordToken == model.token && x.ResetPasswordTokenExpireDate.Value.Date < DateTime.Now.Date);
                if (user == null)
                    return saveResult;
                using (CryptoManager engine = new CryptoManager(""))
                {
                    user.UserPass = engine.Encrypt(model.password);
                }
                user.ResetPasswordToken = null;
                user.ResetPasswordTokenExpireDate = null;
                await globalDataContext.SaveChangesAsync();
                saveResult.isSuccess = true;
            }
            catch (Exception ex)
            {
                saveResult.isSuccess = false;
                saveResult.errorMessage = ex.Message;
            }
            return saveResult;
        }
        public string Sifrele(string text)
        {
            using (CryptoManager engine = new CryptoManager(""))
                text = engine.Encrypt(text);
            return text;
        }
        public string SifreCoz(string text)
        {
            using (CryptoManager engine = new CryptoManager(""))
                text = engine.Decrypt(text);
            return text;
        }
    }
}

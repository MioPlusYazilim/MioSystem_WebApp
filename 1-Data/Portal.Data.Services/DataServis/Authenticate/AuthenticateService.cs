using Azure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Portal.Data.Context;
using Portal.Data.Entities.ClientEntities;
using Portal.Data.Entities.GlobalEntities;
using Portal.Helpers;
using Portal.Model;
using System.Collections;
using System.Collections.Generic;

namespace Portal.Data.Services
{
    public interface IAuthenticateService
    {
        SaveResult Login(string userName, string password);
        Task<SaveResult> LoginAsync(string userName, string password);
        Task<SaveResult> RefreshTokenAsync(string refreshToken);

        string Sifrele(string text);
        string SifreCoz(string text);
    }
    public class AuthenticateService : IAuthenticateService
    {
        private GlobalDataContext globalDataContext;
        public readonly Login loginResponse;
        private static readonly char[] separator = new char[] { ';' };

        public AuthenticateService(Login _loginResponse)
        {
            this.loginResponse = _loginResponse;
            SetDbContext();

        }
        public AuthenticateService()
        {
            this.loginResponse = Model.Login.GetLoginUser();
            SetDbContext();
        }

        void SetDbContext()
        {
            using (CryptoManager engine = new CryptoManager(""))
            {
                globalDataContext = new GlobalDataContext(engine.Decrypt(this.loginResponse.globalKey)); 
            }

            
        }

        public SaveResult Login(string username, string password)
        {
            SaveResult result = new SaveResult();
            using (CryptoManager engine = new CryptoManager(""))
            {
                username = engine.Encrypt(username);
                password = engine.Encrypt(password);
            }
            var clientUser = globalDataContext.ClientUsers.FirstOrDefault(x => x.UserName.Equals(username) && x.UserPass.Equals(password) && x.Active);
            if (clientUser == null)
            {
                result.isSuccess = false;
                result.errorMessage = "Geçersiz kullancı veya şifre...";
            }
            else
            {
                result.isSuccess = true;
                result.returnValue = GetLoginResponse(clientUser);
            }
            return result;

        }

        public async Task<SaveResult> LoginAsync(string username, string password)
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

        public async Task<SaveResult> RefreshTokenAsync(string refreshToken)
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

        Login GetLoginResponse(ClientUser clientUser)
        {
            var response = new Login();
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
                var employee = dbContext.Employees.Include(i => i.employeeAuthorizations).FirstOrDefault(x => x.ID == clientUser.EmployeeID);
                if (employee == null)
                    return new Login();
                var company = dbContext.Companies.FirstOrDefault(x => x.ID == employee.CompanyID);
                if(company == null)
                    return new Login();

                response.clientKey = client.ClientValue;
                response.companyID = employee.CompanyID;
                response.companyName = company.CodeName;
                response.companyCode = company.Code;
                response.authoryGroup = employee.employeeAuthorizations.AuthoryGroup;
                response.authoryLevel = employee.employeeAuthorizations.AuthoryLevel;
                response.winTheme = employee.employeeAuthorizations.WinTheme;
                response.webTheme = employee.employeeAuthorizations.WebTheme;
                response.displayLanguage = employee.employeeAuthorizations.DisplayLanguage;

                response.customerIDs = (employee.employeeAuthorizations.AuthorizedCustomerIDs ?? "0").Split(';', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                response.customerGroupIDs = (employee.employeeAuthorizations.AuthorizedCustomerGroupIDs ?? "0").Split(';', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

                response.employeeID = employee.ID;
                response.fullName = employee.LongName;
                response.email = employee.Email;
                response.profileImagePath = string.Empty;


                var roleAuthories = dbContext.RoleAuthories.Where(x => x.AllowList && x.RoleID == employee.employeeAuthorizations.AuthoryRole).ToList();
                response.authories = GetUserAuthories(roleAuthories);
                response.mainMenu = GetUserMenuTree(response.authories, true);
                response.settingsMenu = GetUserMenuTree(response.authories, false);
            }

            globalDataContext.SaveChanges();

            return response;
        }

        private List<NavigationAuthory> GetUserAuthories(List<RoleAuthory> roleAuthories)
        {
            var roleAuthIDs = roleAuthories.Select(s=>s.MenuID).ToList();
            var navigationAuths = (from nvg in globalDataContext.Navigations.AsNoTracking()
                                   join trs in globalDataContext.NavigationTranslations.AsNoTracking() on nvg.ID equals trs.ParentID
                                   where roleAuthIDs.Contains(nvg.MenuTag)
                                         && trs.LanguageCode == loginResponse.workingLang
                                         && nvg.MenuActive
                                   select (new NavigationAuthory()
                                   {
                                       id = nvg.ID,
                                       authoryID = nvg.MenuTag,
                                       modulID = nvg.ModulID,
                                       formType = nvg.MenuFormType,
                                       menuName = trs.MenuName,
                                       editFormName = nvg.EditFormName,
                                       editFormPath = nvg.EditFormPath,
                                       listFormCaption = trs.ListFormCaption ?? "",
                                       editFormCaption = trs.EditFormCaption ?? "",
                                       listSourceName = nvg.ListSourceName ?? "",
                                       listSourceType = nvg.ListSourceType
                                   })).ToList();

            foreach (var auth in navigationAuths)
            {
                var roleAuth = roleAuthories.FirstOrDefault(x => x.MenuID == auth.authoryID);
                if (roleAuth != null)
                {
                    auth.allowList = roleAuth.AllowList;
                    auth.allowNew = roleAuth.AllowNew;
                    auth.allowEdit = roleAuth.AllowEdit;
                    auth.allowDelete = roleAuth.AllowDelete;
                    auth.allowPrint = roleAuth.AllowPrint;
                    auth.listTypeID = roleAuth.ListTypeID;
                    auth.reportIDs = "";

                }
            }

            return navigationAuths;
        }

        private List<NavigationMenu> GetUserMenuTree(List<NavigationAuthory> authories, bool isMainMenu)
        {
            var translationsList = globalDataContext.NavigationTranslations.Where(x => x.LanguageCode == loginResponse.workingLang).ToList();
            var authoryIDs =authories.Select(s=>s.id).ToList();
            //level 3 menu Items
            var level3MenuItems = globalDataContext
                                  .Navigations
                                  .Where(x => x.MenuActive && (isMainMenu ? x.MenuFormType > 1 : x.MenuFormType == 1)
                                        && authoryIDs.Contains(x.ID))
                                  .ToList();
            //level 2 menu items
            var level3MenuItemsParentIDs = level3MenuItems.Select(s => s.ParentID).Distinct().ToList();
            var level2MenuItems = globalDataContext.Navigations.Where(x => level3MenuItemsParentIDs.Contains(x.ID)).ToList();
            
            //level 1 menu items
            var level2MenuItemsParentIDs = level2MenuItems.Select(s => s.ParentID).Distinct().ToList();
            var level1MenuItems = globalDataContext.Navigations.Where(x => level2MenuItemsParentIDs.Contains(x.ID)).ToList();

            List<NavigationMenu> menuTree = new List<NavigationMenu>();
            foreach (var modulMenuItem in level1MenuItems.OrderBy(x => x.MenuOrder).ToList())
            {
                //Modul Grupları
                var parentMenuitem = new NavigationMenu();
                menuTree.Add(parentMenuitem);
                parentMenuitem.id = modulMenuItem.ID;
                parentMenuitem.authoryID = modulMenuItem.MenuTag;
                parentMenuitem.menuIcon = modulMenuItem.MenuIcon;
                parentMenuitem.modulID = modulMenuItem.ModulID;
                parentMenuitem.menuType = modulMenuItem.MenuFormType;
                var parentTranslation = translationsList.FirstOrDefault(x => x.ParentID == modulMenuItem.ID);
                if (parentTranslation == null)
                    parentMenuitem.menuName = "menuID:" + modulMenuItem.ID.ToString() + "--";
                else
                    parentMenuitem.menuName = parentTranslation.MenuName ?? "";
                // Alt Gruplar
                foreach (var childItem in level2MenuItems.Where(x => x.ParentID == modulMenuItem.ID).OrderBy(x => x.MenuOrder).ToList())
                {
                    var childMenuitem = new NavigationMenu();
                    parentMenuitem.items.Add(childMenuitem);
                    childMenuitem.id = childItem.ID;
                    childMenuitem.authoryID = childItem.MenuTag;
                    childMenuitem.menuIcon = childItem.MenuIcon;
                    childMenuitem.modulID = childItem.ModulID;
                    childMenuitem.menuType = childItem.MenuFormType;
                    var childTranslation = translationsList.FirstOrDefault(x => x.ParentID == childItem.ID);
                    if (childTranslation == null)
                        childMenuitem.menuName = "menuID:" + childItem.ID.ToString() + "--";
                    else
                        childMenuitem.menuName = childTranslation.MenuName ?? "";

                    // Menu Items
                    foreach (var item in level3MenuItems.Where(x => x.ParentID == childItem.ID).OrderBy(x => x.MenuOrder).ToList())
                    {
                        var menuitem = new NavigationMenu();
                        childMenuitem.items.Add(menuitem);
                        menuitem.id = item.ID;
                        menuitem.authoryID = item.MenuTag;
                        menuitem.menuIcon = item.MenuIcon;
                        menuitem.modulID = item.ModulID;
                        menuitem.menuType = item.MenuFormType;
                        var itemTranslation = translationsList.FirstOrDefault(x => x.ParentID == item.ID);
                        if (itemTranslation == null)
                            menuitem.menuName = "menuID:" + item.ID.ToString() + "--";
                        else
                            menuitem.menuName = itemTranslation.MenuName ?? "";
                    }
                }
            }
            return menuTree;
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

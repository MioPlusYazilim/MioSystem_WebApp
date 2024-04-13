using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Portal.Api.Data.Context;
using Portal.Api.Data.Entity.ClientEntity;
using Portal.Model;
using Portal.Model.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portal.Api.DataServis
{

    public interface ISystemService : IBaseClientService
    {
        Task<Role_Dto> GetRole(int id);
        Task<SaveResult> SaveRole(Role_Dto model);
        Task<List<SelectItem>> RoleSelectList();
        Task<object> RoleMainList();

        Task<object> GetCompanyInfo();
    }

    public class SystemService : BaseClientService, ISystemService
    {
        public SystemService(ClientDataContext _cLientContext, GlobalDataContext _globalContext, IMapper _Imapper, ISessionService _sessionServis) : base(_cLientContext, _globalContext, _Imapper, _sessionServis)
        {
        }

        public async Task<SaveResult> SaveRole(Role_Dto model)
        {
            var result = new SaveResult();
            try
            {
                var rolegroup = imapper.Map<Role>(model);
                using (UnitOfWork uow = new UnitOfWork(clientContext))
                {
                    if (model.deleted)
                        clientContext.Entry(rolegroup).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                    else
                        clientContext.Set<Role>().Update(rolegroup);

                    uow.BeginTransaction();
                    result = await uow.SaveChangesAsync();
                    if (result.isSuccess == false)
                        goto fail;

                    foreach (var roleModel in model.authories)
                    {
                        if (model.deleted)
                            roleModel.deleted = true;

                        var role = imapper.Map<RoleAuthory>(roleModel);

                        if (roleModel.deleted)
                            clientContext.Entry(role).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                        else
                            clientContext.Set<RoleAuthory>().Update(role);

                        result = await uow.SaveChangesAsync();
                        if (result.isSuccess == false)
                            goto fail;
                    }
                    uow.CommitTransaction();
                    result.returnValue = rolegroup.ID;
                    return result;

                    fail:
                    uow.RollBackTransaction();
                    return result;
                }
            }
            catch (Exception ex)
            {
                return result;
            }
        }

        public async Task<Role_Dto> GetRole(int id)
        {
            try
            {
                var rolgroup = await clientContext.Roles.Include(i => i.authories).FirstOrDefaultAsync(s => s.ID == id);
                if (rolgroup == null) return null;
                var model = imapper.Map<Role_Dto>(rolgroup);
                return model;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<List<SelectItem>> RoleSelectList()
        {
            try
            {
                return await Task.Run(() =>
                                  clientContext
                                  .Roles
                                  .Select(s => new SelectItem()
                                  {
                                      value = s.ID,
                                      name = s.RoleName
                                  }).ToList());

            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public async Task<object> RoleMainList()
        {
            try
            {
                return await Task.Run(() =>
                                  clientContext
                                  .Roles
                                  .Select(s => new
                                  {
                                      id = s.ID,
                                      grupAdi = s.RoleName,
                                      aktif = s.Active
                                  }).ToList());

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<object> GetCompanyInfo()
        {
            try
            {
                return await Task.Run(() =>
                                  clientContext
                                  .CompanyGetInfoViews
                                  .FirstOrDefault());

            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
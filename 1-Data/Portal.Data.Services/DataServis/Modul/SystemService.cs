﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Portal.Data.Context;
using Portal.Data.Entities.ClientEntities;
using Portal.Helpers;
using Portal.Model;

namespace Portal.Data.Services
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
        public SystemService()
        {
        }

        public override MapperConfiguration createMapConfig()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Role, Role_Dto>().ReverseMap();
                cfg.CreateMap<RoleAuthory, RoleAuthory_Dto>().ReverseMap();

            });
            return config;
        }
        public async Task<SaveResult> SaveRole(Role_Dto model)
        {
            var result = new SaveResult();
            try
            {
                var rolegroup = mapper.Map<Role>(model);
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

                        var role = mapper.Map<RoleAuthory>(roleModel);

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
                var model = mapper.Map<Role_Dto>(rolgroup);
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
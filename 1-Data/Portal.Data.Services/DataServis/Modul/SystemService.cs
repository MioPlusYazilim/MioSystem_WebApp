using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Portal.Data.Context;
using Portal.Data.Entities.ClientEntities;
using Portal.Helpers;
using Portal.Model;

namespace Portal.Data.Services
{

    public interface ISystemService : IBaseClientService
    {
        Task<RoleAuthory_Model> GetRole(int id);
        Task<SaveResult> SaveRole(RoleAuthory_Model model);
        Task<List<SelectItem>> RoleSelectList();
        Task<object> RoleMainList();

        Task<object> GetCompanyInfo();

        Department_Model GetDepartment(int ID);
       Task<Department_Model> GetDepartmentAsync(int ID);
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
                cfg.CreateMap<RoleAuthory, RoleAuthory_Model>().ReverseMap();
                cfg.CreateMap<RoleAuthoryPermission, RoleAuthoryPermission_Model>().ReverseMap();
                cfg.CreateMap<Department, Department_Model>().ReverseMap();

            });
            return config;
        }

        public Department_Model GetDepartment(int ID)
        {
            var department= clientContext.Departments.AsNoTracking().FirstOrDefault(x => x.ID == ID);
            return mapper.Map<Department_Model>(department);
        }
        public async Task<Department_Model> GetDepartmentAsync(int ID)
        {
            return await Task.Run(() =>
            {
                return GetDepartment(ID);
            });
        }
        public async Task<SaveResult> SaveRole(RoleAuthory_Model model)
        {
            var result = new SaveResult();
            try
            {
                var rolegroup = mapper.Map<RoleAuthory>(model);
                using (UnitOfWork uow = new UnitOfWork(clientContext))
                {
                    if (model.deleted)
                        clientContext.Entry(rolegroup).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                    else
                        clientContext.Set<RoleAuthory>().Update(rolegroup);

                    uow.BeginTransaction();
                    result = await uow.SaveChangesAsync();
                    if (result.isSuccess == false)
                        goto fail;

                    foreach (var roleModel in model.authories)
                    {
                        if (model.deleted)
                            roleModel.deleted = true;

                        var role = mapper.Map<RoleAuthoryPermission>(roleModel);

                        if (roleModel.deleted)
                            clientContext.Entry(role).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                        else
                            clientContext.Set<RoleAuthoryPermission>().Update(role);

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

        public async Task<RoleAuthory_Model> GetRole(int id)
        {
            try
            {
                var rolgroup = await clientContext.RoleAuthories.Include(i => i.permissions).FirstOrDefaultAsync(s => s.ID == id);
                if (rolgroup == null) return null;
                var model = mapper.Map<RoleAuthory_Model>(rolgroup);
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
                                  .RoleAuthories
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
                                  .RoleAuthories
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
﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Portal.Data.Context;
using Portal.Data.Entities.ClientEntities;
using Portal.Helpers;
using Portal.Model;

namespace Portal.Data.Services
{
    public interface IEmployeeService : IBaseClientService
    {
        
        SaveResult AddOrUpdateEmployee(Employee_Model model);
        Task<SaveResult> AddOrUpdateEmployeeAsync(Employee_Model model);
        SaveResult DeleteEmployee(int id);
        Task<SaveResult> DeleteEmployeeAsync(int id);
        object EmployeeMainList();
        Task<object> EmployeeMainListAsync();
        Employee_Model GetEmployee(int id);
        Task<Employee_Model> GetEmployeeAsync(int id);
        List<SelectItem> GetEmployeeSelectList();
        Task<List<SelectItem>> GetEmployeeSelectListAsync();
    }

    public class EmployeeService : BaseClientService, IEmployeeService
    {
        
        public EmployeeService()
        {
        }

        public override MapperConfiguration createMapConfig()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Employee, Employee_Model>().ReverseMap();
                cfg.CreateMap<EmployeeAuthorization, EmployeeAuthory_Model>().ReverseMap();
                cfg.CreateMap<EmployeeSystemCode, EmployeeSystemCode_Model>().ReverseMap();

            });
            return config;
        }
        public SaveResult AddOrUpdateEmployee(Employee_Model model)
        {
            SaveResult result = new SaveResult();

            try
            {
                Employee employee = new();
                if (model.id == 0)
                {
                    employee = mapper.Map<Employee>(model);
                    clientContext.Set<Employee>().Update(employee);
                }
                else
                {
                    var mEntity = mapper.Map<Employee>(model);
                    employee = clientContext.Employees
                                            .Include(i => i.employeeAuthorizations)
                                            .Include(i => i.employeeSystemCodes)
                                            .FirstOrDefault(x => x.ID == model.id);

                    clientContext.Entry(employee).CurrentValues.SetValues(mEntity);
                    if (mEntity.Deleted)
                        clientContext.Entry(employee).State = EntityState.Deleted;

                    foreach (var mExtra in mEntity.employeeSystemCodes.Where(x => x.ID > 0))
                    {
                        var extra = employee.employeeSystemCodes.FirstOrDefault(x => x.ID == mExtra.ID);
                        if (extra != null)
                        {
                            clientContext.Entry(extra).CurrentValues.SetValues(mExtra);
                            if (mExtra.Deleted)
                                clientContext.Entry(extra).State = EntityState.Deleted;
                        }
                    }
                    employee.employeeSystemCodes.AddRange(mEntity.employeeSystemCodes.Where(x => x.ID == 0));
                }
                using (var uow = new UnitOfWork(clientContext))
                    result = uow.SaveChanges();

                if (result.isSuccess)
                {
                    result.returnValue = employee.ID;
                }
            }
            catch (Exception ex)
            {
                result.errorMessage = ex.Message;
            }

            return result;
        }

        public async Task<SaveResult> AddOrUpdateEmployeeAsync(Employee_Model model)
        {
            return await Task.Run(() => AddOrUpdateEmployee(model));
        }


        public SaveResult DeleteEmployee(int id)
        {
            var result = new SaveResult();
            try
            {
                using (UnitOfWork uow = new UnitOfWork(clientContext))
                {
                    var user = clientContext.Employees
                                        .Include(i => i.employeeAuthorizations)
                                        .Include(i => i.employeeSystemCodes)
                                        .FirstOrDefault(x => x.ID == id);

                    clientContext.Entry(user).State = EntityState.Deleted;

                    uow.BeginTransaction();
                    result = uow.SaveChanges();
                    if (result.isSuccess == false)
                        goto fail;

                    uow.CommitTransaction();
                    result.returnValue = 0;
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
        public async Task<SaveResult> DeleteEmployeeAsync(int id)
        {
            return await Task.Run(() => DeleteEmployee(id));
        }

        public object EmployeeMainList()
        {

            return clientContext.Employees
                                .Include(i => i.employeeAuthorizations)
                                .Select(s => new EmployeeMainListWM
                                {
                                    id = s.ID,
                                    fullName = s.LongName,
                                    email = s.Email,
                                    mobilePhone = s.GSMNumber,
                                    authoryGroup = s.employeeAuthorizations.AuthoryGroup < 2 ? "Personel" : "Müşteri",
                                    authoryLevel = s.employeeAuthorizations.AuthoryLevel == 1 ? "Personel" : s.employeeAuthorizations.AuthoryLevel == 2 ? "Departman Admin" : "Admin",
                                    authorizedCustomerIDs = s.employeeAuthorizations.AuthorizedCustomerIDs,
                                    authorizedCustomerGroupIDs = s.employeeAuthorizations.AuthorizedCustomerGroupIDs
                                })
                                .ToList()
                                .Where(x => loginResponse.authoryGroup == 2 ? (loginResponse.authoryLevel == 1 ? x.id == loginResponse.employeeID : x.cariList.Intersect(loginResponse.customerIDs).ToList().Count > 0) : true)
                                .ToList();
        }
        public async Task<object> EmployeeMainListAsync()
        {

            return await Task.Run(EmployeeMainList);
        }

        public Employee_Model GetEmployee(int id)
        {
            var user = clientContext.Employees
                                      .Include(i => i.employeeAuthorizations)
                                      .Include(i => i.employeeSystemCodes)
                                      .FirstOrDefault(x => x.ID == id);
            if (user == null)
                return null;
            return mapper.Map<Employee_Model>(user);
        }
        public async Task<Employee_Model> GetEmployeeAsync(int id)
        {
            return await Task.Run(() => GetEmployee(id));
        }

        public List<SelectItem> GetEmployeeSelectList()
        {

            List<SelectItem> list = new List<SelectItem>();
            var custIDs = loginResponse.customerIDs;
            if (loginResponse.authoryGroup == 1) // Acenta Personel
            {
                list = clientContext.EmployeeSelectViews
                .Select(s => new SelectItem()
                {
                    value = s.ID,
                    name = s.FullName,
                }).ToList();
            }
            else // Müşteri Personel
            {
                // .Where(x => loginResponse.authoryGroup == 1 ? true : (session.CustomerIDs.Contains(x.ID) || session.CustomerGroupIDs.Contains(x.GroupID)))
                list = clientContext.EmployeeSelectViews
                .Where(x => loginResponse.authoryLevel == 1 ? x.ID == loginResponse.employeeID : loginResponse.authoryLevel == 2 ? x.DepartmentID == loginResponse.departmentID : (loginResponse.customerIDs.Contains(x.ID) || loginResponse.customerGroupIDs.Contains(x.CustomerGrupID)))
                .Select(s => new SelectItem()
                {
                    value = s.ID,
                    name = s.FullName,

                }).ToList();
            }
            return list;
        }
        public async Task<List<SelectItem>> GetEmployeeSelectListAsync()
        {
            return await Task.Run(GetEmployeeSelectList);
        }
        
    }
}

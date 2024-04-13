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
    public interface IEmployeeService : IBaseClientService
    {
        Task<SaveResult> AddOrUpdateEmployee(Employee_Dto model);
        Task<SaveResult> DeleteEmployee(int id);
        Task<List<EmployeeMainListWM>> EmployeeMainList();
        Task<Employee_Dto> GetEmployee(int id);
        Task<List<SelectItem>> GetEmployeeSelectList();
    }

    public class EmployeeService : BaseClientService, IEmployeeService
    {
        
        public EmployeeService(ClientDataContext _cLientContext, GlobalDataContext _globalContext, IMapper _Imapper, ISessionService _sessionServis) : base(_cLientContext, _globalContext, _Imapper, _sessionServis)
        {
        }

        public async Task<SaveResult> AddOrUpdateEmployee(Employee_Dto model)
        {
            return await Task.Run(()=>
            {
                var result = new SaveResult();
                try
                {
                    using (UnitOfWork uow = new UnitOfWork(clientContext))
                    {
                        var user = imapper.Map<Employee>(model);
                        clientContext.Set<Employee>().Update(user);
                        if (user.Deleted == false)
                        {
                            foreach (var itm in user.employeeSystemCodes)
                            {
                                if (itm.ID == 0 && itm.Deleted)
                                    clientContext.Entry(itm).State = EntityState.Detached;
                                if (itm.Deleted)
                                    clientContext.Entry(itm).State = EntityState.Deleted;
                            }
                        }

                        uow.BeginTransaction();
                        result = uow.SaveChanges();
                        if (result.isSuccess == false)
                            goto fail;

                        uow.CommitTransaction();
                        result.returnValue = model;
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
            });
        }

        public async Task<SaveResult> DeleteEmployee(int id)
        {
            var result = new SaveResult();
            try
            {
                using (UnitOfWork uow = new UnitOfWork(clientContext))
                {
                    var user = clientContext.Employees
                                        .Include(i => i.employeeParameters)
                                        .Include(i => i.employeeSystemCodes)
                                        .FirstOrDefault(x => x.ID == id);

                    clientContext.Entry(user).State = EntityState.Deleted;

                    uow.BeginTransaction();
                    result = await uow.SaveChangesAsync();
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

        public async Task<List<EmployeeMainListWM>> EmployeeMainList()
        {
            List<int> CompanyIds = new List<int>();

            return await Task.Run(() => clientContext.Employees
                                                   .Include(i => i.employeeParameters)
                                                   .Select(s => new EmployeeMainListWM
                                                   {
                                                       id = s.ID,
                                                       fullName = s.LongName,
                                                       email = s.Email,
                                                       mobilePhone = s.GSMNumber,
                                                       authoryGroup = s.employeeParameters.AuthoryGroup < 2 ? "Personel" : "Müşteri",
                                                       authoryLevel = s.employeeParameters.AuthoryLevel == 1 ? "Personel" : s.employeeParameters.AuthoryLevel == 2 ? "Departman Admin" : "Admin",
                                                       authorizedCustomerIDs = s.employeeParameters.AuthorizedCustomerIDs,
                                                       authorizedCustomerGroupIDs = s.employeeParameters.AuthorizedCustomerGroupIDs
                                                   })
                                                   .ToList()
                                                   .Where(x => session.AuthoryGroup == 2 ? (session.AuthoryLevel == 1 ? x.id == session.EmployeeID : x.cariList.Intersect(session.CustomerIDs).ToList().Count > 0) : true).ToList());
        }

        public async Task<Employee_Dto> GetEmployee(int id)
        {
            var user = await clientContext.Employees
                                      .Include(i => i.employeeParameters)
                                      .Include(i => i.employeeSystemCodes)
                                      .FirstOrDefaultAsync(x => x.ID == id);
            if (user == null)
                return null;
            return imapper.Map<Employee_Dto>(user);
        }

        public async Task<List<SelectItem>> GetEmployeeSelectList()
        {
            return await Task.Run(() =>
            {
                List<SelectItem> list = new List<SelectItem>();
                var custIDs = sessionService.sessionInfo.CustomerIDs;
                if (sessionService.sessionInfo.AuthoryGroup == 1) // Acenta Personel
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
                    // .Where(x => session.AuthoryGroup == 1 ? true : (session.CustomerIDs.Contains(x.ID) || session.CustomerGroupIDs.Contains(x.GroupID)))
                    list = clientContext.EmployeeSelectViews
                    .Where(x => session.AuthoryLevel == 1 ? x.ID == session.EmployeeID : session.AuthoryLevel == 2 ? x.DepartmentID == session.DepartmentID : (session.CustomerIDs.Contains(x.ID) || session.CustomerGroupIDs.Contains(x.CustomerGrupID)))
                    .Select(s => new SelectItem()
                    {
                        value = s.ID,
                        name = s.FullName,

                    }).ToList();
                }
                return list;
            });
        }

    }
}

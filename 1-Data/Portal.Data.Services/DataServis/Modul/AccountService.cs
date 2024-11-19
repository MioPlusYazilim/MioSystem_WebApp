using AutoMapper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Portal.Data.Context;
using Portal.Data.Entities.ClientEntities;
using Portal.Helpers;
using Portal.Model;
using System.Data;

namespace Portal.Data.Services
{
    public interface IAccountService : IBaseClientService
    {
        Task<List<SelectItem>> GetCustomerSelectList(int TypeID);
        Task<List<SelectItem>> GetCustomerProjectSelectList();
        Task<List<SelectItem>> GetCustomerCorporateSelectList(int TypeID);
        Task<List<SelectItem>> GetCustomersGroupSelectList();
        Task<List<SelectItem>> GetCurrencySelectList();
        Task<List<SelectItem>> GetCurrencyRateTypeSelectList();
        Task<List<SelectItem>> GetSupplierChainSelectList();
    }
    public class AccountService : BaseClientService, IAccountService
    {
        public AccountService()
        {
        }

        public async Task<List<SelectItem>> GetCustomerProjectSelectList()
        {
            return await Task.Run(() => clientContext
                                        .CustomerProjectSelectViews
                                        .Where(x => loginResponse.authoryGroup == 1 ? true : (loginResponse.customerIDs.Contains(x.ID) || loginResponse.customerGroupIDs.Contains(x.GroupID)))
                                        .Select(s => new SelectItem()
                                        {
                                            value = s.ID,
                                            code= s.Code,
                                            name= s.Name
                                        }).ToList());
        }
        public async Task<List<SelectItem>> GetCustomerSelectList(int TypeID)
        {
            return await Task.Run(() => clientContext
                                        .CustomerSelectViews
                                        .Where(x => x.TypeID==TypeID && loginResponse.authoryGroup == 1 ? true :(loginResponse.customerIDs.Contains(x.ID)|| loginResponse.customerGroupIDs.Contains(x.GroupID)))
                                        .Select(s => new SelectItem()
                                        {
                                            value = s.ID,
                                            name = s.FullName
                                        }).ToList());
        }
        public async Task<List<SelectItem>> GetCustomersGroupSelectList()
        {
            return await Task.Run(() => clientContext
                                        .CustomerGroupSelectViews
                                        .Select(s => new SelectItem()
                                        {
                                            value = s.ID,
                                            code = s.Code,
                                            name= s.FullName
                                        }).ToList());
        }
        public async Task<List<SelectItem>> GetCustomerCorporateSelectList(int TypeID)
        {
            return await Task.Run(() => clientContext
                                        .CustomerCorporateSelectViews
                                        .Where(x => x.TypeID == TypeID 
                                                  && loginResponse.authoryGroup == 1 ? true :(loginResponse.customerIDs.Contains(x.CustomerID) || loginResponse.customerGroupIDs.Contains(x.CustomerGroupID))
                                                  && loginResponse.authoryLevel <= 2 ? x.ID==loginResponse.departmentID: true
                                          )
                                        .Select(s => new SelectItem()
                                        {
                                            value = s.ID,
                                            code = s.Code,
                                            name = s.FullName
                                        }).ToList());
        }
        public async Task<List<SelectItem>> GetCurrencySelectList()
        {
            return await Task.Run(() => globalContext
                                        .Currencies
                                        .Where(x => x.LanguageCode == loginResponse.displayLanguage)
                                        .Select(s => new SelectItem()
                                        {
                                            value = s.ID,
                                            code = s.FieldValue,
                                            name = s.FieldName
                                        }).ToList());
        }
        public async Task<List<SelectItem>> GetCurrencyRateTypeSelectList()
        {
            return await Task.Run(() => globalContext
                                        .CurrencyRateTypes
                                        .Select(s => new SelectItem()
                                        {
                                            value = s.ID,
                                            code = s.FieldValue,
                                            name = s.FieldName
                                        }).ToList());
        }
        public async Task<List<SelectItem>> GetSupplierChainSelectList()
        {
            return await Task.Run(() => clientContext
                                        .SupplierChains
                                        .Select(s => new SelectItem()
                                        {
                                            value = s.ID,
                                            code = s.Code,
                                            name = s.CodeName
                                        }).ToList());
        }
    }
}

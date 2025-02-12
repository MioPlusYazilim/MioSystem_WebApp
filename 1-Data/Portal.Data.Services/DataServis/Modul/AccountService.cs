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
        Task<List<SelectItem>> GetCurrencySelectList();
        Task<List<SelectItem>> GetCurrencyRateTypeSelectList();
    }
    public class AccountService : BaseClientService, IAccountService
    {
        public AccountService()
        {
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
    }
}

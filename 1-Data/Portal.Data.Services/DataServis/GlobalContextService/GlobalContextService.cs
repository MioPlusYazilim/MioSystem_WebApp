using AutoMapper;
using Portal.Data.Services.Base;
using Portal.Data.Context;
using Portal.Helpers;
using Portal.Model;
using Portal.Data.Entities.GlobalEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace Portal.Data.Services.GlobalContextService
{
    public interface IGlobalContextService : IBaseGlobalService
    {
        string GetSystemMessageValue(int MessageID);
        string GetSystemMessageValue(string MessageName);
        AccountingSystem_Model GetAccountingSystem(int ID);
        Task<AccountingSystem_Model> GetAccountingSystemAsync(int ID);
        List<SelectItem> GetAirLineSelectList(string LengCode);
        Task<List<SelectItem>> GetAirLineSelectListAsync(string LengCode);

        List<SelectItem> GetAirPortSelectList(string LengCode);
        Task<List<SelectItem>> GetAirPortSelectListAsync(string LengCode);
        List<SelectItem> GetAutoInvoiceTypeSelectList(string LengCode);
        Task<List<SelectItem>> GetAutoInvoiceTypeSelectListAsync(string LengCode);
        List<SelectItem> GetAutoNumberTypeSelectList(string LengCode);
        Task<List<SelectItem>> GetAutoNumberTypeSelectListAsync(string LengCode);
        List<SelectItem> GetAutoServiceTypeSelectList(string LengCode);
        Task<List<SelectItem>> GetAutoServiceTypeSelectListAsync(string LengCode);
        List<SelectItem> GetCarBrandSelectList(string LengCode);
        Task<List<SelectItem>> GetCarBrandSelectListAsync(string LengCode);
        List<SelectItem> GetCarClassTypeSelectList(string LengCode);
        Task<List<SelectItem>> GetCarClassTypeSelectListAsync(string LengCode);
        List<SelectItem> GetCareerGroupSelectList(string LengCode);
        Task<List<SelectItem>> GetCareerGroupSelectListAsync(string LengCode);
        List<SelectItem> GetCarSegmentTypeSelectList(string LengCode);
        Task<List<SelectItem>> GetCarSegmentTypeSelectListAsync(string LengCode);
        List<SelectItem> GetCategoriesSelectList(string LengCode);
        Task<List<SelectItem>> GetCategoriesSelectListAsync(string LengCode);
        List<SelectItem> GetCitySelectList(string LengCode);
        Task<List<SelectItem>> GetCitySelectListAsync(string LengCode);
        List<SelectItem> GetContinentSelectList(string LengCode);
        Task<List<SelectItem>> GetContinentSelectListAsync(string LengCode);
        List<SelectItem> GetCorporateTypeSelectList(string LengCode);
        Task<List<SelectItem>> GetCorporateTypeSelectListAsync(string LengCode);
        List<SelectItem> GetCountrySelectList(string LengCode);
        Task<List<SelectItem>> GetCountrySelectListAsync(string LengCode);
        List<SelectItem> GetCurrencySelectList(string LengCode);
        Task<List<SelectItem>> GetCurrencySelectListAsync(string LengCode);
        List<SelectItem> GetCurrencyRateTypeSelectList(string LengCode);
        Task<List<SelectItem>> GetCurrencyRateTypeSelectListAsync(string LengCode);
        List<SelectItem> GetCustomerTypeSelectList(string LengCode);
        Task<List<SelectItem>> GetCustomerTypeSelectListAsync(string LengCode);
        List<SelectItem> GetDeclarationTypeSelectList(string LengCode);
        Task<List<SelectItem>> GetDeclarationTypeSelectListAsync(string LengCode);
        List<SelectItem> GetDirectionSelectList(string LengCode);
        Task<List<SelectItem>> GetDirectionSelectListAsync(string LengCode);
        List<SelectItem> GetDistrictSelectList(string LengCode);
        Task<List<SelectItem>> GetDistrictSelectListAsync(string LengCode);
        List<SelectItem> GetExceptionCodeSelectList(string LengCode);
        Task<List<SelectItem>> GetExceptionCodeSelectListAsync(string LengCode);
        List<SelectItem> GetExceptionTypeSelectList(string LengCode);
        Task<List<SelectItem>> GetExceptionTypeSelectListAsync(string LengCode);
        List<SelectItem> GetFlightCabinTypeSelectList(string LengCode);
        Task<List<SelectItem>> GetFlightCabinTypeSelectListAsync(string LengCode);
        List<SelectItem> GetFlightDistanceSelectList(string LengCode);
        Task<List<SelectItem>> GetFlightDistanceSelectListAsync(string LengCode);
        List<SelectItem> GetFlightFlexTypeSelectList(string LengCode);
        Task<List<SelectItem>> GetFlightFlexTypeSelectListAsync(string LengCode);
        List<SelectItem> GetFlightFoodTypeSelectList(string LengCode);
        Task<List<SelectItem>> GetFlightFoodTypeSelectListAsync(string LengCode);
        List<SelectItem> GetFlightLineDistanceSelectList(string LengCode);
        Task<List<SelectItem>> GetFlightLineDistanceSelectListAsync(string LengCode);
        List<SelectItem> GetFlightLineTypeSelectList(string LengCode);
        Task<List<SelectItem>> GetFlightLineTypeSelectListAsync(string LengCode);
        List<SelectItem> GetFlightLineZoneSelectList(string LengCode);
        Task<List<SelectItem>> GetFlightLineZoneSelectListAsync(string LengCode);
        List<SelectItem> GetFlightSeatTypeSelectList(string LengCode);
        Task<List<SelectItem>> GetFlightSeatTypeSelectListAsync(string LengCode);
        List<SelectItem> GetFlightStatusTypeSelectList(string LengCode);
        Task<List<SelectItem>> GetFlightStatusTypeSelectListAsync(string LengCode);
        List<SelectItem> GetFlightSupplierTypeSelectList(string LengCode);
        Task<List<SelectItem>> GetFlightSupplierTypeSelectListAsync(string LengCode);
        List<SelectItem> GetFuelTypeSelectList(string LengCode);
        Task<List<SelectItem>> GetFuelTypeSelectListAsync(string LengCode);
        //List<SelectItem> GetGlobalDeclarationSelectList(string LengCode);
        //Task<List<SelectItem>> GetGlobalDeclarationSelectListAsync(string LengCode);
        //List<SelectItem> GetGlobalModuleSelectList(string LengCode);
        //Task<List<SelectItem>> GetGlobalModuleSelectListAsync(string LengCode);
        List<SelectItem> GetGlobalReportTypeSelectList(string LengCode);
        Task<List<SelectItem>> GetGlobalReportTypeSelectListAsync(string LengCode);
        List<SelectItem> GetGlobalTranslationSelectList(string LengCode);
        Task<List<SelectItem>> GetGlobalTranslationSelectListAsync(string LengCode);
        List<SelectItem> GetHotelBedTypeSelectList(string LengCode);
        Task<List<SelectItem>> GetHotelBedTypeSelectListAsync(string LengCode);
        List<SelectItem> GetHotelClassTypeSelectList(string LengCode);
        Task<List<SelectItem>> GetHotelClassTypeSelectListAsync(string LengCode);
        List<SelectItem> GetHotelHostelTypeSelectList(string LengCode);
        Task<List<SelectItem>> GetHotelHostelTypeSelectListAsync(string LengCode);
        List<SelectItem> GetHotelTypeSelectList(string LengCode);
        Task<List<SelectItem>> GetHotelTypeSelectListAsync(string LengCode);
        List<SelectItem> GetIntegratorSystemSelectList(string LengCode);
        Task<List<SelectItem>> GetIntegratorSystemSelectListAsync(string LengCode);
        List<SelectItem> GetInvoiceOptionTypeSelectList(string LengCode);
        Task<List<SelectItem>> GetInvoiceOptionTypeSelectListAsync(string LengCode);
        List<SelectItem> GetInvoiceTransactionTypeSelectList(string LengCode);
        Task<List<SelectItem>> GetInvoiceTransactionTypeSelectListAsync(string LengCode);
        List<SelectItem> GetInvoiceTypeSelectList(string LengCode);
        Task<List<SelectItem>> GetInvoiceTypeSelectListAsync(string LengCode);
        List<SelectItem> GetLanguageTypeSelectList(string LengCode);
        Task<List<SelectItem>> GetLanguageTypeSelectListAsync(string LengCode);
        List<SelectItem> GetModuleTypeSelectList(string LengCode);
        Task<List<SelectItem>> GetModuleTypeSelectListAsync(string LengCode);
        List<SelectItem> GetMonthTypeSelectList(string LengCode);
        Task<List<SelectItem>> GetMonthTypeSelectListAsync(string LengCode);
        List<SelectItem> GetPassengerTypeSelectList(string LengCode);
        Task<List<SelectItem>> GetPassengerTypeSelectListAsync(string LengCode);
        List<SelectItem> GetPassportTypeSelectList(string LengCode);
        Task<List<SelectItem>> GetPassportTypeSelectListAsync(string LengCode);
        List<SelectItem> GetPayerTypeSelectList(string LengCode);
        Task<List<SelectItem>> GetPayerTypeSelectListAsync(string LengCode);
        List<SelectItem> GetPaymentTermTypeSelectList(string LengCode);
        Task<List<SelectItem>> GetPaymentTermTypeSelectListAsync(string LengCode);
        List<SelectItem> GetPaymentTypeSelectList(string LengCode);
        Task<List<SelectItem>> GetPaymentTypeSelectListAsync(string LengCode);
        List<SelectItem> GetRegionTypeSelectList(string LengCode);
        Task<List<SelectItem>> GetRegionTypeSelectListAsync(string LengCode);
        List<SelectItem> GetReportOptionTypeSelectList(string LengCode);
        Task<List<SelectItem>> GetReportOptionTypeSelectListAsync(string LengCode);
        List<SelectItem> GetRoleDateSelectList(string LengCode);
        Task<List<SelectItem>> GetRoleDateSelectListAsync(string LengCode);
        List<SelectItem> GetSendInfoTypeSelectList(string LengCode);
        Task<List<SelectItem>> GetSendInfoTypeSelectListAsync(string LengCode);
        List<SelectItem> GetShipCabinTypeSelectList(string LengCode);
        Task<List<SelectItem>> GetShipCabinTypeSelectListAsync(string LengCode);
        List<SelectItem> GetSourceTypeSelectList(string LengCode);
        Task<List<SelectItem>> GetSourceTypeSelectListAsync(string LengCode);
        List<SelectItem> GetSpecialCodeTypeSelectList(string LengCode);
        Task<List<SelectItem>> GetSpecialCodeTypeSelectListAsync(string LengCode);
        List<SelectItem> GetTitleTypeSelectList(string LengCode);
        Task<List<SelectItem>> GetTitleTypeSelectListAsync(string LengCode);
        List<SelectItem> GetTransactionGroupSelectList(string LengCode);
        Task<List<SelectItem>> GetTransactionGroupSelectListAsync(string LengCode);
        List<SelectItem> GetUnitCodeTypeSelectList(string LengCode);
        Task<List<SelectItem>> GetUnitCodeTypeSelectListAsync(string LengCode);
        List<SelectItem> GetVisaTypeSelectList(string LengCode);
        Task<List<SelectItem>> GetVisaTypeSelectListAsync(string LengCode);
        List<SelectItem> GetWorkerTypeSelectList(string LengCode);
        Task<List<SelectItem>> GetWorkerTypeSelectListAsync(string LengCode);

    }
    public class GlobalContextService : BaseGlobalService, IGlobalContextService
    {
        public GlobalContextService()
        {
        }

        public string GetSystemMessageValue(int MessageID)
        {
            return dbContext.SystemMessagesTranslations
                            .Where(x => x.ParentID == MessageID && x.LanguageCode == Login.GetLoginUser().displayLanguage)
                            .Select(x => x.FieldValue)
                            .FirstOrDefault() ?? "";
        }

        public string GetSystemMessageValue(string MessageName)
        {
            var msg = dbContext.SystemMessages.FirstOrDefault(x => x.MessageName == MessageName);
            if (msg == null)
                return string.Empty;

            return dbContext.SystemMessagesTranslations
                              .Where(x => x.ParentID == msg.ID && x.LanguageCode == Login.GetLoginUser().displayLanguage)
                              .Select(x => x.FieldValue)
                              .FirstOrDefault() ?? "";
        }

        public AccountingSystem_Model GetAccountingSystem(int ID)
        {
            var accountingSystem = dbContext.AccountingSystems.AsNoTracking().FirstOrDefault(x => x.ID == ID);
            return mapper.Map<AccountingSystem_Model>(accountingSystem);
        }
        public async Task<AccountingSystem_Model> GetAccountingSystemAsync(int ID)
        {
            return await Task.Run(() =>
            {
                return GetAccountingSystem(ID);
            });
        }

        public List<SelectItem> GetAirLineSelectList(string LengCode)
        {
            return dbContext.Airlines.AsNoTracking()
                                     .Where(x => x.LanguageCode == LengCode)
                                     .Select(s => new SelectItem()
                                     {
                                         value = s.ID,
                                         code = s.FieldValue,
                                         name = s.FieldName
                                     })
                                     .ToList();
        }
        public async Task<List<SelectItem>> GetAirLineSelectListAsync(string LengCode)
        {
            return await Task.Run(() => GetAirLineSelectList(LengCode));
        }
        public List<SelectItem>GetAirPortSelectList(string LengCode)
        {
            return dbContext.AirPorts.AsNoTracking()
                                        .Where(x => x.LanguageCode == LengCode)
                                        .Select(s => new SelectItem()
                                        {
                                            value = s.ID,
                                            code = s.FieldValue,
                                            name = s.FieldName
                                        })
                                        .ToList();
        }
        public async Task<List<SelectItem>> GetAirPortSelectListAsync(string LengCode) 
        { 
            return await Task.Run(() => GetAirPortSelectList(LengCode)); 
        }
        public List<SelectItem>GetAutoInvoiceTypeSelectList(string LengCode)
        {
            return dbContext.AutoInvoiceTypes.AsNoTracking()
                                     .Where(x => x.LanguageCode == LengCode)
                                     .Select(s => new SelectItem()
                                     {
                                         value = s.ID,
                                         code = s.FieldValue,
                                         name = s.FieldName
                                     })
                                     .ToList();
        }
        public async Task<List<SelectItem>> GetAutoInvoiceTypeSelectListAsync(string LengCode)
        {
            return await Task.Run(() => GetAutoInvoiceTypeSelectList(LengCode));
        }
        public List<SelectItem>GetAutoNumberTypeSelectList(string LengCode)
        {
            return dbContext.AutoNumberTypes.AsNoTracking()
                                     .Where(x => x.LanguageCode == LengCode)
                                     .Select(s => new SelectItem()
                                     {
                                         value = s.ID,
                                         code = s.FieldValue,
                                         name = s.FieldName
                                     })
                                     .ToList();
        }
        public async Task<List<SelectItem>> GetAutoNumberTypeSelectListAsync(string LengCode)
        {
            return await Task.Run(() => GetAutoNumberTypeSelectList(LengCode));
        }
        public List<SelectItem>GetAutoServiceTypeSelectList(string LengCode)
        {
            return dbContext.AutoServiceTypes.AsNoTracking()
                                     .Where(x => x.LanguageCode == LengCode)
                                     .Select(s => new SelectItem()
                                     {
                                         value = s.ID,
                                         code = s.FieldValue,
                                         name = s.FieldName
                                     })
                                     .ToList();
        }
        public async Task<List<SelectItem>> GetAutoServiceTypeSelectListAsync(string LengCode)
        {
            return await Task.Run(() => GetAutoServiceTypeSelectList(LengCode));
        }
        public List<SelectItem>GetCarBrandSelectList(string LengCode)
        {
            return dbContext.CarBrands.AsNoTracking()
                                     .Where(x => x.LanguageCode == LengCode)
                                     .Select(s => new SelectItem()
                                     {
                                         value = s.ID,
                                         code = s.FieldValue,
                                         name = s.FieldName
                                     })
                                     .ToList();
        }
        public async Task<List<SelectItem>> GetCarBrandSelectListAsync(string LengCode)
        {
            return await Task.Run(() => GetCarBrandSelectList(LengCode));
        }
        public List<SelectItem>GetCarClassTypeSelectList(string LengCode)
        {
            return dbContext.CarClassTypes.AsNoTracking()
                                     .Where(x => x.LanguageCode == LengCode)
                                     .Select(s => new SelectItem()
                                     {
                                         value = s.ID,
                                         code = s.FieldValue,
                                         name = s.FieldName
                                     })
                                     .ToList();
        }
        public async Task<List<SelectItem>> GetCarClassTypeSelectListAsync(string LengCode)
        {
            return await Task.Run(() => GetCarClassTypeSelectList(LengCode));
        }
        public List<SelectItem>GetCareerGroupSelectList(string LengCode)
        {
            return dbContext.CareerGroups.AsNoTracking()
                                     .Where(x => x.LanguageCode == LengCode)
                                     .Select(s => new SelectItem()
                                     {
                                         value = s.ID,
                                         code = s.FieldValue,
                                         name = s.FieldName
                                     })
                                     .ToList();
        }
        public async Task<List<SelectItem>> GetCareerGroupSelectListAsync(string LengCode)
        {
            return await Task.Run(() => GetCareerGroupSelectList(LengCode));
        }
        public List<SelectItem>GetCarSegmentTypeSelectList(string LengCode)
        {
            return dbContext.CarSegmentTypes.AsNoTracking()
                                     .Where(x => x.LanguageCode == LengCode)
                                     .Select(s => new SelectItem()
                                     {
                                         value = s.ID,
                                         code = s.FieldValue,
                                         name = s.FieldName
                                     })
                                     .ToList();
        }
        public async Task<List<SelectItem>> GetCarSegmentTypeSelectListAsync(string LengCode)
        {
            return await Task.Run(() => GetCarSegmentTypeSelectList(LengCode));
        }
        public List<SelectItem>GetCategoriesSelectList(string LengCode)
        {
            return dbContext.Categoriess.AsNoTracking()
                                     .Where(x => x.LanguageCode == LengCode)
                                     .Select(s => new SelectItem()
                                     {
                                         value = s.ID,
                                         code = s.FieldValue,
                                         name = s.FieldName
                                     })
                                     .ToList();
        }
        public async Task<List<SelectItem>> GetCategoriesSelectListAsync(string LengCode)
        {
            return await Task.Run(() => GetCategoriesSelectList(LengCode));
        }
        public List<SelectItem>GetCitySelectList(string LengCode)
        {
            return dbContext.Cities.AsNoTracking()
                                     .Where(x => x.LanguageCode == LengCode)
                                     .Select(s => new SelectItem()
                                     {
                                         value = s.ID,
                                         code = s.FieldValue,
                                         name = s.FieldName
                                     })
                                     .ToList();
        }
        public async Task<List<SelectItem>> GetCitySelectListAsync(string LengCode)
        {
            return await Task.Run(() => GetCitySelectList(LengCode));
        }
        public List<SelectItem>GetContinentSelectList(string LengCode)
        {
            return dbContext.Continents.AsNoTracking()
                                     .Where(x => x.LanguageCode == LengCode)
                                     .Select(s => new SelectItem()
                                     {
                                         value = s.ID,
                                         code = s.FieldValue,
                                         name = s.FieldName
                                     })
                                     .ToList();
        }
        public async Task<List<SelectItem>> GetContinentSelectListAsync(string LengCode)
        {
            return await Task.Run(() => GetContinentSelectList(LengCode));
        }
        public List<SelectItem>GetCorporateTypeSelectList(string LengCode)
        {
            return dbContext.CorporateTypes.AsNoTracking()
                                     .Where(x => x.LanguageCode == LengCode)
                                     .Select(s => new SelectItem()
                                     {
                                         value = s.ID,
                                         code = s.FieldValue,
                                         name = s.FieldName
                                     })
                                     .ToList();
        }
        public async Task<List<SelectItem>> GetCorporateTypeSelectListAsync(string LengCode)
        {
            return await Task.Run(() => GetCorporateTypeSelectList(LengCode));
        }
        public List<SelectItem>GetCountrySelectList(string LengCode)
        {
            return dbContext.Countries.AsNoTracking()
                                     .Where(x => x.LanguageCode == LengCode)
                                     .Select(s => new SelectItem()
                                     {
                                         value = s.ID,
                                         code = s.FieldValue,
                                         name = s.FieldName
                                     })
                                     .ToList();
        }
        public async Task<List<SelectItem>> GetCountrySelectListAsync(string LengCode)
        {
            return await Task.Run(() => GetCountrySelectList(LengCode));
        }
        public List<SelectItem>GetCurrencySelectList(string LengCode)
        {
            return dbContext.Currencies.AsNoTracking()
                                     .Where(x => x.LanguageCode == LengCode)
                                     .Select(s => new SelectItem()
                                     {
                                         value = s.ID,
                                         code = s.FieldValue,
                                         name = s.FieldName
                                     })
                                     .ToList();
        }
        public async Task<List<SelectItem>> GetCurrencySelectListAsync(string LengCode)
        {
            return await Task.Run(() => GetCurrencySelectList(LengCode));
        }
        public List<SelectItem>GetCurrencyRateTypeSelectList(string LengCode)
        {
            return dbContext.CurrencyRateTypes.AsNoTracking()
                                     .Where(x => x.LanguageCode == LengCode)
                                     .Select(s => new SelectItem()
                                     {
                                         value = s.ID,
                                         code = s.FieldValue,
                                         name = s.FieldName
                                     })
                                     .ToList();
        }
        public async Task<List<SelectItem>> GetCurrencyRateTypeSelectListAsync(string LengCode)
        {
            return await Task.Run(() => GetCurrencyRateTypeSelectList(LengCode));
        }
        public List<SelectItem>GetCustomerTypeSelectList(string LengCode)
        {
            return dbContext.CustomerTypes.AsNoTracking()
                                     .Where(x => x.LanguageCode == LengCode)
                                     .Select(s => new SelectItem()
                                     {
                                         value = s.ID,
                                         code = s.FieldValue,
                                         name = s.FieldName
                                     })
                                     .ToList();
        }
        public async Task<List<SelectItem>> GetCustomerTypeSelectListAsync(string LengCode)
        {
            return await Task.Run(() => GetCustomerTypeSelectList(LengCode));
        }
        public List<SelectItem>GetDeclarationTypeSelectList(string LengCode)
        {
            return dbContext.DeclarationTypes.AsNoTracking()
                                     .Where(x => x.LanguageCode == LengCode)
                                     .Select(s => new SelectItem()
                                     {
                                         value = s.ID,
                                         code = s.FieldValue,
                                         name = s.FieldName
                                     })
                                     .ToList();
        }
        public async Task<List<SelectItem>> GetDeclarationTypeSelectListAsync(string LengCode)
        {
            return await Task.Run(() => GetDeclarationTypeSelectList(LengCode));
        }
        public List<SelectItem>GetDirectionSelectList(string LengCode)
        {
            return dbContext.Directions.AsNoTracking()
                                     .Where(x => x.LanguageCode == LengCode)
                                     .Select(s => new SelectItem()
                                     {
                                         value = s.ID,
                                         code = s.FieldValue,
                                         name = s.FieldName
                                     })
                                     .ToList();
        }
        public async Task<List<SelectItem>> GetDirectionSelectListAsync(string LengCode)
        {
            return await Task.Run(() => GetDirectionSelectList(LengCode));
        }
        public List<SelectItem>GetDistrictSelectList(string LengCode)
        {
            return dbContext.Districts.AsNoTracking()
                                     .Where(x => x.LanguageCode == LengCode)
                                     .Select(s => new SelectItem()
                                     {
                                         value = s.ID,
                                         code = s.FieldValue,
                                         name = s.FieldName
                                     })
                                     .ToList();
        }
        public async Task<List<SelectItem>> GetDistrictSelectListAsync(string LengCode)
        {
            return await Task.Run(() => GetDistrictSelectList(LengCode));
        }
        public List<SelectItem>GetExceptionCodeSelectList(string LengCode)
        {
            return dbContext.ExceptionCodes.AsNoTracking()
                                     .Where(x => x.LanguageCode == LengCode)
                                     .Select(s => new SelectItem()
                                     {
                                         value = s.ID,
                                         code = s.FieldValue,
                                         name = s.FieldName
                                     })
                                     .ToList();
        }
        public async Task<List<SelectItem>> GetExceptionCodeSelectListAsync(string LengCode)
        {
            return await Task.Run(() => GetExceptionCodeSelectList(LengCode));
        }
        public List<SelectItem>GetExceptionTypeSelectList(string LengCode)
        {
            return dbContext.ExceptionTypes.AsNoTracking()
                                     .Where(x => x.LanguageCode == LengCode)
                                     .Select(s => new SelectItem()
                                     {
                                         value = s.ID,
                                         code = s.FieldValue,
                                         name = s.FieldName
                                     })
                                     .ToList();
        }
        public async Task<List<SelectItem>> GetExceptionTypeSelectListAsync(string LengCode)
        {
            return await Task.Run(() => GetExceptionTypeSelectList(LengCode));
        }
        public List<SelectItem>GetFlightCabinTypeSelectList(string LengCode)
        {
            return dbContext.FlightCabinTypes.AsNoTracking()
                                     .Where(x => x.LanguageCode == LengCode)
                                     .Select(s => new SelectItem()
                                     {
                                         value = s.ID,
                                         code = s.FieldValue,
                                         name = s.FieldName
                                     })
                                     .ToList();
        }
        public async Task<List<SelectItem>> GetFlightCabinTypeSelectListAsync(string LengCode)
        {
            return await Task.Run(() => GetFlightCabinTypeSelectList(LengCode));
        }
        public List<SelectItem>GetFlightDistanceSelectList(string LengCode)
        {
            return dbContext.FlightDistances.AsNoTracking()
                                     .Where(x => x.LanguageCode == LengCode)
                                     .Select(s => new SelectItem()
                                     {
                                         value = s.ID,
                                         code = s.FieldValue,
                                         name = s.FieldName
                                     })
                                     .ToList();
        }
        public async Task<List<SelectItem>> GetFlightDistanceSelectListAsync(string LengCode)
        {
            return await Task.Run(() => GetFlightDistanceSelectList(LengCode));
        }
        public List<SelectItem>GetFlightFlexTypeSelectList(string LengCode)
        {
            return dbContext.FlightFlexTypes.AsNoTracking()
                                     .Where(x => x.LanguageCode == LengCode)
                                     .Select(s => new SelectItem()
                                     {
                                         value = s.ID,
                                         code = s.FieldValue,
                                         name = s.FieldName
                                     })
                                     .ToList();
        }
        public async Task<List<SelectItem>> GetFlightFlexTypeSelectListAsync(string LengCode)
        {
            return await Task.Run(() => GetFlightFlexTypeSelectList(LengCode));
        }
        public List<SelectItem>GetFlightFoodTypeSelectList(string LengCode)
        {
            return dbContext.FlightFoodTypes.AsNoTracking()
                                     .Where(x => x.LanguageCode == LengCode)
                                     .Select(s => new SelectItem()
                                     {
                                         value = s.ID,
                                         code = s.FieldValue,
                                         name = s.FieldName
                                     })
                                     .ToList();
        }
        public async Task<List<SelectItem>> GetFlightFoodTypeSelectListAsync(string LengCode)
        {
            return await Task.Run(() => GetFlightFoodTypeSelectList(LengCode));
        }
        public List<SelectItem>GetFlightLineDistanceSelectList(string LengCode)
        {
            return dbContext.FlightLineDistances.AsNoTracking()
                                     .Where(x => x.LanguageCode == LengCode)
                                     .Select(s => new SelectItem()
                                     {
                                         value = s.ID,
                                         code = s.FieldValue,
                                         name = s.FieldName
                                     })
                                     .ToList();
        }
        public async Task<List<SelectItem>> GetFlightLineDistanceSelectListAsync(string LengCode)
        {
            return await Task.Run(() => GetFlightLineDistanceSelectList(LengCode));
        }
        public List<SelectItem>GetFlightLineTypeSelectList(string LengCode)
        {
            return dbContext.FlightLineTypes.AsNoTracking()
                                     .Where(x => x.LanguageCode == LengCode)
                                     .Select(s => new SelectItem()
                                     {
                                         value = s.ID,
                                         code = s.FieldValue,
                                         name = s.FieldName
                                     })
                                     .ToList();
        }
        public async Task<List<SelectItem>> GetFlightLineTypeSelectListAsync(string LengCode)
        {
            return await Task.Run(() => GetFlightLineTypeSelectList(LengCode));
        }
        public List<SelectItem>GetFlightLineZoneSelectList(string LengCode)
        {
            return dbContext.FlightLineZones.AsNoTracking()
                                     .Where(x => x.LanguageCode == LengCode)
                                     .Select(s => new SelectItem()
                                     {
                                         value = s.ID,
                                         code = s.FieldValue,
                                         name = s.FieldName
                                     })
                                     .ToList();
        }
        public async Task<List<SelectItem>> GetFlightLineZoneSelectListAsync(string LengCode)
        {
            return await Task.Run(() => GetFlightLineZoneSelectList(LengCode));
        }
        public List<SelectItem>GetFlightSeatTypeSelectList(string LengCode)
        {
            return dbContext.FlightSeatTypes.AsNoTracking()
                                     .Where(x => x.LanguageCode == LengCode)
                                     .Select(s => new SelectItem()
                                     {
                                         value = s.ID,
                                         code = s.FieldValue,
                                         name = s.FieldName
                                     })
                                     .ToList();
        }
        public async Task<List<SelectItem>> GetFlightSeatTypeSelectListAsync(string LengCode)
        {
            return await Task.Run(() => GetFlightSeatTypeSelectList(LengCode));
        }
        public List<SelectItem>GetFlightStatusTypeSelectList(string LengCode)
        {
            return dbContext.FlightStatusTypes.AsNoTracking()
                                     .Where(x => x.LanguageCode == LengCode)
                                     .Select(s => new SelectItem()
                                     {
                                         value = s.ID,
                                         code = s.FieldValue,
                                         name = s.FieldName
                                     })
                                     .ToList();
        }
        public async Task<List<SelectItem>> GetFlightStatusTypeSelectListAsync(string LengCode)
        {
            return await Task.Run(() => GetFlightStatusTypeSelectList(LengCode));
        }
        public List<SelectItem>GetFlightSupplierTypeSelectList(string LengCode)
        {
            return dbContext.FlightSupplierTypes.AsNoTracking()
                                     .Where(x => x.LanguageCode == LengCode)
                                     .Select(s => new SelectItem()
                                     {
                                         value = s.ID,
                                         code = s.FieldValue,
                                         name = s.FieldName
                                     })
                                     .ToList();
        }
        public async Task<List<SelectItem>> GetFlightSupplierTypeSelectListAsync(string LengCode)
        {
            return await Task.Run(() => GetFlightSupplierTypeSelectList(LengCode));
        }
        public List<SelectItem>GetFuelTypeSelectList(string LengCode)
        {
            return dbContext.FuelTypes.AsNoTracking()
                                     .Where(x => x.LanguageCode == LengCode)
                                     .Select(s => new SelectItem()
                                     {
                                         value = s.ID,
                                         code = s.FieldValue,
                                         name = s.FieldName
                                     })
                                     .ToList();
        }
        public async Task<List<SelectItem>> GetFuelTypeSelectListAsync(string LengCode)
        {
            return await Task.Run(() => GetFuelTypeSelectList(LengCode));
        }
        //public List<SelectItem>GetGlobalDeclarationSelectList(string LengCode)
        //{
        //    return dbContext.GlobalDeclarations.AsNoTracking()
        //                             .Select(s => new SelectItem()
        //                             {
        //                                 value = s.ID,
        //                             })
        //                             .ToList();
        //}
        //public async Task<List<SelectItem>> GetGlobalDeclarationSelectListAsync(string LengCode)
        //{
        //    return await Task.Run(() => GetGlobalDeclarationSelectList(LengCode));
        //}
        //public List<SelectItem>GetGlobalModuleSelectList(string LengCode)
        //{
        //    return dbContext.GlobalModules.AsNoTracking()
        //                             .Select(s => new SelectItem()
        //                             {
        //                                 value = s.ID,
        //                                 code = s.,
        //                                 name = s.FieldName
        //                             })
        //                             .ToList();
        //}
        //public async Task<List<SelectItem>> GetGlobalModuleSelectListAsync(string LengCode)
        //{
        //    return await Task.Run(() => GetGlobalModuleSelectList(LengCode));
        //}
        public List<SelectItem>GetGlobalReportTypeSelectList(string LengCode)
        {
            return dbContext.GlobalReportTypes.AsNoTracking()
                                     .Where(x => x.LanguageCode == LengCode)
                                     .Select(s => new SelectItem()
                                     {
                                         value = s.ID,
                                         code = s.FieldValue,
                                         name = s.FieldName
                                     })
                                     .ToList();
        }
        public async Task<List<SelectItem>> GetGlobalReportTypeSelectListAsync(string LengCode)
        {
            return await Task.Run(() => GetGlobalReportTypeSelectList(LengCode));
        }
        public List<SelectItem>GetGlobalTranslationSelectList(string LengCode)
        {
            return dbContext.GlobalTranslations.AsNoTracking()
                                     .Where(x => x.LanguageCode == LengCode)
                                     .Select(s => new SelectItem()
                                     {
                                         value = s.ID,
                                         code = s.FieldValue,
                                         name = s.FieldName
                                     })
                                     .ToList();
        }
        public async Task<List<SelectItem>> GetGlobalTranslationSelectListAsync(string LengCode)
        {
            return await Task.Run(() => GetGlobalTranslationSelectList(LengCode));
        }
        public List<SelectItem>GetHotelBedTypeSelectList(string LengCode)
        {
            return dbContext.HotelBedTypes.AsNoTracking()
                                     .Where(x => x.LanguageCode == LengCode)
                                     .Select(s => new SelectItem()
                                     {
                                         value = s.ID,
                                         code = s.FieldValue,
                                         name = s.FieldName
                                     })
                                     .ToList();
        }
        public async Task<List<SelectItem>> GetHotelBedTypeSelectListAsync(string LengCode)
        {
            return await Task.Run(() => GetHotelBedTypeSelectList(LengCode));
        }
        public List<SelectItem>GetHotelClassTypeSelectList(string LengCode)
        {
            return dbContext.HotelClassTypes.AsNoTracking()
                                     .Where(x => x.LanguageCode == LengCode)
                                     .Select(s => new SelectItem()
                                     {
                                         value = s.ID,
                                         code = s.FieldValue,
                                         name = s.FieldName
                                     })
                                     .ToList();
        }
        public async Task<List<SelectItem>> GetHotelClassTypeSelectListAsync(string LengCode)
        {
            return await Task.Run(() => GetHotelClassTypeSelectList(LengCode));
        }
        public List<SelectItem>GetHotelHostelTypeSelectList(string LengCode)
        {
            return dbContext.HotelHostelTypes.AsNoTracking()
                                     .Where(x => x.LanguageCode == LengCode)
                                     .Select(s => new SelectItem()
                                     {
                                         value = s.ID,
                                         code = s.FieldValue,
                                         name = s.FieldName
                                     })
                                     .ToList();
        }
        public async Task<List<SelectItem>> GetHotelHostelTypeSelectListAsync(string LengCode)
        {
            return await Task.Run(() => GetHotelHostelTypeSelectList(LengCode));
        }
        public List<SelectItem>GetHotelTypeSelectList(string LengCode)
        {
            return dbContext.HotelTypes.AsNoTracking()
                                     .Where(x => x.LanguageCode == LengCode)
                                     .Select(s => new SelectItem()
                                     {
                                         value = s.ID,
                                         code = s.FieldValue,
                                         name = s.FieldName
                                     })
                                     .ToList();
        }
        public async Task<List<SelectItem>> GetHotelTypeSelectListAsync(string LengCode)
        {
            return await Task.Run(() => GetHotelTypeSelectList(LengCode));
        }
        public List<SelectItem>GetIntegratorSystemSelectList(string LengCode)
        {
            return dbContext.IntegratorSystems.AsNoTracking()
                                     .Where(x => x.LanguageCode == LengCode)
                                     .Select(s => new SelectItem()
                                     {
                                         value = s.ID,
                                         code = s.FieldValue,
                                         name = s.FieldName
                                     })
                                     .ToList();
        }
        public async Task<List<SelectItem>> GetIntegratorSystemSelectListAsync(string LengCode)
        {
            return await Task.Run(() => GetIntegratorSystemSelectList(LengCode));
        }
        public List<SelectItem>GetInvoiceOptionTypeSelectList(string LengCode)
        {
            return dbContext.InvoiceOptionTypes.AsNoTracking()
                                     .Where(x => x.LanguageCode == LengCode)
                                     .Select(s => new SelectItem()
                                     {
                                         value = s.ID,
                                         code = s.FieldValue,
                                         name = s.FieldName
                                     })
                                     .ToList();
        }
        public async Task<List<SelectItem>> GetInvoiceOptionTypeSelectListAsync(string LengCode)
        {
            return await Task.Run(() => GetInvoiceOptionTypeSelectList(LengCode));
        }
        public List<SelectItem>GetInvoiceTransactionTypeSelectList(string LengCode)
        {
            return dbContext.InvoiceTransactionTypes.AsNoTracking()
                                     .Where(x => x.LanguageCode == LengCode)
                                     .Select(s => new SelectItem()
                                     {
                                         value = s.ID,
                                         code = s.FieldValue,
                                         name = s.FieldName
                                     })
                                     .ToList();
        }
        public async Task<List<SelectItem>> GetInvoiceTransactionTypeSelectListAsync(string LengCode)
        {
            return await Task.Run(() => GetInvoiceTransactionTypeSelectList(LengCode));
        }
        public List<SelectItem>GetInvoiceTypeSelectList(string LengCode)
        {
            return dbContext.InvoiceTypes.AsNoTracking()
                                     .Where(x => x.LanguageCode == LengCode)
                                     .Select(s => new SelectItem()
                                     {
                                         value = s.ID,
                                         code = s.FieldValue,
                                         name = s.FieldName
                                     })
                                     .ToList();
        }
        public async Task<List<SelectItem>> GetInvoiceTypeSelectListAsync(string LengCode)
        {
            return await Task.Run(() => GetInvoiceTypeSelectList(LengCode));
        }
        public List<SelectItem>GetLanguageTypeSelectList(string LengCode)
        {
            return dbContext.LanguageTypes.AsNoTracking()
                                     .Select(s => new SelectItem()
                                     {
                                         value = s.ID,
                                         code = s.Code,
                                         name = s.CodeName
                                     })
                                     .ToList();
        }
        public async Task<List<SelectItem>> GetLanguageTypeSelectListAsync(string LengCode)
        {
            return await Task.Run(() => GetLanguageTypeSelectList(LengCode));
        }
        public List<SelectItem>GetModuleTypeSelectList(string LengCode)
        {
            return dbContext.ModuleTypes.AsNoTracking()
                                     .Where(x => x.LanguageCode == LengCode)
                                     .Select(s => new SelectItem()
                                     {
                                         value = s.ID,
                                         code = s.FieldValue,
                                         name = s.FieldName
                                     })
                                     .ToList();
        }
        public async Task<List<SelectItem>> GetModuleTypeSelectListAsync(string LengCode)
        {
            return await Task.Run(() => GetModuleTypeSelectList(LengCode));
        }
        public List<SelectItem>GetMonthTypeSelectList(string LengCode)
        {
            return dbContext.MonthTypes.AsNoTracking()
                                     .Where(x => x.LanguageCode == LengCode)
                                     .Select(s => new SelectItem()
                                     {
                                         value = s.ID,
                                         code = s.FieldValue,
                                         name = s.FieldName
                                     })
                                     .ToList();
        }
        public async Task<List<SelectItem>> GetMonthTypeSelectListAsync(string LengCode)
        {
            return await Task.Run(() => GetMonthTypeSelectList(LengCode));
        }
        public List<SelectItem>GetPassengerTypeSelectList(string LengCode)
        {
            return dbContext.PassengerTypes.AsNoTracking()
                                     .Where(x => x.LanguageCode == LengCode)
                                     .Select(s => new SelectItem()
                                     {
                                         value = s.ID,
                                         code = s.FieldValue,
                                         name = s.FieldName
                                     })
                                     .ToList();
        }
        public async Task<List<SelectItem>> GetPassengerTypeSelectListAsync(string LengCode)
        {
            return await Task.Run(() => GetPassengerTypeSelectList(LengCode));
        }
        public List<SelectItem>GetPassportTypeSelectList(string LengCode)
        {
            return dbContext.PassportTypes.AsNoTracking()
                                     .Where(x => x.LanguageCode == LengCode)
                                     .Select(s => new SelectItem()
                                     {
                                         value = s.ID,
                                         code = s.FieldValue,
                                         name = s.FieldName
                                     })
                                     .ToList();
        }
        public async Task<List<SelectItem>> GetPassportTypeSelectListAsync(string LengCode)
        {
            return await Task.Run(() => GetPassportTypeSelectList(LengCode));
        }
        public List<SelectItem>GetPayerTypeSelectList(string LengCode)
        {
            return dbContext.PayerTypes.AsNoTracking()
                                     .Where(x => x.LanguageCode == LengCode)
                                     .Select(s => new SelectItem()
                                     {
                                         value = s.ID,
                                         code = s.FieldValue,
                                         name = s.FieldName
                                     })
                                     .ToList();
        }
        public async Task<List<SelectItem>> GetPayerTypeSelectListAsync(string LengCode)
        {
            return await Task.Run(() => GetPayerTypeSelectList(LengCode));
        }
        public List<SelectItem>GetPaymentTermTypeSelectList(string LengCode)
        {
            return dbContext.PaymentTermTypes.AsNoTracking()
                                     .Where(x => x.LanguageCode == LengCode)
                                     .Select(s => new SelectItem()
                                     {
                                         value = s.ID,
                                         code = s.FieldValue,
                                         name = s.FieldName
                                     })
                                     .ToList();
        }
        public async Task<List<SelectItem>> GetPaymentTermTypeSelectListAsync(string LengCode)
        {
            return await Task.Run(() => GetPaymentTermTypeSelectList(LengCode));
        }
        public List<SelectItem>GetPaymentTypeSelectList(string LengCode)
        {
            return dbContext.PaymentTypes.AsNoTracking()
                                     .Where(x => x.LanguageCode == LengCode)
                                     .Select(s => new SelectItem()
                                     {
                                         value = s.ID,
                                         code = s.FieldValue,
                                         name = s.FieldName
                                     })
                                     .ToList();
        }
        public async Task<List<SelectItem>> GetPaymentTypeSelectListAsync(string LengCode)
        {
            return await Task.Run(() => GetPaymentTypeSelectList(LengCode));
        }
        public List<SelectItem>GetRegionTypeSelectList(string LengCode)
        {
            return dbContext.RegionTypes.AsNoTracking()
                                     .Where(x => x.LanguageCode == LengCode)
                                     .Select(s => new SelectItem()
                                     {
                                         value = s.ID,
                                         code = s.FieldValue,
                                         name = s.FieldName
                                     })
                                     .ToList();
        }
        public async Task<List<SelectItem>> GetRegionTypeSelectListAsync(string LengCode)
        {
            return await Task.Run(() => GetRegionTypeSelectList(LengCode));
        }
        public List<SelectItem>GetReportOptionTypeSelectList(string LengCode)
        {
            return dbContext.ReportOptionTypes.AsNoTracking()
                                     .Where(x => x.LanguageCode == LengCode)
                                     .Select(s => new SelectItem()
                                     {
                                         value = s.ID,
                                         code = s.FieldValue,
                                         name = s.FieldName
                                     })
                                     .ToList();
        }
        public async Task<List<SelectItem>> GetReportOptionTypeSelectListAsync(string LengCode)
        {
            return await Task.Run(() => GetReportOptionTypeSelectList(LengCode));
        }
        public List<SelectItem>GetRoleDateSelectList(string LengCode)
        {
            return dbContext.RoleDates.AsNoTracking()
                                     .Where(x => x.LanguageCode == LengCode)
                                     .Select(s => new SelectItem()
                                     {
                                         value = s.ID,
                                         code = s.FieldValue,
                                         name = s.FieldName
                                     })
                                     .ToList();
        }
        public async Task<List<SelectItem>> GetRoleDateSelectListAsync(string LengCode)
        {
            return await Task.Run(() => GetRoleDateSelectList(LengCode));
        }
        public List<SelectItem>GetSendInfoTypeSelectList(string LengCode)
        {
            return dbContext.SendInfoTypes.AsNoTracking()
                                     .Where(x => x.LanguageCode == LengCode)
                                     .Select(s => new SelectItem()
                                     {
                                         value = s.ID,
                                         code = s.FieldValue,
                                         name = s.FieldName
                                     })
                                     .ToList();
        }
        public async Task<List<SelectItem>> GetSendInfoTypeSelectListAsync(string LengCode)
        {
            return await Task.Run(() => GetSendInfoTypeSelectList(LengCode));
        }
        public List<SelectItem>GetShipCabinTypeSelectList(string LengCode)
        {
            return dbContext.ShipCabinTypes.AsNoTracking()
                                     .Where(x => x.LanguageCode == LengCode)
                                     .Select(s => new SelectItem()
                                     {
                                         value = s.ID,
                                         code = s.FieldValue,
                                         name = s.FieldName
                                     })
                                     .ToList();
        }
        public async Task<List<SelectItem>> GetShipCabinTypeSelectListAsync(string LengCode)
        {
            return await Task.Run(() => GetShipCabinTypeSelectList(LengCode));
        }
        public List<SelectItem>GetSourceTypeSelectList(string LengCode)
        {
            return dbContext.SourceTypes.AsNoTracking()
                                     .Where(x => x.LanguageCode == LengCode)
                                     .Select(s => new SelectItem()
                                     {
                                         value = s.ID,
                                         code = s.FieldValue,
                                         name = s.FieldName
                                     })
                                     .ToList();
        }
        public async Task<List<SelectItem>> GetSourceTypeSelectListAsync(string LengCode)
        {
            return await Task.Run(() => GetSourceTypeSelectList(LengCode));
        }
        public List<SelectItem>GetSpecialCodeTypeSelectList(string LengCode)
        {
            return dbContext.SpecialCodeTypes.AsNoTracking()
                                     .Where(x => x.LanguageCode == LengCode)
                                     .Select(s => new SelectItem()
                                     {
                                         value = s.ID,
                                         code = s.FieldValue,
                                         name = s.FieldName
                                     })
                                     .ToList();
        }
        public async Task<List<SelectItem>> GetSpecialCodeTypeSelectListAsync(string LengCode)
        {
            return await Task.Run(() => GetSpecialCodeTypeSelectList(LengCode));
        }
        public List<SelectItem>GetTitleTypeSelectList(string LengCode)
        {
            return dbContext.TitleTypes.AsNoTracking()
                                     .Where(x => x.LanguageCode == LengCode)
                                     .Select(s => new SelectItem()
                                     {
                                         value = s.ID,
                                         code = s.FieldValue,
                                         name = s.FieldName
                                     })
                                     .ToList();
        }
        public async Task<List<SelectItem>> GetTitleTypeSelectListAsync(string LengCode)
        {
            return await Task.Run(() => GetTitleTypeSelectList(LengCode));
        }
        public List<SelectItem>GetTransactionGroupSelectList(string LengCode)
        {
            return dbContext.TransactionGroups.AsNoTracking()
                                     .Where(x => x.LanguageCode == LengCode)
                                     .Select(s => new SelectItem()
                                     {
                                         value = s.ID,
                                         code = s.FieldValue,
                                         name = s.FieldName
                                     })
                                     .ToList();
         }
        public async Task<List<SelectItem>> GetTransactionGroupSelectListAsync(string LengCode)
        {
            return await Task.Run(() => GetTransactionGroupSelectList(LengCode));
        }
        public List<SelectItem>GetUnitCodeTypeSelectList(string LengCode)
        {
            return dbContext.UnitCodeTypes.AsNoTracking()
                                     .Where(x => x.LanguageCode == LengCode)
                                     .Select(s => new SelectItem()
                                     {
                                         value = s.ID,
                                         code = s.FieldValue,
                                         name = s.FieldName
                                     })
                                     .ToList();
        }
        public async Task<List<SelectItem>> GetUnitCodeTypeSelectListAsync(string LengCode)
        {
            return await Task.Run(() => GetUnitCodeTypeSelectList(LengCode));
        }
        public List<SelectItem>GetVisaTypeSelectList(string LengCode)
        {
            return dbContext.VisaTypes.AsNoTracking()
                                     .Where(x => x.LanguageCode == LengCode)
                                     .Select(s => new SelectItem()
                                     {
                                         value = s.ID,
                                         code = s.FieldValue,
                                         name = s.FieldName
                                     })
                                     .ToList();
        }
        public async Task<List<SelectItem>> GetVisaTypeSelectListAsync(string LengCode)
        {
            return await Task.Run(() => GetVisaTypeSelectList(LengCode));
        }
        public List<SelectItem>GetWorkerTypeSelectList(string LengCode)
        {
            return dbContext.WorkerTypes.AsNoTracking()
                                     .Where(x => x.LanguageCode == LengCode)
                                     .Select(s => new SelectItem()
                                     {
                                         value = s.ID,
                                         code = s.FieldValue,
                                         name = s.FieldName
                                     })
                                     .ToList();
        }
        public async Task<List<SelectItem>> GetWorkerTypeSelectListAsync(string LengCode)
        {
            return await Task.Run(() => GetWorkerTypeSelectList(LengCode));
        }
    }
}

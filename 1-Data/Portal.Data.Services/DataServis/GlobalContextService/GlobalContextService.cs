using AutoMapper;
using Portal.Data.Services.Base;
using Portal.Data.Context;
using Portal.Helpers;
using Portal.Model;

namespace Portal.Data.Services.GlobalContextService
{
    public interface IGlobalContextService : IBaseGlobalService
    {
        string GetSystemMessageValue(int MessageID);
        string GetSystemMessageValue(string MessageName);

        List<SelectItem> GetModuleSelectList();
        Task<List<SelectItem>> GetModuleSelectListAsync();
        List<SelectItem> GetAirlineSelectList();
        Task<List<SelectItem>> GetAirlineSelectListAsync();
        List<SelectItem> GetAirportSelectList();
        Task<List<SelectItem>> GetAirportSelectListAsync();
        List<SelectItem> GetProcessLocationSelectList();
        Task<List<SelectItem>> GetProcessLocationSelectListAsync();
        List<SelectItem> GetFlightDirectionSelectList();
        Task<List<SelectItem>> GetFlightDirectionSelectListAsync();
        List<SelectItem> GetFlightTicketStatusSelectList();
        Task<List<SelectItem>> GetFlightTicketStatusSelectListAsync();
        List<SelectItem> GetFlightCabinTypeSelectList();
        Task<List<SelectItem>> GetFlightCabinTypeSelectListAsync();
        List<SelectItem> GetFlightLineZoneSelectList();
        Task<List<SelectItem>> GetFlightLineZoneSelectListAsync();
        List<SelectItem> GetFlightLineDistanceSelectList();
        Task<List<SelectItem>> GetFlightLineDistanceSelectListAsync();
        List<SelectItem> GetFlightTicketTypeSelectList();
        Task<List<SelectItem>> GetFlightTicketTypeSelectListAsync();

        List<SelectItem> GetBedTypeSelectList();
        Task<List<SelectItem>> GetBedTypeSelectListAsync();
        List<SelectItem> GetRoomTypeSelectList();
        Task<List<SelectItem>> GetRoomTypeSelectListAsync();
        List<SelectItem> GetHostelTypeSelectList();
        Task<List<SelectItem>> GetHostelTypeSelectListAsync();
        List<SelectItem> GetReservationStatusSelectList();
        Task<List<SelectItem>> GetReservationStatusSelectListAsync();
        List<SelectItem> GetPaymentTypeSelectList();
        Task<List<SelectItem>> GetPaymentTypeSelectListAsync();
        List<SelectItem> GetPayerTypeSelectList();
        Task<List<SelectItem>> GetPayerTypeSelectListAsync();
        List<SelectItem> GetLocationSelectList(int TypeID);
        Task<List<SelectItem>> GetLocationSelectListAsync(int TypeID);


        List<SelectItem> GetInvoiceGroupSelectList();
        Task<List<SelectItem>> GetInvoiceGroupSelectListAsync();
        List<SelectItem> GetInvoiceTypeSelectList();
        Task<List<SelectItem>> GetInvoiceTypeSelectListAsync();


    }
    public class GlobalContextService : BaseGlobalService, IGlobalContextService
    {
        public GlobalContextService()
        {
        }

        public string GetSystemMessageValue(int MessageID)
        {
            return dbContext.SystemMessagesTranslations
                            .Where(x => x.ParentID == MessageID && x.LanguageCode == Login.GetLoginUser().workingLang)
                            .Select(x => x.FieldValue)
                            .FirstOrDefault() ?? "";
        }

        public string GetSystemMessageValue(string MessageName)
        {
            var msg = dbContext.SystemMessages.FirstOrDefault(x => x.MessageName == MessageName);
            if (msg == null)
                return string.Empty;

            return dbContext.SystemMessagesTranslations
                              .Where(x => x.ParentID == msg.ID && x.LanguageCode == Login.GetLoginUser().workingLang)
                              .Select(x => x.FieldValue)
                              .FirstOrDefault() ?? "";
        }

        public List<SelectItem> GetAirlineSelectList()
        {
            return dbContext.Airlines
                            .Select(s => new SelectItem()
                            {
                                value = s.ID,
                                code = s.FieldValue,
                                name = s.FieldName
                            }).ToList();
        }
        public async Task<List<SelectItem>> GetAirlineSelectListAsync()
        {
            return await Task.Run(GetAirlineSelectList);
        }
        public List<SelectItem> GetAirportSelectList()
        {
            return  dbContext.AirPorts
                            .Select(s => new SelectItem()
                            {
                                value = s.ID,
                                code = s.FieldValue,
                                name = s.FieldName
                            }).ToList();
        }
        public async Task<List<SelectItem>> GetAirportSelectListAsync()
        {
            return await Task.Run(GetAirportSelectList);
        }

        public List<SelectItem> GetProcessLocationSelectList()
        {
            return new List<SelectItem>() { new() { value = 1, name = Login.GetLoginUser().workingLang=="tr-TR"?"Yurt içi":"Domestic" },
                                            new() {value=2,name=Login.GetLoginUser().workingLang=="tr-TR"?"Yurt dışı":"International" }};
        }
        public async Task<List<SelectItem>> GetProcessLocationSelectListAsync()
        {
            return await Task.Run(GetProcessLocationSelectList);
        }

        public List<SelectItem> GetFlightDirectionSelectList()
        {
            return dbContext.FlightDirections
                            .Where(x => x.LanguageCode == Login.GetLoginUser().workingLang)
                            .Select(s => new SelectItem()
                            {
                                value = s.GroupValue,
                                code = s.FieldValue,
                                name = s.FieldName
                            }).ToList();
        }
        public async Task<List<SelectItem>> GetFlightDirectionSelectListAsync()
        {
            return await Task.Run(GetFlightDirectionSelectList);
        }

        public List<SelectItem> GetFlightTicketStatusSelectList()
        {
            return dbContext.TicketStatusType
                            .Where(x => x.LanguageCode == Login.GetLoginUser().workingLang)
                            .Select(s => new SelectItem()
                            {
                                value = s.ID,
                                code = s.FieldValue,
                                name = s.FieldName
                            }).ToList();
        }
        public async Task<List<SelectItem>> GetFlightTicketStatusSelectListAsync()
        {
            return await Task.Run(GetFlightTicketStatusSelectList);
        }
        public List<SelectItem> GetFlightCabinTypeSelectList()
        {
            return dbContext.FlightCabinTypes
                            .Where(x => x.LanguageCode == Login.GetLoginUser().workingLang)
                            .Select(s => new SelectItem()
                            {
                                value = s.ID,
                                code = s.FieldValue,
                                name = s.FieldName
                            }).ToList();
        }
        public async Task<List<SelectItem>> GetFlightCabinTypeSelectListAsync()
        {
            return await Task.Run(GetFlightCabinTypeSelectList);
        }
        public List<SelectItem> GetFlightLineZoneSelectList()
        {
            return dbContext.FlightLineZones
                            .Where(x => x.LanguageCode == Login.GetLoginUser().workingLang)
                            .Select(s => new SelectItem()
                            {
                                value = s.ID,
                                code = s.FieldValue,
                                name = s.FieldName
                            }).ToList();
        }
        public async Task<List<SelectItem>> GetFlightLineZoneSelectListAsync()
        {
            return await Task.Run(GetFlightLineZoneSelectList);
        }
        public List<SelectItem> GetFlightLineDistanceSelectList()
        {
            return dbContext.FlightLineDistances
                            .Where(x => x.LanguageCode == Login.GetLoginUser().workingLang)
                            .Select(s => new SelectItem()
                            {
                                value = s.ID,
                                code = s.FieldValue,
                                name = s.FieldName
                            }).ToList();
        }
        public async Task<List<SelectItem>> GetFlightLineDistanceSelectListAsync()
        {
            return await Task.Run(GetFlightLineDistanceSelectList);
        }
        public List<SelectItem> GetFlightTicketTypeSelectList()
        {
            return dbContext.TicketTypes
                            .Where(x => x.LanguageCode == Login.GetLoginUser().workingLang)
                            .Select(s => new SelectItem()
                            {
                                value = s.ID,
                                code = s.FieldValue,
                                name = s.FieldName
                            }).ToList();
        }
        public async Task<List<SelectItem>> GetFlightTicketTypeSelectListAsync()
        {
            return await Task.Run(GetFlightTicketTypeSelectList);
        }
        public List<SelectItem> GetModuleSelectList()
        {
            return dbContext.Modules
                            .Select(s => new SelectItem()
                            {
                                value = s.ID,
                                code = s.ReportValue,
                                name = s.FieldName
                            }).ToList();
        }
        public async Task<List<SelectItem>> GetModuleSelectListAsync()
        {
            return await Task.Run(GetModuleSelectList);
        }


        public List<SelectItem> GetBedTypeSelectList()
        {
            return dbContext.BedTypeSelectViews
                            .Select(s => new SelectItem()
                            {
                                value = s.ID,
                                code = s.Code,
                                name = s.Name
                            }).ToList();
        }
        public async Task<List<SelectItem>> GetBedTypeSelectListAsync()
        {
            return await Task.Run(GetBedTypeSelectList);
        }
        public List<SelectItem> GetRoomTypeSelectList()
        {
            return dbContext.RoomTypeSelectViews
                            .Select(s => new SelectItem()
                            {
                                value = s.ID,
                                code = s.Code,
                                name = s.Name
                            }).ToList();
        }
        public async Task<List<SelectItem>> GetRoomTypeSelectListAsync()
        {
            return await Task.Run(GetRoomTypeSelectList);
        }
        public List<SelectItem> GetHostelTypeSelectList()
        {
            return dbContext.HostelTypeSelectViews
                            .Select(s => new SelectItem()
                            {
                                value = s.ID,
                                code = s.Code,
                                name = s.Name
                            }).ToList();
        }
        public async Task<List<SelectItem>> GetHostelTypeSelectListAsync()
        {
            return await Task.Run(GetHostelTypeSelectList);
        }
        public List<SelectItem> GetReservationStatusSelectList()
        {
            return dbContext.ReservationStatusSelectViews
                                                .Select(s => new SelectItem()
                                                {
                                                    value = s.ID,
                                                    code = s.Code,
                                                    name = s.Name
                                                }).ToList(); ;
        }
        public async Task<List<SelectItem>> GetReservationStatusSelectListAsync()
        {
            return await Task.Run(GetReservationStatusSelectList);
        }

        public List<SelectItem> GetPaymentTypeSelectList()
        {
            return dbContext.PaymentTypes
                            .Select(s => new SelectItem()
                            {
                                value = s.ID,
                                code = s.FieldValue,
                                name = s.FieldName
                            }).ToList();
        }
        public async Task<List<SelectItem>> GetPaymentTypeSelectListAsync()
        {
            return await Task.Run(GetPaymentTypeSelectList);
        }
        public List<SelectItem> GetPayerTypeSelectList()
        {
            return dbContext.Payers
                            .Select(s => new SelectItem()
                            {
                                value = s.ID,
                                code = s.FieldValue,
                                name = s.FieldName
                            }).ToList();
        }
        public async Task<List<SelectItem>> GetPayerTypeSelectListAsync()
        {
            return await Task.Run(GetPayerTypeSelectList);
        }

        public List<SelectItem> GetLocationSelectList(int TypeID)
        {
            return dbContext.LocationSelectListViews
                                                .Where(x=> x.TypeID == TypeID)
                                                .Select(s => new SelectItem()
                                                {
                                                    value = s.ID,
                                                    name = s.Name,
                                                    text=s.FullName
                                                }).ToList();
        }
        public async Task<List<SelectItem>> GetLocationSelectListAsync(int TypeID)
        {
            return await Task.Run(() => GetLocationSelectList(TypeID));
        }
        public List<SelectItem> GetInvoiceGroupSelectList()
        {
            return dbContext.InvoiceGroupSelectViews
                                                .Select(s => new SelectItem()
                                                {
                                                    value = s.ID,
                                                    name = s.Code
                                                }).ToList();
        }
        public async Task<List<SelectItem>> GetInvoiceGroupSelectListAsync()
        {
            return await Task.Run(GetInvoiceGroupSelectList);
        }
        public List<SelectItem> GetInvoiceTypeSelectList()
        {
            return dbContext.InvoiceTypeSelectView
                                                .Select(s => new SelectItem()
                                                {
                                                    value = s.ID,
                                                    code = s.Code,
                                                    name = s.Name
                                                }).ToList();
        }
        public async Task<List<SelectItem>> GetInvoiceTypeSelectListAsync()
        {
            return await Task.Run(GetInvoiceTypeSelectList);
        }
    }
}

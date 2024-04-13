using AutoMapper;
using Portal.Data.Services.Base;
using Portal.Data.Context;
using Portal.Helpers;
using Portal.Model;

namespace Portal.Data.Services.GlobalContextService
{
    public interface IGlobalContextService : IBaseGlobalService
    {
        List<NavigationM> GetAdminNavigationTree();
        Task<List<NavigationM>> GetAdminNavigationTreeAsync();
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

        public List<NavigationM> GetAdminNavigationTree()
        {
            var defaultMenulist = (from menu in dbContext.Navigations
                                   join translation in dbContext.NavigationTranslations on menu.ID equals translation.ParentID
                                   where translation.LanguageCode.Equals(LoginResponse.GetLoginResponse().workingLang) && menu.MenuActive
                                   select new NavigationM()
                                   {
                                       id = menu.ID,
                                       modulID = menu.ModulID,
                                       parentID = menu.ParentID,
                                       menuLevel = menu.MenuLevel,
                                       menuOrder = menu.MenuOrder,
                                       formType = menu.MenuFormType,
                                       menuIcon = menu.MenuIcon,
                                       menuLink = menu.MenuLink,
                                       menuTag = menu.MenuTag,
                                       menuCardType = menu.MenuCardType ?? 0,
                                       isInternational = menu.IsInternational,
                                       menuName = translation.MenuName ?? "",
                                       formCaption = translation.FormCaption ?? "",
                                       editFormCaption = translation.EditFormCaption ?? "",
                                       menuPath = menu.MenuPath ?? "",
                                       allowList = false,
                                       allowDelete = false,
                                       allowEdit = false,
                                       allowNew = false,
                                       allowPrint = false,
                                       reportIDs = ""
                                   }).ToList();

            List<NavigationM> MenuLevel0 = new List<NavigationM>();
            List<NavigationM> MenuLevel1 = new List<NavigationM>();

            foreach (var item in defaultMenulist.Where(x => x.menuLevel == 2).ToList())
            {
                var mlv1 = MenuLevel1.FirstOrDefault(x => x.id == item.parentID);
                mlv1 ??= defaultMenulist.FirstOrDefault(x => x.id == item.parentID);
                mlv1.items.Add(item);
            }
            foreach (var item in MenuLevel1)
            {
                var mlv0 = MenuLevel0.FirstOrDefault(x => x.id == item.parentID);
                mlv0 ??= defaultMenulist.FirstOrDefault(x => x.id == item.parentID);
                mlv0.items.Add(item);
            }
            return MenuLevel0;
        }
        public async Task<List<NavigationM>> GetAdminNavigationTreeAsync()
        {
            return await Task.Run(GetAdminNavigationTree);
        }

        public string GetSystemMessageValue(int MessageID)
        {
            return dbContext.SystemMessagesTranslations
                            .Where(x => x.ParentID == MessageID && x.LanguageCode == LoginResponse.GetLoginResponse().workingLang)
                            .Select(x => x.FieldValue)
                            .FirstOrDefault() ?? "";
        }

        public string GetSystemMessageValue(string MessageName)
        {
            var msg = dbContext.SystemMessages.FirstOrDefault(x => x.MessageName == MessageName);
            if (msg == null)
                return string.Empty;

            return dbContext.SystemMessagesTranslations
                              .Where(x => x.ParentID == msg.ID && x.LanguageCode == LoginResponse.GetLoginResponse().workingLang)
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
            return new List<SelectItem>() { new() { value = 1, name = LoginResponse.GetLoginResponse().workingLang=="tr-TR"?"Yurt içi":"Domestic" },
                                            new() {value=2,name=LoginResponse.GetLoginResponse().workingLang=="tr-TR"?"Yurt dışı":"International" }};
        }
        public async Task<List<SelectItem>> GetProcessLocationSelectListAsync()
        {
            return await Task.Run(GetProcessLocationSelectList);
        }

        public List<SelectItem> GetFlightDirectionSelectList()
        {
            return dbContext.FlightDirections
                            .Where(x => x.LanguageCode == LoginResponse.GetLoginResponse().workingLang)
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
                            .Where(x => x.LanguageCode == LoginResponse.GetLoginResponse().workingLang)
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
                            .Where(x => x.LanguageCode == LoginResponse.GetLoginResponse().workingLang)
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
                            .Where(x => x.LanguageCode == LoginResponse.GetLoginResponse().workingLang)
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
                            .Where(x => x.LanguageCode == LoginResponse.GetLoginResponse().workingLang)
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
                            .Where(x => x.LanguageCode == LoginResponse.GetLoginResponse().workingLang)
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

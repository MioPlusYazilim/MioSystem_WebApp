using AutoMapper;
using Portal.Api.Data.Context;
using Portal.Api.DataServis.Base;
using Portal.Model;
using Portal.Model.Utils;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portal.Api.DataServis.GlobalContextService
{
    public interface IGlobalContextService : IBaseGlobalService
    {
        Task<List<NavigationM>> GetAdminNavigationTree();
        string GetSystemMessageValue(int MessageID);
        string GetSystemMessageValue(string MessageName);

        Task<List<SelectItem>> GetModuleSelectList();
        Task<List<SelectItem>> GetAirlineSelectList();
        Task<List<SelectItem>> GetAirportSelectList();
        Task<List<SelectItem>> GetProcessLocationSelectList();
        Task<List<SelectItem>> GetFlightDirectionSelectList();
        Task<List<SelectItem>> GetFlightTicketStatusSelectList();
        Task<List<SelectItem>> GetFlightCabinTypeSelectList();
        Task<List<SelectItem>> GetFlightLineZoneSelectList();
        Task<List<SelectItem>> GetFlightLineDistanceSelectList();
        Task<List<SelectItem>> GetFlightTicketTypeSelectList();

        Task<List<SelectItem>> GetBedTypeSelectList();
        Task<List<SelectItem>> GetRoomTypeSelectList();
        Task<List<SelectItem>> GetHostelTypeSelectList();
        Task<List<SelectItem>> GetReservationStatusSelectList();
        Task<List<SelectItem>> GetPaymentTypeSelectList();
        Task<List<SelectItem>> GetPayerTypeSelectList();
        Task<List<SelectItem>> GetLocationSelectList(int TypeID);


        Task<List<SelectItem>> GetInvoiceGroupSelectList();
        Task<List<SelectItem>> GetInvoiceTypeSelectList();


    }
    public class GlobalContextService : BaseGlobalService, IGlobalContextService
    {
        public GlobalContextService(GlobalDataContext _context, IMapper _Imapper, ISessionService _sessionServis) : base(_context, _Imapper, _sessionServis)
        {
        }

        
        public async Task<List<NavigationM>> GetAdminNavigationTree()
        {
            return await Task.Run(() =>
            {
                var defaultMenulist = (from menu in dbContext.Navigations
                                       join translation in dbContext.NavigationTranslations on menu.ID equals translation.ParentID
                                       where translation.LanguageCode.Equals(session.Language) && menu.MenuActive
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
            });
        }

        public string GetSystemMessageValue(int MessageID)
        {
            return dbContext.SystemMessagesTranslations
                            .Where(x => x.ParentID == MessageID && x.LanguageCode == session.Language)
                            .Select(x => x.FieldValue)
                            .FirstOrDefault();
        }

        public string GetSystemMessageValue(string MessageName)
        {
            var msg = dbContext.SystemMessages.FirstOrDefault(x => x.MessageName == MessageName);
            if (msg == null)
                return string.Empty;

            return dbContext.SystemMessagesTranslations
                              .Where(x => x.ParentID == msg.ID && x.LanguageCode == session.Language)
                              .Select(x => x.FieldValue)
                              .FirstOrDefault();
        }

        public async Task<List<SelectItem>> GetAirlineSelectList()
        {
            return await Task.Run(() => dbContext
                                        .Airlines
                                        .Select(s => new SelectItem()
                                        {
                                            value = s.ID,
                                            code=s.FieldValue,
                                            name = s.FieldName
                                        }).ToList());
        }

        public async Task<List<SelectItem>> GetAirportSelectList()
        {
            return await Task.Run(() => dbContext
                                        .AirPorts
                                        .Select(s => new SelectItem()
                                        {
                                            value = s.ID,
                                            code = s.FieldValue,
                                            name = s.FieldName
                                        }).ToList());
        }

        public async Task<List<SelectItem>> GetProcessLocationSelectList()
        {
            return await Task.Run(() => new List<SelectItem>() { new SelectItem() { value = 1, name = session.Language=="tr-TR"?"Yurt içi":"Domestic" },
                                                                  new SelectItem() {value=2,name=session.Language=="tr-TR"?"Yurt dışı":"International" }});
        }

        public async Task<List<SelectItem>> GetFlightDirectionSelectList()
        {
            return await Task.Run(() => dbContext.FlightDirections
                                               .Where(x => x.LanguageCode == session.Language)
                                               .Select(s => new SelectItem()
                                               {
                                                   value = s.GroupValue,
                                                   code = s.FieldValue,
                                                   name = s.FieldName
                                               }).ToList());
        }

        public async Task<List<SelectItem>> GetFlightTicketStatusSelectList()
        {
            return await Task.Run(() => dbContext.TicketStatusType
                                                .Where(x => x.LanguageCode == session.Language)
                                                .Select(s => new SelectItem()
                                                {
                                                    value = s.ID,
                                                    code = s.FieldValue,
                                                    name = s.FieldName
                                                }).ToList());
        }
        public async Task<List<SelectItem>> GetFlightCabinTypeSelectList()
        {
            return await Task.Run(() => dbContext.FlightCabinTypes
                                                .Where(x => x.LanguageCode == session.Language)
                                                .Select(s => new SelectItem()
                                                {
                                                    value = s.ID,
                                                    code = s.FieldValue,
                                                    name = s.FieldName
                                                }).ToList());
        }
        public async Task<List<SelectItem>> GetFlightLineZoneSelectList()
        {
            return await Task.Run(() => dbContext.FlightLineZones
                                                .Where(x => x.LanguageCode == session.Language)
                                                .Select(s => new SelectItem()
                                                {
                                                    value = s.ID,
                                                    code = s.FieldValue,
                                                    name = s.FieldName
                                                }).ToList());
        }
        public async Task<List<SelectItem>> GetFlightLineDistanceSelectList()
        {
            return await Task.Run(() => dbContext.FlightLineDistances
                                                .Where(x => x.LanguageCode == session.Language)
                                                .Select(s => new SelectItem()
                                                {
                                                    value = s.ID,
                                                    code = s.FieldValue,
                                                    name = s.FieldName
                                                }).ToList());
        }
        public async Task<List<SelectItem>> GetFlightTicketTypeSelectList()
        {
            return await Task.Run(() => dbContext.TicketTypes
                                                .Where(x => x.LanguageCode == session.Language)
                                                .Select(s => new SelectItem()
                                                {
                                                    value = s.ID,
                                                    code = s.FieldValue,
                                                    name = s.FieldName
                                                }).ToList());
        }
        public async Task<List<SelectItem>> GetModuleSelectList()
        {
            return await Task.Run(() => dbContext
                                        .Modules
                                        .Select(s => new SelectItem()
                                        {
                                            value = s.ID,
                                            code = s.ReportValue,
                                            name = s.FieldName
                                        }).ToList());
        }

        public async Task<List<SelectItem>> GetBedTypeSelectList()
        {
            return await Task.Run(() => dbContext
                                        .BedTypeSelectViews
                                        .Select(s => new SelectItem()
                                        {
                                            value = s.ID,
                                            code = s.Code,
                                            name = s.Name
                                        }).ToList());
        }
        public async Task<List<SelectItem>> GetRoomTypeSelectList()
        {
            return await Task.Run(() => dbContext
                                        .RoomTypeSelectViews
                                        .Select(s => new SelectItem()
                                        {
                                            value = s.ID,
                                            code = s.Code,
                                            name = s.Name
                                        }).ToList());
        }
        public async Task<List<SelectItem>> GetHostelTypeSelectList()
        {
            return await Task.Run(() => dbContext
                                        .HostelTypeSelectViews
                                        .Select(s => new SelectItem()
                                        {
                                            value = s.ID,
                                            code = s.Code,
                                            name = s.Name
                                        }).ToList());
        }

        public async Task<List<SelectItem>> GetReservationStatusSelectList()
        {
            return await Task.Run(() => dbContext.ReservationStatusSelectViews
                                                .Select(s => new SelectItem()
                                                {
                                                    value = s.ID,
                                                    code = s.Code,
                                                    name = s.Name
                                                }).ToList());
        }

        public async Task<List<SelectItem>> GetPaymentTypeSelectList()
        {
            return await Task.Run(() => dbContext.PaymentTypes
                                                .Select(s => new SelectItem()
                                                {
                                                    value = s.ID,
                                                    code = s.FieldValue,
                                                    name = s.FieldName
                                                }).ToList());
        }
        public async Task<List<SelectItem>> GetPayerTypeSelectList()
        {
            return await Task.Run(() => dbContext.Payers
                                                .Select(s => new SelectItem()
                                                {
                                                    value = s.ID,
                                                    code = s.FieldValue,
                                                    name = s.FieldName
                                                }).ToList());
        }

        public async Task<List<SelectItem>> GetLocationSelectList(int TypeID)
        {
            return await Task.Run(() => dbContext.LocationSelectListViews
                                                .Where(x=> x.TypeID == TypeID)
                                                .Select(s => new SelectItem()
                                                {
                                                    value = s.ID,
                                                    name = s.Name,
                                                    text=s.FullName
                                                }).ToList());
        }

        public async Task<List<SelectItem>> GetInvoiceGroupSelectList()
        {
            return await Task.Run(() => dbContext.InvoiceGroupSelectViews
                                                .Select(s => new SelectItem()
                                                {
                                                    value = s.ID,
                                                    name = s.Code
                                                }).ToList());
        }
        public async Task<List<SelectItem>> GetInvoiceTypeSelectList()
        {
            return await Task.Run(() => dbContext.InvoiceTypeSelectView
                                                .Select(s => new SelectItem()
                                                {
                                                    value = s.ID,
                                                    code = s.Code,
                                                    name = s.Name
                                                }).ToList());
        }
    }
}

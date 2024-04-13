using System;

namespace Portal.Data.Entities.ClientEntities
{
    public class TicketReportRequest
    {
        public TicketReportRequest()
        {
            reportGlobalParameters = new ReportGlobalParameters();
            reportCustomerParameters = new ReportCustomerParameters();
        }

        public ReportGlobalParameters reportGlobalParameters { get; set; }
        public ReportCustomerParameters reportCustomerParameters { get; set; }
        public string flightCabinTypeIDs { get; set; } = string.Empty;
        public string airlineCodes { get; set; } = string.Empty; // seçilen değerler ';' ile ayrılmalı "'TK;PC;8M'"
        public string flightDistanceIDs { get; set; }= string.Empty;
        public string flightZoneIDs { get; set; }=string.Empty;
        public string flightTicketFeatureIDs { get; set; } = string.Empty;
        public string flightDirectionIDs { get; set; } = string.Empty;// seçilen değerler ';' ile ayrılmalı "1;2;23;56;....."
        public string fligthTicketStatuses { get; set; } = string.Empty; // seçilen değerler ';' ile ayrılmalı "1;2;23;56;....."
    }
}

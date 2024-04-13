using System;

namespace Portal.Data.Entities.ClientEntities
{
    public class OtelReportRequest
    {
        public OtelReportRequest()
        {
            reportGlobalParameters = new ReportGlobalParameters();
            reportCustomerParameters = new ReportCustomerParameters();
        }
        public ReportGlobalParameters reportGlobalParameters { get; set; }
        public ReportCustomerParameters reportCustomerParameters { get; set; }

        public string hotelIDs { get; set; } = string.Empty; // seçilen değerler ';' ile ayrılmalı "1;2;23;56;....."
        public string hotelpaymentTypeIDs { get; set; } = string.Empty;
        public string supplierIDs { get; set; } = string.Empty;
        public string roomTypeIDs { get; set; } = string.Empty;// seçilen değerler ';' ile ayrılmalı "1;2;23;56;....."
        public string bedTypeIDs { get; set; } = string.Empty;// seçilen değerler ';' ile ayrılmalı "1;2;23;56;....."
        public string hostelTypeIDs { get; set; } = string.Empty;// seçilen değerler ';' ile ayrılmalı "1;2;23;56;....."
        public string hotelLocationIDs { get; set; } = string.Empty; // seçilen değerler ';' ile ayrılmalı "1;2;23;56;....."
        public string hotelSupplierChainIDs { get; set; } = string.Empty; // seçilen değerler ';' ile ayrılmalı "1;2;23;56;....."
        public string confirmationNumber { get; set; } = string.Empty;
        public string voucherNnumber { get; set; } = string.Empty;
    }
}

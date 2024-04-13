using System;

namespace Portal.Data.Entities.ClientEntities
{
    public class ReportCustomerParameters
    {
        public DateTime? serviceBeginDate1 { get; set; }
        public DateTime? serviceBeginDate2 { get; set; }
        public DateTime? serviceEndDate1 { get; set; }
        public DateTime? serviceEndDate2 { get; set; }
        public string paymentTypeIDs { get; set; }=string.Empty;
        public string customerEmployeeIDs { get; set; } = string.Empty; // seçilen değerler ';' ile ayrılmalı "1;2;23;56;....."
        public string customerEmployeeTypeIDs { get; set; } = string.Empty; // seçilen değerler ';' ile ayrılmalı "1;2;23;56;....."
        public string customerDepartmentIDs { get; set; } = string.Empty;// seçilen değerler ';' ile ayrılmalı "1;2;23;56;....."
        public string projectIDs { get; set; } = string.Empty; // seçilen değerler ';' ile ayrılmalı "1;2;23;56;....."
        public string reasonIDs { get; set; } = string.Empty; // seçilen değerler ';' ile ayrılmalı "1;2;23;56;....."
        public string passengerClassIDs { get; set; } = string.Empty; // seçilen değerler ';' ile ayrılmalı "1;2;23;56;....."
        public string sectionIDs { get; set; } = string.Empty;
        public string locationIDs { get; set; } = string.Empty;
        public string claimCode { get; set; } = string.Empty;
        public string confirmationCode { get; set; } = string.Empty;


    }
}

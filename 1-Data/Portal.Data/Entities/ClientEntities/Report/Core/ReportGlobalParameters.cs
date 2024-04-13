using System;

namespace Portal.Data.Entities.ClientEntities
{
    public class ReportGlobalParameters
    {
        public string customerIDs { get; set; } = string.Empty; // seçilen değerler ';' ile ayrılmalı "1;2;23;56;....."
        public string customerGroupIDs { get; set; } = string.Empty; // seçilen değerler ';' ile ayrılmalı "1;2;23;56;....."
        public DateTime? processDate1 { get; set; }
        public DateTime? processDate2 { get;set; }
        public string employeeIDs { get; set; } = string.Empty; // seçilen değerler ';' ile ayrılmalı "1;2;23;56;....."
        public string issuedBy { get; set; } = string.Empty;
        public DateTime? issueDate1 { get; set;}
        public DateTime? issueDate2 { get;set; }
        public int reportCurrencyID { get; set; }
        public int reportCurrencyRateTypeID { get; set; }
        public string transactionNumber { get; set; }
        public string processStatusIDs { get; set; }
        public int isDomestic { get; set; } = 0; // 0-hepsi, 1-yurtiçi, 2-yurtdışı
        public string employeeDepartmentIDs { get; set; } = string.Empty;// seçilen değerler ';' ile ayrılmalı "1;2;23;56;....."
        public string positionIDs { get; set; }
        public string invoiceNubmer { get; set; }
        public DateTime? invoiceDate1 { get; set; }
        public DateTime? invoiceDate2 { get;set; }
        public string specialCode1IDs { get; set; }
        public string specialCode2IDs { get;set; }
        public string specialCode3IDs { get; set; }
    }
}

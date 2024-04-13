namespace Portal.Data.Entities.ClientEntities
{
    public class InvoiceReportRequest
    {
        public DateTime? invoiceDateBegin { get; set; } = null; // işlem tarihi başlama
        public DateTime? invoiceDateEnd { get; set; } = null; // işlem tarihi bitiş
        public DateTime? expiryDateBegin { get; set; } = null; // işlem tarihi başlama
        public DateTime? expiryDateEnd { get; set; } = null; // işlem tarihi bitiş
        public string invoiceGroupIDs { get; set; } = null;
        public string customerIDs { get; set; } = string.Empty; // seçilen değerler ';' ile ayrılmalı "1;2;23;56;....."
        public string customerGroupIDs { get; set; } = string.Empty; // seçilen değerler ';' ile ayrılmalı "1;2;23;56;....."
        public string personelIDs { get; set; } = string.Empty; // seçilen değerler ';' ile ayrılmalı "1;2;23;56;....."
        public string invoiceTypeIDs { get; set; } = null;
        public string positionIDs { get; set; } = string.Empty; // seçilen değerler ';' ile ayrılmalı "1;2;23;56;....."
        public string costCenterIDs { get; set; } = string.Empty; // seçilen değerler ';' ile ayrılmalı "1;2;23;56;....."
        public int currencyID { get; set; } = 0;
    }
}
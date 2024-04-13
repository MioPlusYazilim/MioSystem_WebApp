using System;

namespace Portal.Data.Entities.ClientEntities
{
    public class HotelWebReportViewResult
    {
        public string TransactionNo { get; set; }
        public DateTime SaleDate { get; set; }
        public string PassengerName { get; set; }
        public string HotelName { get; set; }
        public DateTime? CheckInDate { get; set; }
        public DateTime? CheckOutDate { get; set; }
        public int? Night { get; set; }
        public string Location { get; set; }
        public string Status { get; set; }
        public string Notes { get; set; }
        public string IssuedBy { get; set; }
        public string Project { get; set; }
        public string Currency { get; set; }
        public double Price { get; set; }
        public double LocalCurrencyPrice { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime? InvoiceDate { get; set; }
    }
}

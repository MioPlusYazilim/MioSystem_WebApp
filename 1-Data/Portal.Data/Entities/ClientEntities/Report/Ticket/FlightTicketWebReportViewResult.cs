using System;

namespace Portal.Data.Entities.ClientEntities
{
    public class FlightTicketWebReportViewResult
    {
        public string Pnr { get; set; }
        public string TicketNumber { get; set; }
        public string Destination { get; set; }
        public string Status { get; set; }
        public string IssuedBy { get; set; }
        public string CostCenter { get; set; }
        public string Project { get; set; }
        public DateTime? SaleDate { get; set; }
        public string Airline { get; set; }
        public string Passenger { get; set; }
        public DateTime? FlightDate { get; set; }
        public double TicketCost { get; set; }
        public string CustomerName { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime? InvoiceDate { get; set; }
    }
}

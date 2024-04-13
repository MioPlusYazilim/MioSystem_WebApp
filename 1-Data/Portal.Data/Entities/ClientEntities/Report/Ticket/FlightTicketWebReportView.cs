using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class FlightTicketWebReportView : BaseEntity
    {
        public FlightTicketWebReportView()
        {
        }

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
        public int? prmCustomerEmployeeID { get; set; }
        public int? prmCustomerDepartmentID { get; set; }
        public int? prmCustomerID { get; set; }
        public int? prmCustomerGroupID { get; set; }
        public int? prmEmployeeID { get; set; }
        public int? prmEmployeeDepartmentID { get; set; }
        public int prmEmployeeModulID { get; set; }
        public DateTime? prmTransactiondate { get; set; }
        public string prmRequest { get; set; }
        public DateTime? prmRequestDate { get; set; }
        public int prmCurrencyID { get; set; }
        public int prmExchangeTypeID { get; set; }
        public string prmTransactionNo { get; set; }
        public int prmStatusID { get; set; }
        public int prmIsDomestic { get; set; }
        public int? prmPositionID { get; set; }
        public string prmInvoiceNo { get; set; }
        public DateTime? prmInvoiceDate { get; set; }
        public int? prmSpecialID1 { get; set; }
        public int? prmSpecialID2 { get; set; }
        public int? prmSpecialID3 { get; set; }
        public DateTime? prmBeginDate { get; set; }
        public DateTime? prmEndDate { get; set; }
        public int? prmPaymentTypeID { get; set; }
        public int prmEmployeeTypeID { get; set; }
        public string prmEmployeeName { get; set; }
        public int? prmCustomerCostCenterID { get; set; }
        public int? prmReasonCode { get; set; }
        public int prmPassengerClassTypeID { get; set; }
        public int prmCustomerSectionID { get; set; }
        public int prmCustomerLocationID { get; set; }
        public string prmRequestCode { get; set; }
        public string prmApprovalCode { get; set; }
        public int? prmFlightCabinTypeID { get; set; }
        public string prmAirLine { get; set; }
        public int? prmFlightLineDistanceID { get; set; }
        public int? prmFlightLineZoneID { get; set; }
        public int prmTicketTypeID { get; set; }
        public bool prmFlightDirectionID { get; set; }
        public int prmTicketStatusTypeID { get; set; }
    }

    /*EntityMap Oluştur*/
    public class FlightTicketWebReportView_Configuration : IEntityTypeConfiguration<FlightTicketWebReportView>
    {
        public void Configure(EntityTypeBuilder<FlightTicketWebReportView> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.ToTable("FlightTicketWebReportView");
            // Navigate Properties
        }
    }
}

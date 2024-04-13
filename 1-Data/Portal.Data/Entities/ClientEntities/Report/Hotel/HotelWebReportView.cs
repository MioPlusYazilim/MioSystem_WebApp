using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class HotelWebReportView : BaseEntity
    {
        public HotelWebReportView()
        {
        }

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
        public int? prmCustomerEmployeeID { get; set; }
        public int? prmCustomerDepartmentID { get; set; }
        public int prmCustomerID { get; set; }
        public int? prmCustomerGrupID { get; set; }
        public int? prmEmployeeID { get; set; }
        public int? prmEmployeeDepartmentID { get; set; }
        public int prmEmployeeModulID { get; set; }
        public DateTime prmTransactiondate { get; set; }
        public string prmRequest { get; set; }
        public DateTime? prmRequestDate { get; set; }
        public int prmCurrencyID { get; set; }
        public int prmExchangeTypeID { get; set; }
        public string prmTransactionNo { get; set; }
        public int? prmStatusID { get; set; }
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
        public string prmPassengerName { get; set; }
        public int prmPassengerTypeID { get; set; }
        public int? prmCustomerCostCenterID { get; set; }
        public int? prmReasonCode { get; set; }
        public int prmPassengerClassTypeID { get; set; }
        public int prmCustomerSectionID { get; set; }
        public int prmCustomerLocationID { get; set; }
        public string prmRequestCode { get; set; }
        public string prmApprovalCode { get; set; }
        public int prmHotelID { get; set; }
        public int prmPayerTypeID { get; set; }
        public int? prmSupplierID { get; set; }
        public int? prmRoomKindID { get; set; }
        public int? prmRoomTypeID { get; set; }
        public int? prmPansionTypeID { get; set; }
        public int? prmHotelLocationID { get; set; }
        public int? prmHotelChainID { get; set; }
        public string prmConfirmeNo { get; set; }
        public string prmVoucherNo { get; set; }
    }

    /*EntityMap Oluştur*/
    public class HotelWebReportView_Configuration : IEntityTypeConfiguration<HotelWebReportView>
    {
        public void Configure(EntityTypeBuilder<HotelWebReportView> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.ToTable("HotelWebReportView");
            // Navigate Properties
        }
    }
}

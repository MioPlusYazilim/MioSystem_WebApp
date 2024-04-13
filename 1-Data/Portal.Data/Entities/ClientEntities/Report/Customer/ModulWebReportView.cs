using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class ModulWebReportView : BaseEntity
    {
        public ModulWebReportView()
        {
        }

        public string Module { get; set; }
        public string IsDomestic { get; set; }
        public DateTime? Transactiondate { get; set; }
        public string TransactionNo { get; set; }
        public string PassengerName { get; set; }
        public string CustomerName { get; set; }
        public DateTime? ServiceBegin { get; set; }
        public DateTime? ServiceEnd { get; set; }
        public string Supplier { get; set; }
        public string CostCenter { get; set; }
        public string IssuedBy { get; set; }
        public string ClaimCode { get; set; }
        public string ConfirmationCode { get; set; }
        public string Status { get; set; }
        public double SaleTotal { get; set; }
        public string Employee { get; set; }
        public string PositionCode { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string InvoiceNumber { get; set; }
        public string Department { get; set; }
        public int prmModulID { get; set; }
        public int? prmCustomerID { get; set; }
        public int? prmCustomerGrupID { get; set; }
        public int? prmPersonelID { get; set; }
        public int? prmPositionID { get; set; }
        public int? prmSupplierID { get; set; }
        public int? prmPaymentTypeID { get; set; }
        public int? prmIssuedBy { get; set; }
        public DateTime? prmIssueDate { get; set; }
        public int? prmSpecialID1 { get; set; }
        public int? prmSpecialID2 { get; set; }
        public int? prmSpecialID3 { get; set; }
        public int? prmStatusID { get; set; }
        public int? prmCustomerDepartmentID { get; set; }
        public int? prmPassengerID { get; set; }
        public int prmIsDomestic { get; set; }
        public int prmCurrencyID { get; set; }
        public int prmExchangeTypeID { get; set; }
        public int prmDepartmentID { get; set; }
        public int prmPassengerTypeID { get; set; }
        public int prmPassengerClassTypeID { get; set; }
        public int prmProjectID { get; set; }
        public int prmReasonCode { get; set; }
        public int prmEmployeeTypeID { get; set; }
        public int prmSectionID { get; set; }
        public int prmLocationID { get; set; }
        public int prmStaffDepartmentID { get; set; }
        public int prmCustomerCostCenterID { get; set; }
        public int prmCustomerSectionID { get; set; }
        public int prmCustomerLocationID { get; set; }
    }

    /*EntityMap Oluştur*/
    public class ModulWebReportView_Configuration : IEntityTypeConfiguration<ModulWebReportView>
    {
        public void Configure(EntityTypeBuilder<ModulWebReportView> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Ignore(i => i.Deleted);
            builder.ToTable("ModulWebReportView");
            // Navigate Properties
        }
    }
}
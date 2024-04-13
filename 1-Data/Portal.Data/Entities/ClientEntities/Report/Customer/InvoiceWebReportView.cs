using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class InvoiceWebReportView : BaseEntity
    {
        public InvoiceWebReportView()
        {
        }

        public string TransactionNo { get; set; }
        public string InvoiceGroup { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public DateTime? ExpryDate { get; set; }
        public string InvoiceTypeKind { get; set; }
        public string InvoiceType { get; set; }
        public string Customer { get; set; }
        public string Position { get; set; }
        public string Employee { get; set; }
        public double Total { get; set; }
        public double Tax { get; set; }
        public double GrnadTotal { get; set; }
        public int prmCustomerID { get; set; }
        public int? prmCustomerGroupID { get; set; }
        public int prmCustomerEmployeeID { get; set; }
        public int prmCustomerDepartmentID { get; set; }
        public int prmEmployeeID { get; set; }
        public int? prmEmployeeDepartmentID { get; set; }
        public int prmEmployeeModulID { get; set; }
        public int prmInvoiceGroupID { get; set; }
        public int prmInvoiceTypeID { get; set; }
        public int prmPositionID { get; set; }
        public int? prmCurrencyID { get; set; }
    }

    /*EntityMap Oluştur*/
    public class InvoiceWebReportView_Configuration : IEntityTypeConfiguration<InvoiceWebReportView>
    {
        public void Configure(EntityTypeBuilder<InvoiceWebReportView> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Ignore(i => i.Deleted);
            builder.ToTable("InvoiceWebReportView");
            // Navigate Properties
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class InvoiceDetail : BaseEntity
    {
        public InvoiceDetail()
        {
        }

        public int InvoiceID { get; set; }
        public int? ServiceCardID { get; set; }
        public string ServiceCardCode { get; set; }
        public string PassengerName { get; set; }
        public string Notes { get; set; }
        public int Unit { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public string CurrencyCode { get; set; }
        public double Exchange { get; set; }
        public double TaxRate { get; set; }
        public double TaxAmount { get; set; }
        public bool IsTaxIncluding { get; set; }
        public double DiscountRate { get; set; }
        public double DiscountAmount { get; set; }
        public double Amount { get; set; }
        public double TaxFreeAmount { get; set; }
        public double TotalAmount { get; set; }
        public double TransactionAmount { get; set; }
        public double PaymentAmount { get; set; }
        public bool IsTaxCut { get; set; }
        public string TaxCutCode { get; set; }
        public double TaxCutRate { get; set; }
        public double TaxCutAmount { get; set; }
        public bool IsTaxExemp { get; set; }
        public string TaxExempType { get; set; }
        public string TaxExempCode { get; set; }
        public bool IsInternational { get; set; }
        public int TransactionID { get; set; }
        public int TransactionDetailID { get; set; }
        public int MasterID { get; set; }
        public int DetailID { get; set; }
        public int? SubDetailID { get; set; }
        public int TransactionGroupID { get; set; }
        public int ModuleID { get; set; }
        public double DiscountAmountLocal { get; set; }
        public double UnitPriceLocal { get; set; }
        public double TaxAmountLocal { get; set; }
        public double AmountLocal { get; set; }
        public double TaxFreeAmountLocal { get; set; }
        public double TotalAmountLocal { get; set; }
        public double TransactionAmountLocal { get; set; }
        public double PaymentAmountLocal { get; set; }
        public double TaxCutAmountLocal { get; set; }
    }

    /*EntityMap Oluştur*/
    public class InvoiceDetail_Configuration : IEntityTypeConfiguration<InvoiceDetail>
    {
        public void Configure(EntityTypeBuilder<InvoiceDetail> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();

            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("InvoiceDetail");
            // Navigate Properties
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class CustomerAccount : BaseEntity
    {
        public CustomerAccount()
        {
        }

        public int CustomerID { get; set; }
        public string CustomerTitle { get; set; }
        public string TaxOffice { get; set; }
        public string TaxNumber { get; set; }
        public bool IsPrivate { get; set; }
        public bool IsGovernmentAgency { get; set; }
        public bool IsTaxFree { get; set; }
        public bool IsDiplomatic { get; set; }
        public bool IsCityTax { get; set; }
        public bool IsException { get; set; }
        public double ExceptionLimit { get; set; }
        public int ExceptionCodeID { get; set; }
        public string Currency { get; set; }
        public string ReportCurrency { get; set; }
        public int CurrencyRateTypeID { get; set; }
        public double IncreaseRate { get; set; }
        public int PaymentTempID { get; set; }
        public bool IsEInvoice { get; set; }
        public int InvoiceTypeID { get; set; }
        public bool IsGroupInvoice { get; set; }
        public bool TaxPaymentInfo { get; set; }
        public bool TaxPaymentTempInfo { get; set; }
        public string InvoiceProperty { get; set; }
        public string Note { get; set; }
    }

    /*EntityMap Oluştur*/
    public class CustomerAccount_Configuration : IEntityTypeConfiguration<CustomerAccount>
    {
        public void Configure(EntityTypeBuilder<CustomerAccount> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();

            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("CustomerAccount");
            // Navigate Properties
        }
    }
}

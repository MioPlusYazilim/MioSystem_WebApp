using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;

namespace Portal.Data.Entities.ClientEntities
{
    public class InvoiceCheckView : BaseEntity
    {
        public InvoiceCheckView()
        {
        }

        public double total { get; set; }
        public string invoiceModel { get; set; }
        public DateTime transactionDate { get; set; }
        public string transactionNumber { get; set; }
        public DateTime serviceBeginDate { get; set; }
        public DateTime serviceEndDate { get; set; }
        public string passengerName { get; set; }
        public string costCenter { get; set; }
        public string currency { get; set; }
        public decimal notInvoiced { get; set; }
        public double currencyRate { get; set; }
        public double notInvoicedTL { get; set; }
        public int vatInclude { get; set; }
        public int vatRate { get; set; }
        public int vatTotal { get; set; }
        public string statusCode { get; set; }
        public string reasonCode { get; set; }
        public string invoiceNote { get; set; }
        public string institutionalNote { get; set; }
        public string issuedBy { get; set; }
        public string requestCode { get; set; }
        public string conrifmationCode { get; set; }
    }

    /*EntityMap Oluştur*/
    public class InvoiceCheckView_Configuration : IEntityTypeConfiguration<InvoiceCheckView>
    {
        public void Configure(EntityTypeBuilder<InvoiceCheckView> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Ignore(i => i.Deleted);
            builder.ToTable("CustomerInvoiceCheckView");
            // Navigate Properties
        }
    }
}
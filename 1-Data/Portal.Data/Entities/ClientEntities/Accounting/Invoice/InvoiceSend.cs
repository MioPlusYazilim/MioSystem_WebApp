using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class InvoiceSend : BaseEntity
    {
        public InvoiceSend()
        {
        }

        public int InvoceID { get; set; }
        public bool IsAccountingSend { get; set; }
        public DateTime? AccountingSendDate { get; set; }
        public string AccountingReference { get; set; }
        public bool IsTaxOfficeSend { get; set; }
        public DateTime? TaxOfficeSendDate { get; set; }
        public string TaxOfficeReference { get; set; }
        public bool IsEMailSend { get; set; }
        public bool IsPrinterSend { get; set; }
        public double TaxOfficeAmount { get; set; }
        public bool IsTaxOfficeInvoice { get; set; }
        public bool IsAutoCreated { get; set; }
        public bool IsAccountingAutoSend { get; set; }
        public bool IsTaxOfficeAutoSend { get; set; }
    }

    /*EntityMap Oluştur*/
    public class InvoiceSend_Configuration : IEntityTypeConfiguration<InvoiceSend>
    {
        public void Configure(EntityTypeBuilder<InvoiceSend> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();

            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("InvoiceSend");
            // Navigate Properties
        }
    }
}

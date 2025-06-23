using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class InvoicePayment : BaseEntity
    {
        public InvoicePayment()
        {
        }

        public int InvoiceID { get; set; }
        public int PaymentTypeID { get; set; }
        public string CreditCardNo { get; set; }
        public string CreditCardLastDate { get; set; }
        public string CreditCardCCV { get; set; }
        public int PaymentDay { get; set; }
        public DateTime PaymentDate { get; set; }
        public int PaymentBankID { get; set; }
        public string PaymentBankIBAN { get; set; }
        public string ReferenceNumber { get; set; }
        public string PaymentNotes { get; set; }
        public bool IsAutoCreated { get; set; }
    }

    /*EntityMap Oluştur*/
    public class InvoicePayment_Configuration : IEntityTypeConfiguration<InvoicePayment>
    {
        public void Configure(EntityTypeBuilder<InvoicePayment> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();

            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("InvoicePayment");
            // Navigate Properties
        }
    }
}

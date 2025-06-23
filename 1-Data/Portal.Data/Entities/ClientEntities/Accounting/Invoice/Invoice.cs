using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class Invoice : BaseEntity
    {
        public Invoice()
        {
        }

        public int TransactionTypeID { get; set; }
        public string TransactionNo { get; set; }
        public int InvoiceTypeID { get; set; }
        public int DocumentTypeID { get; set; }
        public DateTime DocumentDate { get; set; }
        public string DocumentTime { get; set; }
        public string DocumentNo { get; set; }
        public bool IsPerson { get; set; }
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerMail { get; set; }
        public string TaxOffice { get; set; }
        public string TaxNo { get; set; }
        public string InvoiceProperty { get; set; }
        public string CurrencyCode { get; set; }
        public double Exchange { get; set; }
        public bool IsExchangeDay { get; set; }
        public int PositionID { get; set; }
        public int StaffID { get; set; }
        public bool IsArchive { get; set; }
        public int CompanyID { get; set; }
        public bool FState { get; set; }
    }

    /*EntityMap Oluştur*/
    public class Invoice_Configuration : IEntityTypeConfiguration<Invoice>
    {
        public void Configure(EntityTypeBuilder<Invoice> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();

            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("Invoice");
            // Navigate Properties
        }
    }
}


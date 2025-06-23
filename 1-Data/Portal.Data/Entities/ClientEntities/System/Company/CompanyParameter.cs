using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class CompanyParameter : BaseEntity
    {
        public CompanyParameter()
        {
        }

        public int CompanyID { get; set; }
        public int DriverTypeID { get; set; }
        public int DirectoryTypeID { get; set; }
        public int TicketStaffTypeID { get; set; }
        public string ExchangeLink { get; set; }
        public int ExchangeTypeID { get; set; }
        public bool IsRecordLog { get; set; }
        public bool IsCreditCardFormat { get; set; }
        public int IsAutoRequestNumberID { get; set; }
        public bool IsNameFormat { get; set; }
        public int NameFormatTypeID { get; set; }
        public int BuyingInvoiceTypeID { get; set; }
        public int SalesInvoiceTypeID { get; set; }
        public int RefundReceiptTypeID { get; set; }
        public int CustomerReceiptTypeID { get; set; }
        public int InvoiceMailStatusID { get; set; }
        public int ReceiptMailStatusID { get; set; }
        public int MailOrderStatusID { get; set; }
        public string VersiyonNumber { get; set; }
        public int? LocalCurrency { get; set; }
        public int? ActiveCurrency { get; set; }
        public int? ReportCurrency { get; set; }
    }

    /*EntityMap Oluştur*/
    public class CompanyParameter_Configuration : IEntityTypeConfiguration<CompanyParameter>
    {
        public void Configure(EntityTypeBuilder<CompanyParameter> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();

            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("CompanyParameter");
            // Navigate Properties
        }
    }
}


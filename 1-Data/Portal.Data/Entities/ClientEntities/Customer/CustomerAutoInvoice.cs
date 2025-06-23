using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class CustomerAutoInvoice : BaseEntity
    {
        public CustomerAutoInvoice()
        {
        }

        public int CustomerID { get; set; }
        public DateTime BeginDate { get; set; }
        public int RoleDate { get; set; }
        public int InvoiceDate { get; set; }
        public int? DateValue { get; set; }
        public string AutoInvoiceType { get; set; }
        public bool IsUnDate { get; set; }
        public bool IsDomestic { get; set; }
        public bool IsInternational { get; set; }
        public bool IsTevkifat { get; set; }
        public bool IsActive { get; set; }
        public int ModuleID { get; set; }
    }

    /*EntityMap Oluştur*/
    public class CustomerAutoInvoice_Configuration : IEntityTypeConfiguration<CustomerAutoInvoice>
    {
        public void Configure(EntityTypeBuilder<CustomerAutoInvoice> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();

            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("CustomerAutoInvoice");
            // Navigate Properties
        }
    }
}


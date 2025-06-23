using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class InvoiceTemplate : BaseEntity
    {
        public InvoiceTemplate()
        {
        }

        public int IntegratorID { get; set; }
        public int InvoiceTypeID { get; set; }
        public string Code { get; set; }
        public string Template { get; set; }
        public bool IsActive { get; set; }
        public int ModuleID { get; set; }
        public int CompanyID { get; set; }
        public bool FState { get; set; }
    }

    /*EntityMap Oluştur*/
    public class InvoiceTemplate_Configuration : IEntityTypeConfiguration<InvoiceTemplate>
    {
        public void Configure(EntityTypeBuilder<InvoiceTemplate> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();

            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("InvoiceTemplate");
            // Navigate Properties
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class InvoiceDocumentType : BaseEntity
    {
        public InvoiceDocumentType()
        {
        }

        public string Code { get; set; }
        public string CodeName { get; set; }
        public string InvoiceTransactionTypeIDs { get; set; }
        public int CompanyID { get; set; }
        public bool FState { get; set; }
    }

    /*EntityMap Oluştur*/
    public class InvoiceDocumentType_Configuration : IEntityTypeConfiguration<InvoiceDocumentType>
    {
        public void Configure(EntityTypeBuilder<InvoiceDocumentType> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();

            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("InvoiceDocumentType");
            // Navigate Properties
        }
    }
}

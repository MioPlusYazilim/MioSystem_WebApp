using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class TransactionDocument : BaseEntity
    {
        public TransactionDocument()
        {
        }

        public int? ParentID { get; set; }
        public int DocumentTypeID { get; set; }
        public DateTime DocumentDate { get; set; }
        public DateTime? DocumentValidityDate { get; set; }
        public string DocumentName { get; set; }
        public string DocumentLink { get; set; }
        public string DocumentNote { get; set; }
        public bool IsHidden { get; set; }
        public int EmployeeID { get; set; }
    }

    /*EntityMap Oluştur*/
    public class TransactionDocument_Configuration : IEntityTypeConfiguration<TransactionDocument>
    {
        public void Configure(EntityTypeBuilder<TransactionDocument> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();
            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("TransactionDocument");
            // Navigate Properties
        }
    }
}

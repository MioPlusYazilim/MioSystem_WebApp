using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class DocumentManagement : BaseEntity
    {
        public DocumentManagement()
        {
        }

        public int DocumentID { get; set; }
        public string DocumentName { get; set; }
        public byte[] DocumentValue { get; set; }
        public string DocumentUrl { get; set; }
        public int ParentTag { get; set; }
        public int ParentID { get; set; }
        public DateTime ValidityDate { get; set; }
        public bool IsWarning { get; set; }
        public string OwnerEmail { get; set; }
        public string AcountingEmail { get; set; }
        public int EarlyWarningDay { get; set; }
        public int CompanyID { get; set; }
        public bool FState { get; set; }
    }

    /*EntityMap Oluştur*/
    public class DocumentManagement_Configuration : IEntityTypeConfiguration<DocumentManagement>
    {
        public void Configure(EntityTypeBuilder<DocumentManagement> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();

            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("DocumentManagement");
            // Navigate Properties
        }
    }
}


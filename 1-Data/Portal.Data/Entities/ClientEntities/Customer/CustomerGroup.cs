using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class CustomerGroup : BaseEntity
    {
        public CustomerGroup()
        {
        }

        public int ParentID { get; set; }
        public string Code { get; set; }
        public string CodeName { get; set; }
        public byte[] Logo { get; set; }
        public int CompanyID { get; set; }
        public bool Ftate { get; set; }
    }

    /*EntityMap Oluştur*/
    public class CustomerGroup_Configuration : IEntityTypeConfiguration<CustomerGroup>
    {
        public void Configure(EntityTypeBuilder<CustomerGroup> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();
            builder.Property(t => t.ParentID).HasColumnName("ParentID").IsRequired();
            builder.Property(t => t.Code).HasColumnName("Code").IsRequired().HasMaxLength(50);
            builder.Property(t => t.CodeName).HasColumnName("CodeName").HasMaxLength(200);
            builder.Property(t => t.Logo).HasColumnName("Logo");
            builder.Property(t => t.CompanyID).HasColumnName("CompanyID").IsRequired();
            builder.Property(t => t.Deleted).HasColumnName("Deleted").IsRequired();
            builder.Property(t => t.Ftate).HasColumnName("Ftate").IsRequired();

            builder.Ignore(i => i.Deleted);
            builder.ToTable("CustomerGroup");
            // Navigate Properties
        }
    }
}
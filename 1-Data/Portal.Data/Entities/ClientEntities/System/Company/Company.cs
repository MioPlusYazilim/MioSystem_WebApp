using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class Company : BaseEntity
    {
        public Company()
        {
        }

        public string Code { get; set; }
        public string CodeName { get; set; }
        public string LoginName { get; set; }
        public int SystemID { get; set; }
        public bool IsActive { get; set; }
        public Guid RefKey { get; set; }
        public int CompanyID { get; set; }
        public bool FState { get; set; }
    }

    /*EntityMap Oluştur*/
    public class Company_Configuration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();
            builder.Property(t => t.Code).HasColumnName("Code").HasMaxLength(80);
            builder.Property(t => t.CodeName).HasColumnName("CodeName").IsRequired().HasMaxLength(400);
            builder.Property(t => t.LoginName).HasColumnName("LoginName").HasMaxLength(50);
            builder.Property(t => t.SystemID).HasColumnName("SystemID").IsRequired();
            builder.Property(t => t.IsActive).HasColumnName("IsActive").IsRequired();
            builder.Property(t => t.RefKey).HasColumnName("RefKey").IsRequired();
            builder.Property(t => t.CompanyID).HasColumnName("CompanyID").IsRequired();
            builder.Property(t => t.Deleted).HasColumnName("Deleted").IsRequired();
            builder.Property(t => t.FState).HasColumnName("FState").IsRequired();

            builder.Ignore(i => i.Deleted);
            builder.ToTable("Company");
            // Navigate Properties
        }
    }
}

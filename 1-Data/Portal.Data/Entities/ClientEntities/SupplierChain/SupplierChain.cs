using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class SupplierChain : BaseEntity
    {
        public SupplierChain()
        {
        }

        public string Code { get; set; }
        public string CodeName { get; set; }
        public string ModulesID { get; set; }
        public int CompanyID { get; set; }
        public bool FState { get; set; }
    }

    /*EntityMap Oluştur*/
    public class SupplierChain_Configuration : IEntityTypeConfiguration<SupplierChain>
    {
        public void Configure(EntityTypeBuilder<SupplierChain> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();
            builder.Property(t => t.Code).HasColumnName("Code").IsRequired().HasMaxLength(40);
            builder.Property(t => t.CodeName).HasColumnName("CodeName").HasMaxLength(100);
            builder.Property(t => t.ModulesID).HasColumnName("ModulesID").HasMaxLength(50);
            builder.Property(t => t.CompanyID).HasColumnName("CompanyID").IsRequired();
            builder.Property(t => t.Deleted).HasColumnName("Deleted").IsRequired();
            builder.Property(t => t.FState).HasColumnName("FState").IsRequired();

            builder.Ignore(i => i.Deleted);
            builder.ToTable("SupplierChain");
            // Navigate Properties
        }
    }
}
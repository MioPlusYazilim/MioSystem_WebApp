using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class Position : BaseEntity
    {
        public Position()
        {
        }

        public int? ParentID { get; set; }
        public string Code { get; set; }
        public string CodeName { get; set; }
        public DateTime? BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsActive { get; set; }
        public string ModuleIDs { get; set; }
        public int CompanyID { get; set; }
        public bool FState { get; set; }
    }

    /*EntityMap Oluştur*/
    public class Position_Configuration : IEntityTypeConfiguration<Position>
    {
        public void Configure(EntityTypeBuilder<Position> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();
            builder.Property(t => t.ParentID).HasColumnName("ParentID");
            builder.Property(t => t.Code).HasColumnName("Code").IsRequired().HasMaxLength(80);
            builder.Property(t => t.CodeName).HasColumnName("CodeName").IsRequired().HasMaxLength(200);
            builder.Property(t => t.BeginDate).HasColumnName("BeginDate");
            builder.Property(t => t.EndDate).HasColumnName("EndDate");
            builder.Property(t => t.IsActive).HasColumnName("IsActive").IsRequired();
            builder.Property(t => t.ModuleIDs).HasColumnName("ModuleIDs").IsRequired().HasMaxLength(50);
            builder.Property(t => t.CompanyID).HasColumnName("CompanyID").IsRequired();
            builder.Property(t => t.Deleted).HasColumnName("Deleted").IsRequired();
            builder.Property(t => t.FState).HasColumnName("FState").IsRequired();

            builder.Ignore(i => i.Deleted);
            builder.ToTable("Position");
            // Navigate Properties
        }
    }
}
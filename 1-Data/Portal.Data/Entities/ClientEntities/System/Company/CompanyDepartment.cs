using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class CompanyDepartment : BaseEntity
    {
        public CompanyDepartment()
        {
        }

        public bool IsDefaultCode { get; set; }
        public string DefaultCode { get; set; }
        public string FieldValue { get; set; }
        public int CompanyID { get; set; }
        public bool FState { get; set; }
    }

    /*EntityMap Oluştur*/
    public class CompanyDepartment_Configuration : IEntityTypeConfiguration<CompanyDepartment>
    {
        public void Configure(EntityTypeBuilder<CompanyDepartment> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();

            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("CompanyDepartment");
            // Navigate Properties
        }
    }
}

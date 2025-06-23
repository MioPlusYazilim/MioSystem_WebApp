using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class EmployeePassport : BaseEntity
    {
        public EmployeePassport()
        {
        }

        public int EmployeeID { get; set; }
        public string PassportNo { get; set; }
        public int PassportTypeID { get; set; }
        public DateTime? BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string LocationCode { get; set; }
        public string District { get; set; }
        public bool IsActive { get; set; }
    }

    /*EntityMap Oluştur*/
    public class EmployeePassport_Configuration : IEntityTypeConfiguration<EmployeePassport>
    {
        public void Configure(EntityTypeBuilder<EmployeePassport> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();

            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("EmployeePassport");
            // Navigate Properties
        }
    }
}


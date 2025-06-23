using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class EmployeeCorporate : BaseEntity
    {
        public EmployeeCorporate()
        {
        }

        public int EmployeeID { get; set; }
        public string RegisterNumber { get; set; }
        public string CountryCode { get; set; }
        public string PositionCode { get; set; }
        public string TitleCode { get; set; }
        public string JobCode { get; set; }
        public string WorkCode { get; set; }
        public string DivizyonCode { get; set; }
        public string RegionCode { get; set; }
        public string DepartmentCode { get; set; }
        public string SectionCode { get; set; }
        public string TaskCode { get; set; }
        public string CostCenterCode { get; set; }
        public string LocationCode { get; set; }
        public Guid AssistantID { get; set; }
        public int CollarTypeID { get; set; }
    }

    /*EntityMap Oluştur*/
    public class EmployeeCorporate_Configuration : IEntityTypeConfiguration<EmployeeCorporate>
    {
        public void Configure(EntityTypeBuilder<EmployeeCorporate> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();

            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("EmployeeCorporate");
            // Navigate Properties
        }
    }
}


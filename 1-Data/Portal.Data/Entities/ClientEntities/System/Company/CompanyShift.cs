using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class CompanyShift : BaseEntity
    {
        public CompanyShift()
        {
        }

        public int CompanyID { get; set; }
        public int MonthDayID { get; set; }
        public int ShiftPeriod { get; set; }
        public TimeSpan ShiftBegin { get; set; }
        public TimeSpan ShiftEnd { get; set; }
        public int? ModulID { get; set; }
    }

    /*EntityMap Oluştur*/
    public class CompanyShift_Configuration : IEntityTypeConfiguration<CompanyShift>
    {
        public void Configure(EntityTypeBuilder<CompanyShift> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();

            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("CompanyShift");
            // Navigate Properties
        }
    }
}


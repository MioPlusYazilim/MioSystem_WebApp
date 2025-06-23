using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class GlobalReport : BaseEntity
    {
        public GlobalReport()
        {
        }

        public int ReportTypeID { get; set; }
        public string Code { get; set; }
        public string CultureCode { get; set; }
        public int CompanyID { get; set; }
        public bool FState { get; set; }
    }

    /*EntityMap Oluştur*/
    public class GlobalReport_Configuration : IEntityTypeConfiguration<GlobalReport>
    {
        public void Configure(EntityTypeBuilder<GlobalReport> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();

            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("GlobalReport");
            // Navigate Properties
        }
    }
}


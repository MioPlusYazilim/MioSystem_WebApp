using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class GlobalReportDetail : BaseEntity
    {
        public GlobalReportDetail()
        {
        }

        public int GlobalReportID { get; set; }
        public string StoredProcedure { get; set; }
        public string FileDisplayName { get; set; }
        public string FileReportName { get; set; }
        public string FileDefaultValue { get; set; }
    }

    /*EntityMap Oluştur*/
    public class GlobalReportDetail_Configuration : IEntityTypeConfiguration<GlobalReportDetail>
    {
        public void Configure(EntityTypeBuilder<GlobalReportDetail> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();

            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("GlobalReportDetail");
            // Navigate Properties
        }
    }
}


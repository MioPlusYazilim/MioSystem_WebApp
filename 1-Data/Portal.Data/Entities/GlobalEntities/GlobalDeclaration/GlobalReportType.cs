using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.GlobalEntities
{
    public class GlobalReportType : BaseEntity
    {
        public GlobalReportType()
        {
        }

        public string LanguageCode { get; set; }
        public string FieldValue { get; set; }
        public string FieldName { get; set; }
    }

    /*EntityMap Oluştur*/
    public class GlobalReportType_Configuration : IEntityTypeConfiguration<GlobalReportType>
    {
        public void Configure(EntityTypeBuilder<GlobalReportType> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").IsRequired();
            builder.ToTable("GlobalReportType");
            // Navigate Properties
        }
    }
}

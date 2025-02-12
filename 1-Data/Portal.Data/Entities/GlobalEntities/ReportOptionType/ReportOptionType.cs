using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.GlobalEntities
{
    public class ReportOptionType : BaseEntity
    {
        public ReportOptionType()
        {
        }

        public string LanguageCode { get; set; }
        public string FieldValue { get; set; }
        public string FieldName { get; set; }
    }

    /*EntityMap Oluştur*/
    public class ReportOptionType_Configuration : IEntityTypeConfiguration<ReportOptionType>
    {
        public void Configure(EntityTypeBuilder<ReportOptionType> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").IsRequired();
            builder.ToTable("ReportOptionType");
            // Navigate Properties
        }
    }
}
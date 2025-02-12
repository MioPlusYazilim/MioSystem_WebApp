using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.GlobalEntities
{
    public class SourceType : BaseEntity
    {
        public SourceType()
        {
        }
        public string LanguageCode { get; set; }
        public string FieldValue { get; set; }
        public string FieldName { get; set; }
    }

    /*EntityMap Oluştur*/
    public class SourceType_Configuration : IEntityTypeConfiguration<SourceType>
    {
        public void Configure(EntityTypeBuilder<SourceType> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);
            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").IsRequired();
            builder.ToTable("SourceType");
            // Navigate Properties
        }
    }
}
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.GlobalEntities
{
    public class SpecialCodeType : BaseEntity
    {
        public SpecialCodeType()
        {
        }
        public string LanguageCode { get; set; }
        public string FieldValue { get; set; }
        public string FieldName { get; set; }
    }

    /*EntityMap Oluştur*/
    public class SpecialCodeType_Configuration : IEntityTypeConfiguration<SpecialCodeType>
    {
        public void Configure(EntityTypeBuilder<SpecialCodeType> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);
            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").IsRequired();
            builder.ToTable("SpecialCodeType");
            // Navigate Properties
        }
    }
}
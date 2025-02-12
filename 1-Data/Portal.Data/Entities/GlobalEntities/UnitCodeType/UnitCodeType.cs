using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.GlobalEntities
{
    public class UnitCodeType : BaseEntity
    {
        public UnitCodeType()
        {
        }
        public string LanguageCode { get; set; }
        public string FieldValue { get; set; }
        public string FieldName { get; set; }
    }

    /*EntityMap Oluştur*/
    public class UnitCodeType_Configuration : IEntityTypeConfiguration<UnitCodeType>
    {
        public void Configure(EntityTypeBuilder<UnitCodeType> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);
            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").IsRequired();
            builder.ToTable("UnitCodeType");
            // Navigate Properties
        }
    }
}
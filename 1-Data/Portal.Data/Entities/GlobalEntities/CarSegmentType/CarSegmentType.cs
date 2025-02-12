using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Portal.Data.Entities.GlobalEntities
{
    public class CarSegmentType : BaseEntity
    {
        public CarSegmentType()
        {
        }
        public string LanguageCode { get; set; }
        public string FieldValue { get; set; }
        public string FieldName { get; set; }
    }

    /*EntityMap Oluştur*/
    public class CarSegmentType_Configuration : IEntityTypeConfiguration<CarSegmentType>
    {
        public void Configure(EntityTypeBuilder<CarSegmentType> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);
            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").IsRequired();
            builder.ToTable("CarSegmentType");
            // Navigate Properties
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.GlobalEntities
{
    public class HotelBedType : BaseEntity
    {
        public HotelBedType()
        {
        }

        public string LanguageCode { get; set; }
        public string FieldValue { get; set; }
        public string FieldName { get; set; }
    }

    /*EntityMap Oluştur*/
    public class HotelBedType_Configuration : IEntityTypeConfiguration<HotelBedType>
    {
        public void Configure(EntityTypeBuilder<HotelBedType> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").IsRequired();
            builder.ToTable("HotelBedType");
            // Navigate Properties
        }
    }
}

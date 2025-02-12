using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.GlobalEntities
{
    public class HotelClassType : BaseEntity
    {
        public HotelClassType()
        {
        }

        public string LanguageCode { get; set; }
        public string FieldValue { get; set; }
        public string FieldName { get; set; }
    }

    /*EntityMap Oluştur*/
    public class HotelClassType_Configuration : IEntityTypeConfiguration<HotelClassType>
    {
        public void Configure(EntityTypeBuilder<HotelClassType> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").IsRequired();
            builder.ToTable("HotelClassType");
            // Navigate Properties
        }
    }
}

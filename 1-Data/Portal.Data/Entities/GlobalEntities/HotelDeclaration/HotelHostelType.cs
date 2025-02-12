using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.GlobalEntities
{
    public class HotelHostelType : BaseEntity
    {
        public HotelHostelType()
        {
        }

        public string LanguageCode { get; set; }
        public string FieldValue { get; set; }
        public string FieldName { get; set; }
    }

    /*EntityMap Oluştur*/
    public class HotelHostelType_Configuration : IEntityTypeConfiguration<HotelHostelType>
    {
        public void Configure(EntityTypeBuilder<HotelHostelType> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").IsRequired();
            builder.ToTable("HotelHostelType");
            // Navigate Properties
        }
    }
}

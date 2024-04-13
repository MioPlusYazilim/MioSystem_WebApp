using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Portal.Data.Entities.GlobalEntities
{
    public class AirPort : BaseEntity
    {
        public AirPort()
        {
        }

        public string LanguageCode { get; set; }
        public string FieldValue { get; set; }
        public string FieldName { get; set; }
        public string CityName { get; set; }
        public string CountryCode { get; set; }
    }

    /*EntityMap Oluştur*/
    public class AirPort_Configuration : IEntityTypeConfiguration<AirPort>
    {
        public void Configure(EntityTypeBuilder<AirPort> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").IsRequired();
            builder.Property(t => t.LanguageCode).HasColumnName("LanguageCode").IsRequired().HasMaxLength(5);
            builder.Property(t => t.FieldValue).HasColumnName("FieldValue").IsRequired().HasMaxLength(3);
            builder.Property(t => t.FieldName).HasColumnName("FieldName").IsRequired().HasMaxLength(200);
            builder.Property(t => t.CityName).HasColumnName("CityName").HasMaxLength(50);
            builder.Property(t => t.CountryCode).HasColumnName("CountryCode").HasMaxLength(5);

            builder.Ignore(i => i.Deleted);
            builder.ToTable("AirPort");
            // Navigate Properties
        }
    }
}

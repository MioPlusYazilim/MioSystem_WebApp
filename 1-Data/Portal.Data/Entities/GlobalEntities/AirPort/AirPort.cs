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
            builder.Ignore(i => i.Deleted);
            builder.ToTable("AirPort");
            // Navigate Properties
        }
    }
}

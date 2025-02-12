using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portal.Data.Entities.GlobalEntities;


namespace Portal.Data.Entities.GlobalEntities
{ 
    public class City : BaseEntity
    {
        public City()
        {
        }
        public string LanguageCode { get; set; }
        public string FieldValue { get; set; }
        public string FieldName { get; set; }
        public string CountryCode { get; set; }
    }
}

/*EntityMap Oluştur*/
    public class City_Configuration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").IsRequired();

            builder.Ignore(i => i.Deleted);
            builder.ToTable("City");
            // Navigate Properties
        }
}

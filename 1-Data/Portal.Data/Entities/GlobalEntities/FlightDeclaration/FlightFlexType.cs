using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Portal.Data.Entities.GlobalEntities
{
    public class FlightFlexType : BaseEntity
    {
        public FlightFlexType()
        {
        }
        public string LanguageCode { get; set; }
        public string FieldValue { get; set; }
        public string FieldName { get; set; }
    }

    /*EntityMap Oluştur*/
    public class FlightFlexType_Configuration : IEntityTypeConfiguration<FlightFlexType>
    {
        public void Configure(EntityTypeBuilder<FlightFlexType> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);
            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").IsRequired();
            builder.ToTable("FlightFlexType");
            // Navigate Properties
        }
    }
}

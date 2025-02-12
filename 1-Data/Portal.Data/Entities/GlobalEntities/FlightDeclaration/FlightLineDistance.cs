using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.GlobalEntities
{
    public class FlightLineDistance : BaseEntity
    {
        public FlightLineDistance()
        {
        }
        public string LanguageCode { get; set; }
        public string FieldValue { get; set; }
        public string FieldName { get; set; }
    }

    /*EntityMap Oluştur*/
    public class FlightLineDistance_Configuration : IEntityTypeConfiguration<FlightLineDistance>
    {
        public void Configure(EntityTypeBuilder<FlightLineDistance> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);
            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").IsRequired();
            builder.ToTable("FlightLineDistance");
            // Navigate Properties
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.GlobalEntities
{
    public class FlightLineZone : BaseEntity
    {
        public FlightLineZone()
        {
        }
        public string LanguageCode { get; set; }
        public string FieldValue { get; set; }
        public string FieldName { get; set; }
    }

    /*EntityMap Oluştur*/
    public class FlightLineZone_Configuration : IEntityTypeConfiguration<FlightLineZone>
    {
        public void Configure(EntityTypeBuilder<FlightLineZone> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);
            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").IsRequired();
            builder.ToTable("FlightLineZone");
            // Navigate Properties
        }
    }
}

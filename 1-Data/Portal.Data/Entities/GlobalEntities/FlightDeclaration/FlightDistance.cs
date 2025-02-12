using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Portal.Data.Entities.GlobalEntities
{
    public class FlightDistance : BaseEntity
    {
        public FlightDistance()
        {
        }

        public string Departure { get; set; }
        public string Arrival { get; set; }
        public string FlyTime { get; set; }
        public float Mile { get; set; }
        public float Carbon { get; set; }
    }

    /*EntityMap Oluştur*/
    public class FlightDistance_Configuration : IEntityTypeConfiguration<FlightDistance>
    {
        public void Configure(EntityTypeBuilder<FlightDistance> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);
            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").IsRequired();
            builder.ToTable("FlightDistance");
            // Navigate Properties
        }
    }
}

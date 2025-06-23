using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities.Modules.Request
{
    public class RequestFlight : BaseEntity
    {
        public RequestFlight()
        {
        }

        public int? RequestID { get; set; }
        public bool IsInternational { get; set; }
        public int FlightStatusID { get; set; }
        public bool IsDirection { get; set; }
        public int? FlightCabinTypeID { get; set; }
        public int FlightFlexTypeID { get; set; }
    }

    /*EntityMap Oluştur*/
    public class RequestFlight_Configuration : IEntityTypeConfiguration<RequestFlight>
    {
        public void Configure(EntityTypeBuilder<RequestFlight> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();
            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("RequestFlight");
            // Navigate Properties
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities.Modules.Request
{
    public class RequestFlightDetails : BaseEntity
    {
        public RequestFlightDetails()
        {
        }

        public int? RequestFlightID { get; set; }
        public string Airline { get; set; }
        public DateTime DepartureDate { get; set; }
        public string DepartureAirport { get; set; }
        public string DepartureTimeRange { get; set; }
        public string ArrivalAirport { get; set; }
        public string ArrivalTimeRange { get; set; }
        public bool IsDepartureFlexibleDate { get; set; }
        public int DepartureFlexibleDay { get; set; }
        public bool IsCheckIn { get; set; }
        public bool IsBaggage { get; set; }
        public int BaggageTotal { get; set; }
    }

    /*EntityMap Oluştur*/
    public class RequestFlightDetails_Configuration : IEntityTypeConfiguration<RequestFlightDetails>
    {
        public void Configure(EntityTypeBuilder<RequestFlightDetails> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();
            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("RequestFlightDetails");
            // Navigate Properties
        }
    }
}



using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class TravelPolicyFlight : BaseEntity
    {
        public TravelPolicyFlight()
        {
        }

        public int TravelPolicyID { get; set; }
        public int FlightLineTypeID { get; set; }
        public int FlightLineDistanceID { get; set; }
        public int FlightDirectionID { get; set; }
        public int FlightCabinTypeID { get; set; }
        public int FlightFlexTypeID { get; set; }
        public int CurrencyID { get; set; }
        public double MaxBudget { get; set; }
        public bool FState { get; set; }
    }

    /*EntityMap Oluştur*/
    public class TravelPolicyFlight_Configuration : IEntityTypeConfiguration<TravelPolicyFlight>
    {
        public void Configure(EntityTypeBuilder<TravelPolicyFlight> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").IsRequired();
            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("TravelPolicyFlight");
            // Navigate Properties
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class TravelPolicyRentACar : BaseEntity
    {
        public TravelPolicyRentACar()
        {
        }

        public bool TravelPolicyID { get; set; }
        public bool IsInternational { get; set; }
        public string CarSegmentIDs { get; set; }
        public bool IsAutomatic { get; set; }
        public string FuelTypeIDs { get; set; }
        public string CurrencyCode { get; set; }
        public double MaxBudget { get; set; }
        public bool FState { get; set; }
    }

    /*EntityMap Oluştur*/
    public class TravelPolicyRentACar_Configuration : IEntityTypeConfiguration<TravelPolicyRentACar>
    {
        public void Configure(EntityTypeBuilder<TravelPolicyRentACar> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").IsRequired();
            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("TravelPolicyRentACar");
            // Navigate Properties
        }
    }
}

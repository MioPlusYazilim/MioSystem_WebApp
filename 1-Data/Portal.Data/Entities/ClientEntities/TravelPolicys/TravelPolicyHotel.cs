using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class TravelPolicyHotel : BaseEntity
    {
        public TravelPolicyHotel()
        {
        }

        public bool TravelPolicyID { get; set; }
        public bool IsInternational { get; set; }
        public string CitysIDs { get; set; }
        public int CurrencyID { get; set; }
        public double MaxBudget { get; set; }
        public bool FState { get; set; }
    }

    /*EntityMap Oluştur*/
    public class TravelPolicyHotel_Configuration : IEntityTypeConfiguration<TravelPolicyHotel>
    {
        public void Configure(EntityTypeBuilder<TravelPolicyHotel> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").IsRequired();
            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("TravelPolicyHotel");
            // Navigate Properties
        }
    }
}

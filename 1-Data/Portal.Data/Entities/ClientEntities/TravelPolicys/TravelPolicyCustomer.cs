using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class TravelPolicyCustomer : BaseEntity
    {
        public TravelPolicyCustomer()
        {
        }

        public int TravelPolicyID { get; set; }
        public int CustomerID { get; set; }
    }

    /*EntityMap Oluştur*/
    public class TravelPolicyCustomer_Configuration : IEntityTypeConfiguration<TravelPolicyCustomer>
    {
        public void Configure(EntityTypeBuilder<TravelPolicyCustomer> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").IsRequired();
            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("TravelPolicyCustomer");
            // Navigate Properties
        }
    }
}
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class AirlineServiceCustomer : BaseEntity
    {
        public AirlineServiceCustomer()
        {
        }

        public int AirlineServiceID { get; set; }
        public int CustomerID { get; set; }
    }

    /*EntityMap Oluştur*/
    public class AirlineServiceCustomer_Configuration : IEntityTypeConfiguration<AirlineServiceCustomer>
    {
        public void Configure(EntityTypeBuilder<AirlineServiceCustomer> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();

            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("AirlineServiceCustomer");
            // Navigate Properties
        }
    }
}

//Completion time: 2025 - 02 - 12T06: 52:41.3699917 + 03:00

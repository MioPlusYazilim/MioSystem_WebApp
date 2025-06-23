using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities.Modules.Request
{
    public class RequestRentAcar : BaseEntity
    {
        public RequestRentAcar()
        {
        }

        public int? RequestID { get; set; }
        public int DepartureCityID { get; set; }
        public DateTime DepartureDate { get; set; }
        public string DepartureLocation { get; set; }
        public int? ArrivalCityID { get; set; }
        public DateTime ArrivalDate { get; set; }
        public string ArrivalLocation { get; set; }
        public int TotalDay { get; set; }
        public int CarSegmentID { get; set; }
        public int FuelTypeID { get; set; }
        public bool IsAutomatic { get; set; }
        public bool IsDriverIncluded { get; set; }
        public string Notes { get; set; }
        public int? StatusID { get; set; }
    }

    /*EntityMap Oluştur*/
    public class RequestRentAcar_Configuration : IEntityTypeConfiguration<RequestRentAcar>
    {
        public void Configure(EntityTypeBuilder<RequestRentAcar> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();
            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("RequestRentAcar");
            // Navigate Properties
        }
    }
}

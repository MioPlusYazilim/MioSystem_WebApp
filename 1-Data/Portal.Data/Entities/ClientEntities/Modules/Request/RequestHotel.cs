using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities.Modules.Request
{
    public class RequestHotel : BaseEntity
    {
        public RequestHotel()
        {
        }

        public int? RequestID { get; set; }
        public int CityID { get; set; }
        public int? HotelID { get; set; }
        public int? HotelTypeID { get; set; }
        public int? HotelClassTypeID { get; set; }
        public DateTime? CheckIn { get; set; }
        public DateTime? CheckOut { get; set; }
        public DateTime? OptionDate { get; set; }
        public int GuestCount { get; set; }
        public int RoomCount { get; set; }
        public int BedTypeID { get; set; }
        public int RoomTypeID { get; set; }
        public int HostelTypeID { get; set; }
        public bool IsContract { get; set; }
        public string Notes { get; set; }
        public int? StatusID { get; set; }
    }

    /*EntityMap Oluştur*/
    public class RequestHotel_Configuration : IEntityTypeConfiguration<RequestHotel>
    {
        public void Configure(EntityTypeBuilder<RequestHotel> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();
            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("RequestHotel");
            // Navigate Properties
        }
    }
}

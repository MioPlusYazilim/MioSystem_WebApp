using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities.Modules.Request
{
    public class RequestParameter : BaseEntity
    {
        public RequestParameter()
        {
        }

        public int CountryID { get; set; }
        public int CityID { get; set; }
        public int StatusID { get; set; }
        public bool IsDirection { get; set; }
        public string Airline { get; set; }
        public string Airport { get; set; }
        public int? TicketTypeID { get; set; }
        public int? CabinTypeID { get; set; }
        public bool IsCheckIn { get; set; }
        public bool IsBaggage { get; set; }
        public int BedTypeID { get; set; }
        public int RoomTypeID { get; set; }
        public int HostelTypeID { get; set; }
        public bool IsContract { get; set; }
        public bool IsOneWay { get; set; }
        public int VisaTypeID { get; set; }
        public int SendInfoTypeID { get; set; }
        public bool IsGroup { get; set; }
        public int CustomerID { get; set; }
        public int OwnerID { get; set; }
        public string ModuleIDs { get; set; }
        public int CompanyID { get; set; }
    }

    /*EntityMap Oluştur*/
    public class RequestParameter_Configuration : IEntityTypeConfiguration<RequestParameter>
    {
        public void Configure(EntityTypeBuilder<RequestParameter> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();
            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("RequestParameter");
            // Navigate Properties
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities.Modules.Request
{
    public class RequestTransfer : BaseEntity
    {
        public RequestTransfer()
        {
        }

        public int RequestID { get; set; }
        public bool IsOneWay { get; set; }
        public int DepartureCityID { get; set; }
        public DateTime DepartureDate { get; set; }
        public string DepartureTime { get; set; }
        public string DepartureAddress { get; set; }
        public int? ArrivalCityID { get; set; }
        public DateTime? ArrivalDate { get; set; }
        public string ArrivalTime { get; set; }
        public string ArrivalAddress { get; set; }
        public string Notes { get; set; }
        public bool IsVip { get; set; }
        public int Capacity { get; set; }
        public int? StatusID { get; set; }
    }

    /*EntityMap Oluştur*/
    public class RequestTransfer_Configuration : IEntityTypeConfiguration<RequestTransfer>
    {
        public void Configure(EntityTypeBuilder<RequestTransfer> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();
            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("RequestTransfer");
            // Navigate Properties
        }
    }
}

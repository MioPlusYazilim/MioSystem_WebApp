using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities.Modules.Request
{
    public class Request : BaseEntity
    {
        public Request()
        {
        }

        public string RequestNo { get; set; }
        public DateTime RequestDate { get; set; }
        public string RequestTime { get; set; }
        public int RequestCityID { get; set; }
        public string RequestPnr { get; set; }
        public string RequestTitle { get; set; }
        public int CustomerID { get; set; }
        public int EmployeeID { get; set; }
        public int StatusID { get; set; }
        public string Notes { get; set; }
        public bool FState { get; set; }
    }

    /*EntityMap Oluştur*/
    public class Request_Configuration : IEntityTypeConfiguration<Request>
    {
        public void Configure(EntityTypeBuilder<Request> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();

            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("Request");
            // Navigate Properties
        }
    }
}


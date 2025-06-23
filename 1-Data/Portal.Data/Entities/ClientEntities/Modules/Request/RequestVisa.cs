using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities.Modules.Request
{
    public class RequestVisa : BaseEntity
    {
        public RequestVisa()
        {
        }

        public string RequestID { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public int CountryID { get; set; }
        public int VisaTypeID { get; set; }
        public int SendInfoTypeID { get; set; }
        public bool IsExpress { get; set; }
        public string Notes { get; set; }
        public int StatusID { get; set; }
    }

    /*EntityMap Oluştur*/
    public class RequestVisa_Configuration : IEntityTypeConfiguration<RequestVisa>
    {
        public void Configure(EntityTypeBuilder<RequestVisa> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();
            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("RequestVisa");
            // Navigate Properties
        }
    }
}

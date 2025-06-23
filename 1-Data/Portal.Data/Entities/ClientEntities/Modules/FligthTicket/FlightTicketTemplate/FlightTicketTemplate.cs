using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class FlightTicketTemplate : BaseEntity
    {
        public FlightTicketTemplate()
        {
        }

        public int FlightLineTypeID { get; set; }
        public string AirLineCode { get; set; }
        public string TemplateCode { get; set; }
        public string Template { get; set; }
        public bool IsActive { get; set; }
        public int CompanyID { get; set; }
        public bool FState { get; set; }
    }

    /*EntityMap Oluştur*/
    public class FlightTicketTemplate_Configuration : IEntityTypeConfiguration<FlightTicketTemplate>
    {
        public void Configure(EntityTypeBuilder<FlightTicketTemplate> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();
            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("FlightTicketTemplate");
            // Navigate Properties
        }
    }
}



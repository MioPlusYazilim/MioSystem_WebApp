using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class InvoiceTransport : BaseEntity
    {
        public InvoiceTransport()
        {
        }

        public int InvoiceID { get; set; }
        public DateTime? TransportDate { get; set; }
        public string TransportTime { get; set; }
        public string TransportCompany { get; set; }
        public string TransportCompanyTaxOffice { get; set; }
        public string TransportCompanyTaxNumber { get; set; }
        public string TruckNumber { get; set; }
        public string TrailerNumber { get; set; }
        public string DriverName { get; set; }
        public string DriverIDNumber { get; set; }
    }

    /*EntityMap Oluştur*/
    public class InvoiceTransport_Configuration : IEntityTypeConfiguration<InvoiceTransport>
    {
        public void Configure(EntityTypeBuilder<InvoiceTransport> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();

            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("InvoiceTransport");
            // Navigate Properties
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Portal.Data.Entities.GlobalEntities
{
    public class FlightCabinType : BaseEntity
    {
        public FlightCabinType()
        {
        }

        public string LanguageCode { get; set; }
        public string FieldValue { get; set; }
        public string FieldName { get; set; }
        public string SupplierCode { get; set; }
        public bool IsSubCabin { get; set; }
        public int TicketSupplierID { get; set; }
    }

    /*EntityMap Oluştur*/
    public class FlightCabinType_Configuration : IEntityTypeConfiguration<FlightCabinType>
    {
        public void Configure(EntityTypeBuilder<FlightCabinType> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").IsRequired();
            builder.Property(t => t.LanguageCode).HasColumnName("LanguageCode").IsRequired().HasMaxLength(5);
            builder.Property(t => t.FieldValue).HasColumnName("FieldValue").IsRequired().HasMaxLength(50);
            builder.Property(t => t.FieldName).HasColumnName("FieldName").IsRequired().HasMaxLength(100);
            builder.Property(t => t.SupplierCode).HasColumnName("SupplierCode").IsRequired().HasMaxLength(10);
            builder.Property(t => t.IsSubCabin).HasColumnName("IsSubCabin").IsRequired();
            builder.Property(t => t.TicketSupplierID).HasColumnName("TicketSupplierID").IsRequired();

            builder.Ignore(i => i.Deleted);
            builder.ToTable("FlightCabinType");
            // Navigate Properties
        }
    }
}

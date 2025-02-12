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
        public int FlightSupplierID { get; set; }
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
            builder.ToTable("FlightCabinType");
            // Navigate Properties
        }
    }
}

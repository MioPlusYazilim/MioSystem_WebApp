using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.GlobalEntities
{
    public class FlightSeatType : BaseEntity
    {
        public FlightSeatType()
        {
        }
        public string LanguageCode { get; set; }
        public string FieldValue { get; set; }
        public string FieldName { get; set; }
        public int FlightSupplierID { get; set; }
    }

    /*EntityMap Oluştur*/
    public class FlightSeatType_Configuration : IEntityTypeConfiguration<FlightSeatType>
    {
        public void Configure(EntityTypeBuilder<FlightSeatType> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);
            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").IsRequired();
            builder.ToTable("FlightSeatType");
            // Navigate Properties
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.GlobalEntities
{
    public class FlightSupplierType : BaseEntity
    {
        public FlightSupplierType()
        {
        }

        public string LanguageCode { get; set; }
        public string FieldValue { get; set; }
        public string FieldName { get; set; }
    }

    /*EntityMap Oluştur*/
    public class FlightSupplierType_Configuration : IEntityTypeConfiguration<FlightSupplierType>
    {
        public void Configure(EntityTypeBuilder<FlightSupplierType> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").IsRequired();
            builder.ToTable("FlightSupplierType");
            // Navigate Properties
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.GlobalEntities
{
    public class ShipCabinType : BaseEntity
    {
        public ShipCabinType()
        {
        }
        public string LanguageCode { get; set; }
        public string FieldValue { get; set; }
        public string FieldName { get; set; }
    }

    /*EntityMap Oluştur*/
    public class ShipCabinType_Configuration : IEntityTypeConfiguration<ShipCabinType>
    {
        public void Configure(EntityTypeBuilder<ShipCabinType> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);
            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").IsRequired();
            builder.ToTable("ShipCabinType");
            // Navigate Properties
        }
    }
}
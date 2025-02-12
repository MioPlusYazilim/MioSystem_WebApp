using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.GlobalEntities
{
    public class FlightStatusType : BaseEntity
    {
        public FlightStatusType()
        {
        }
        public string LanguageCode { get; set; }
        public string FieldValue { get; set; }
        public string FieldName { get; set; }
        public string ColorValue { get; set; }
    }

    /*EntityMap Oluştur*/
    public class FlightStatusType_Configuration : IEntityTypeConfiguration<FlightStatusType>
    {
        public void Configure(EntityTypeBuilder<FlightStatusType> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);
            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").IsRequired();
            builder.ToTable("FlightStatusType");
            // Navigate Properties
        }
    }
}

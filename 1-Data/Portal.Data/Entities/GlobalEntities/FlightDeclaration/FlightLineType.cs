using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.GlobalEntities
{
    public class FlightLineType : BaseEntity
    {
        public FlightLineType()
        {
        }
        public string LanguageCode { get; set; }
        public string FieldValue { get; set; }
        public string FieldName { get; set; }
        public string GroupValue { get; set; }
    }

    /*EntityMap Oluştur*/
    public class FlightLineType_Configuration : IEntityTypeConfiguration<FlightLineType>
    {
        public void Configure(EntityTypeBuilder<FlightLineType> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);
            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").IsRequired();
            builder.ToTable("FlightLineType");
            // Navigate Properties
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Portal.Data.Entities.GlobalEntities
{
    public class AirLine : BaseEntity
    {
        public AirLine()
        {
        }

        public string LanguageCode { get; set; }
        public string FieldValue { get; set; }
        public string FieldName { get; set; }
        public string FormNo { get; set; }
        public string CountryCode { get; set; }
    }

    /*EntityMap Oluştur*/
    public class AirLine_Configuration : IEntityTypeConfiguration<AirLine>
    {
        public void Configure(EntityTypeBuilder<AirLine> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);
            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").IsRequired();
            builder.ToTable("AirLine");
            // Navigate Properties
        }
    }
}
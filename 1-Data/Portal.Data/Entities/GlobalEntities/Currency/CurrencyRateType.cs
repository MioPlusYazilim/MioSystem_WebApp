using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.GlobalEntities
{
    public class CurrencyRateType : BaseEntity
    {
        public CurrencyRateType()
        {
        }

        public string LanguageCode { get; set; }
        public string FieldValue { get; set; }
        public string FieldName { get; set; }
    }

    /*EntityMap Oluştur*/
    public class CurrencyRateType_Configuration : IEntityTypeConfiguration<CurrencyRateType>
    {
        public void Configure(EntityTypeBuilder<CurrencyRateType> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").IsRequired();
            builder.ToTable("CurrencyRateType");
            // Navigate Properties
        }
    }
}
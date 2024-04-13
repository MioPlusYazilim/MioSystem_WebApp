using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.GlobalEntities
{
    public class Currency : BaseEntity
    {
        public Currency()
        {
        }

        public string LanguageCode { get; set; }
        public string FieldValue { get; set; }
        public string FieldName { get; set; }
        public string Symbol { get; set; }
        public string Peny { get; set; }
    }

    /*EntityMap Oluştur*/
    public class Currency_Configuration : IEntityTypeConfiguration<Currency>
    {
        public void Configure(EntityTypeBuilder<Currency> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").IsRequired();
            builder.Property(t => t.LanguageCode).HasColumnName("LanguageCode").IsRequired().HasMaxLength(5);
            builder.Property(t => t.FieldValue).HasColumnName("FieldValue").IsRequired().HasMaxLength(3);
            builder.Property(t => t.FieldName).HasColumnName("FieldName").IsRequired().HasMaxLength(50);
            builder.Property(t => t.Symbol).HasColumnName("Symbol").HasMaxLength(5);
            builder.Property(t => t.Peny).HasColumnName("Peny").HasMaxLength(5);

            builder.Ignore(i => i.Deleted);
            builder.ToTable("Currency");
            // Navigate Properties
        }
    }
}
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.GlobalEntities
{
    public class InvoiceOptionType : BaseEntity
    {
        public InvoiceOptionType()
        {
        }

        public string LanguageCode { get; set; }
        public string FieldValue { get; set; }
        public string FieldName { get; set; }
    }

    /*EntityMap Oluştur*/
    public class InvoiceOptionType_Configuration : IEntityTypeConfiguration<InvoiceOptionType>
    {
        public void Configure(EntityTypeBuilder<InvoiceOptionType> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").IsRequired();
            builder.ToTable("InvoiceOptionType");
            // Navigate Properties
        }
    }
}

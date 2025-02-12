using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.GlobalEntities
{
    public class InvoiceTransactionType : BaseEntity
    {
        public InvoiceTransactionType()
        {
        }

        public string LanguageCode { get; set; }
        public string FieldValue { get; set; }
        public string FieldName { get; set; }
        public bool IsDebit { get; set; }
    }

    /*EntityMap Oluştur*/
    public class InvoiceTransactionType_Configuration : IEntityTypeConfiguration<InvoiceTransactionType>
    {
        public void Configure(EntityTypeBuilder<InvoiceTransactionType> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").IsRequired();
            builder.ToTable("InvoiceTransactionType");
            // Navigate Properties
        }
    }
}

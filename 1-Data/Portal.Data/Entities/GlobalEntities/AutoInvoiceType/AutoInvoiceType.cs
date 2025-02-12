using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Portal.Data.Entities.GlobalEntities
{
    public class AutoInvoiceType : BaseEntity
    {
        public AutoInvoiceType()
        {
        }
        public string LanguageCode { get; set; }
        public string FieldValue { get; set; }
        public string FieldName { get; set; }
    }

    /*EntityMap Oluştur*/
    public class AutoInvoiceType_Configuration : IEntityTypeConfiguration<AutoInvoiceType>
    {
        public void Configure(EntityTypeBuilder<AutoInvoiceType> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);
            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").IsRequired();
            builder.ToTable("AutoInvoiceType");
            // Navigate Properties
        }
    }
}

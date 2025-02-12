using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.GlobalEntities
{
    public class PaymentTermType : BaseEntity
    {
        public PaymentTermType()
        {
        }

        public string LanguageCode { get; set; }
        public string FieldValue { get; set; }
        public string FieldName { get; set; }
    }

    /*EntityMap Oluştur*/
    public class PaymentTermType_Configuration : IEntityTypeConfiguration<PaymentTermType>
    {
        public void Configure(EntityTypeBuilder<PaymentTermType> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").IsRequired();
            builder.ToTable("PaymentTermType");
            // Navigate Properties
        }
    }
}

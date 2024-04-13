using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.GlobalEntities
{
    public class TicketStatusType : BaseEntity
    {
        public TicketStatusType()
        {
        }

        public string LanguageCode { get; set; }
        public string FieldValue { get; set; }
        public string FieldName { get; set; }
        public string ColorValue { get; set; }
    }

    /*EntityMap Oluştur*/
    public class TicketStatusType_Configuration : IEntityTypeConfiguration<TicketStatusType>
    {
        public void Configure(EntityTypeBuilder<TicketStatusType> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").IsRequired();
            builder.Property(t => t.LanguageCode).HasColumnName("LanguageCode").IsRequired().HasMaxLength(5);
            builder.Property(t => t.FieldValue).HasColumnName("FieldValue").IsRequired().HasMaxLength(20);
            builder.Property(t => t.FieldName).HasColumnName("FieldName").IsRequired().HasMaxLength(100);
            builder.Property(t => t.ColorValue).HasColumnName("ColorValue").IsRequired().HasMaxLength(20);

            builder.Ignore(i => i.Deleted);
            builder.ToTable("TicketStatusType");
            // Navigate Properties
        }
    }
}
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.GlobalEntities
{
    public class SystemUIElements : BaseEntity
    {
        public SystemUIElements()
        {
        }

        public string LanguageCode { get; set; }
        public string FieldValue { get; set; }
        public string FieldName { get; set; }
    }

    /*EntityMap Oluştur*/
    public class SystemUIElements_Configuration : IEntityTypeConfiguration<SystemUIElements>
    {
        public void Configure(EntityTypeBuilder<SystemUIElements> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);
            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").IsRequired();
            builder.ToTable("SystemUIElements");
            // Navigate Properties
        }
    }
}
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.GlobalEntities
{
    public class PassportType : BaseEntity
    {
        public PassportType()
        {
        }

        public string LanguageCode { get; set; }
        public string FieldValue { get; set; }
        public string FieldName { get; set; }
    }

    /*EntityMap Oluştur*/
    public class PassportType_Configuration : IEntityTypeConfiguration<PassportType>
    {
        public void Configure(EntityTypeBuilder<PassportType> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").IsRequired();
            builder.ToTable("PassportType");
            // Navigate Properties
        }
    }
}

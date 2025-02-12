using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Portal.Data.Entities.GlobalEntities
{
    public class AutoServiceType : BaseEntity
    {
        public AutoServiceType()
        {
        }

        public string LanguageCode { get; set; }
        public string FieldValue { get; set; }
        public string FieldName { get; set; }
    }

    /*EntityMap Oluştur*/
    public class AutoServiceType_Configuration : IEntityTypeConfiguration<AutoServiceType>
    {
        public void Configure(EntityTypeBuilder<AutoServiceType> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").IsRequired();
            builder.ToTable("AutoServiceType");
            // Navigate Properties
        }
    }
}

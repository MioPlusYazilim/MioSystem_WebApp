using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Portal.Data.Entities.GlobalEntities
{
    public class CorporateType : BaseEntity
    {
        public CorporateType()
        {
        }
        public string LanguageCode { get; set; }
        public string FieldValue { get; set; }
        public string FieldName { get; set; }
    }

    /*EntityMap Oluştur*/
    public class CorporateType_Configuration : IEntityTypeConfiguration<CorporateType>
    {
        public void Configure(EntityTypeBuilder<CorporateType> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);
            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").IsRequired();
            builder.ToTable("CorporateType");
            // Navigate Properties
        }
    }
}

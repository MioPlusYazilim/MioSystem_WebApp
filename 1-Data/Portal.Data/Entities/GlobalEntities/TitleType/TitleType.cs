using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.GlobalEntities
{
    public class TitleType : BaseEntity
    {
        public TitleType()
        {
        }
        public string LanguageCode { get; set; }
        public string FieldValue { get; set; }
        public string FieldName { get; set; }
    }

    /*EntityMap Oluştur*/
    public class TitleType_Configuration : IEntityTypeConfiguration<TitleType>
    {
        public void Configure(EntityTypeBuilder<TitleType> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);
            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").IsRequired();
            builder.ToTable("TitleType");
            // Navigate Properties
        }
    }
}
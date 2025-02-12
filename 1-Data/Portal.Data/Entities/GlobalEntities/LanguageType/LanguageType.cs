using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.GlobalEntities
{
    public class LanguageType : BaseEntity
    {
        public LanguageType()
        {
        }
        public string Code { get; set; }
        public string CodeName { get; set; }
    }

    /*EntityMap Oluştur*/
    public class LanguageType_Configuration : IEntityTypeConfiguration<LanguageType>
    {
        public void Configure(EntityTypeBuilder<LanguageType> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);
            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").IsRequired();
            builder.ToTable("LanguageType");
            // Navigate Properties
        }
    }
}

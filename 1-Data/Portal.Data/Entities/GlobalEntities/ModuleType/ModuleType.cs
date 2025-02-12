using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.GlobalEntities
{
    public class ModuleType : BaseEntity
    {
        public ModuleType()
        {
        }

        public string LanguageCode { get; set; }
        public string FieldValue { get; set; }
        public string FieldName { get; set; }
    }

    /*EntityMap Oluştur*/
    public class ModuleType_Configuration : IEntityTypeConfiguration<ModuleType>
    {
        public void Configure(EntityTypeBuilder<ModuleType> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").IsRequired();
            builder.ToTable("ModuleType");
            // Navigate Properties
        }
    }
}

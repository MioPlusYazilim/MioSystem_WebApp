using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.GlobalEntities
{
    public class GlobalTranslation : BaseEntity
    {
        public GlobalTranslation()
        {
        }

        public int GlobalDeclarationID { get; set; }

        public string LanguageCode { get; set; }
        public string FieldValue { get; set; }
        public string FieldName { get; set; }
        public string FieldReport { get; set; }
    }

    /*EntityMap Oluştur*/
    public class GlobalTranslation_Configuration : IEntityTypeConfiguration<GlobalTranslation>
    {
        public void Configure(EntityTypeBuilder<GlobalTranslation> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").IsRequired();
            builder.ToTable("GlobalTranslation");
            // Navigate Properties
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.GlobalEntities
{
    public class DeclarationType : BaseEntity
    {
        public DeclarationType()
        {
        }
        public string LanguageCode { get; set; }
        public string FieldValue { get; set; }
        public string FieldName { get; set; }
    }

    /*EntityMap Oluştur*/
    public class DeclarationType_Configuration : IEntityTypeConfiguration<DeclarationType>
    {
        public void Configure(EntityTypeBuilder<DeclarationType> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);
            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").IsRequired();
            builder.ToTable("DeclarationType");
            // Navigate Properties
        }
    }
}

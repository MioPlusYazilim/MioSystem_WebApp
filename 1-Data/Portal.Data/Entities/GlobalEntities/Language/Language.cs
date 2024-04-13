using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.GlobalEntities
{
    public class Language : BaseEntity
    {
        public Language()
        {
        }

        public string Code { get; set; }
        public string CodeName { get; set; }
    }

    /*EntityMap Oluştur*/
    public class Language_Configuration : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();
            builder.Property(t => t.Code).HasColumnName("Code").IsRequired().HasMaxLength(10);
            builder.Property(t => t.CodeName).HasColumnName("CodeName").IsRequired().HasMaxLength(50);

            builder.Ignore(i => i.Deleted);
            builder.ToTable("Language");
            // Navigate Properties
        }
    }
}

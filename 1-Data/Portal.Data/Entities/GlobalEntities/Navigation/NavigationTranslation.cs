using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.GlobalEntities
{
    public class NavigationTranslation : BaseEntity
    {
        public NavigationTranslation()
        {
        }

        public int ParentID { get; set; }
        public string LanguageCode { get; set; }
        public string MenuName { get; set; }
        public string FormCaption { get; set; }
        public string EditFormCaption { get; set; }
    }

    /*EntityMap Oluştur*/
    public class NavigationTranslation_Configuration : IEntityTypeConfiguration<NavigationTranslation>
    {
        public void Configure(EntityTypeBuilder<NavigationTranslation> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();
            builder.Property(t => t.ParentID).HasColumnName("ParentID").IsRequired();
            builder.Property(t => t.LanguageCode).HasColumnName("LanguageCode").IsRequired().HasMaxLength(10);
            builder.Property(t => t.MenuName).HasColumnName("MenuName").IsRequired().HasMaxLength(250);
            builder.Property(t => t.FormCaption).HasColumnName("FormCaption").HasMaxLength(250);
            builder.Property(t => t.EditFormCaption).HasColumnName("EditFormCaption").HasMaxLength(250);


            builder.ToTable("NavigationTranslation");
            // Navigate Properties
        }
    }
}
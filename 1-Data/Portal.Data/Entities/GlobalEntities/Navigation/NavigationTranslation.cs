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

            builder.ToTable("NavigationTranslation");
            // Navigate Properties
        }
    }
}
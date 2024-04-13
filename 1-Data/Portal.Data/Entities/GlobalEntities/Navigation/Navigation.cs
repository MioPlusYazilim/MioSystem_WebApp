using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.GlobalEntities
{
    public class Navigation : BaseEntity
    {
        public Navigation()
        {
        }

        public int ModulID { get; set; }
        public int ParentID { get; set; }
        public int MenuLevel { get; set; }
        public int MenuOrder { get; set; }
        public int MenuFormType { get; set; }
        public bool MenuActive { get; set; }
        public string MenuIconType { get; set; }
        public string MenuIcon { get; set; }
        public string MenuLink { get; set; }
        public int MenuTag { get; set; }
        public int? MenuCardType { get; set; }
        public bool IsInternational { get; set; }
        public string EditFormName { get; set; }
        public string ListFormName { get; set; }
        public string EditFormPath { get; set; }
        public string ListFormPath { get; set; }
        public string MenuPath { get; set; }

    }

    /*EntityMap Oluştur*/
    public class Navigation_Configuration : IEntityTypeConfiguration<Navigation>
    {
        public void Configure(EntityTypeBuilder<Navigation> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();
            builder.Property(t => t.ModulID).HasColumnName("ModulID").IsRequired();
            builder.Property(t => t.ParentID).HasColumnName("ParentID").IsRequired();
            builder.Property(t => t.MenuLevel).HasColumnName("MenuLevel").IsRequired();
            builder.Property(t => t.MenuOrder).HasColumnName("MenuOrder").IsRequired();
            builder.Property(t => t.MenuFormType).HasColumnName("MenuFormType").IsRequired();
            builder.Property(t => t.MenuActive).HasColumnName("MenuActive").IsRequired();
            builder.Property(t => t.MenuIconType).HasColumnName("MenuIconType").HasMaxLength(100);
            builder.Property(t => t.MenuIcon).HasColumnName("MenuIcon").HasMaxLength(100);
            builder.Property(t => t.MenuLink).HasColumnName("MenuLink").HasMaxLength(250);
            builder.Property(t => t.MenuTag).HasColumnName("MenuTag").IsRequired();
            builder.Property(t => t.MenuCardType).HasColumnName("MenuCardType");
            builder.Property(t => t.IsInternational).HasColumnName("IsInternational").IsRequired();
            builder.Property(t => t.EditFormName).HasColumnName("EditFormName").HasMaxLength(250);
            builder.Property(t => t.ListFormName).HasColumnName("ListFormName").HasMaxLength(250);
            builder.Property(t => t.EditFormPath).HasColumnName("EditFormPath").HasMaxLength(250);
            builder.Property(t => t.ListFormPath).HasColumnName("ListFormPath").HasMaxLength(250);
            builder.Property(t => t.MenuPath).HasColumnName("MenuPath").HasMaxLength(250);


            builder.ToTable("Navigation");
            // Navigate Properties
        }
    }
}
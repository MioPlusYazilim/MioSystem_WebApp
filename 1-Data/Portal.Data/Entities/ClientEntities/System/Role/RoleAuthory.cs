using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class RoleAuthory : BaseEntity
    {
        public RoleAuthory()
        {
        }

        public int RoleID { get; set; }
        public int MenuID { get; set; }
        public bool AllowList { get; set; }
        public bool AllowNew { get; set; }
        public bool AllowEdit { get; set; }
        public bool AllowDelete { get; set; }
        public bool AllowPrint { get; set; }
        public string ReportIDs { get; set; }
        public virtual Role role { get; set; }
    }

    /*EntityMap Oluştur*/
    public class RoleAuthory_Configuration : IEntityTypeConfiguration<RoleAuthory>
    {
        public void Configure(EntityTypeBuilder<RoleAuthory> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();
            builder.Property(t => t.RoleID).HasColumnName("RoleID").IsRequired();
            builder.Property(t => t.MenuID).HasColumnName("MenuID").IsRequired();
            builder.Property(t => t.AllowList).HasColumnName("AllowList").IsRequired();
            builder.Property(t => t.AllowNew).HasColumnName("AllowNew").IsRequired();
            builder.Property(t => t.AllowEdit).HasColumnName("AllowEdit").IsRequired();
            builder.Property(t => t.AllowDelete).HasColumnName("AllowDelete").IsRequired();
            builder.Property(t => t.AllowPrint).HasColumnName("AllowPrint").IsRequired();
            builder.Property(t => t.ReportIDs).HasColumnName("ReportIDs").HasMaxLength(4000);

            builder.Ignore(i => i.Deleted);
            builder.ToTable("RoleAuthory");
            // Navigate Properties
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace Portal.Data.Entities.ClientEntities
{
    public class Role : BaseEntity
    {
        public Role()
        {
            authories = new List<RoleAuthory>();
        }

        public string RoleName { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public int CompanyID { get; set; }
        public virtual List<RoleAuthory> authories { get; set; }
    }

    /*EntityMap Oluştur*/
    public class Role_Configuration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();
            builder.Property(t => t.RoleName).HasColumnName("RoleName").IsRequired().HasMaxLength(100);
            builder.Property(t => t.Description).HasColumnName("Description").HasMaxLength(500);
            builder.Property(t => t.Active).HasColumnName("Active").IsRequired();
            builder.Property(t => t.CompanyID).HasColumnName("CompanyID").IsRequired();
            builder.Property(t => t.Deleted).HasColumnName("Deleted").IsRequired();

            builder.Ignore(i => i.Deleted);
            // Navigate Properties
            builder.HasMany(s => s.authories).WithOne(ad => ad.role).HasForeignKey(fk => fk.RoleID).OnDelete(DeleteBehavior.Cascade);
        }
    }
}


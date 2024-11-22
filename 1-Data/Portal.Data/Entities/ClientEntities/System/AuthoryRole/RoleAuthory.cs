using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace Portal.Data.Entities.ClientEntities
{
    public class RoleAuthory : BaseEntity
    {
        public RoleAuthory()
        {
            permissions = new List<RoleAuthoryPermission>();
        }

        public string RoleName { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public int CompanyID { get; set; }
        public virtual List<RoleAuthoryPermission> permissions { get; set; }
    }

    /*EntityMap Oluştur*/
    public class Role_Configuration : IEntityTypeConfiguration<RoleAuthory>
    {
        public void Configure(EntityTypeBuilder<RoleAuthory> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();

            builder.Ignore(i => i.Deleted);
            builder.ToTable("RoleAuthory");
            // Navigate Properties
            builder.HasMany(s => s.permissions).WithOne(ad => ad.role).HasForeignKey(fk => fk.RoleID).OnDelete(DeleteBehavior.Cascade);
           
        }
    }
}


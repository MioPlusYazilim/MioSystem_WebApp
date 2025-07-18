﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class RoleAuthoryPermission : BaseEntity
    {
        public RoleAuthoryPermission()
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
        public int ListTypeID { get; set; }
        public virtual RoleAuthory role { get; set; }
    }

    /*EntityMap Oluştur*/
    public class RoleAuthory_Configuration : IEntityTypeConfiguration<RoleAuthoryPermission>
    {
        public void Configure(EntityTypeBuilder<RoleAuthoryPermission> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();

            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("RoleAuthoryPermission");
            // Navigate Properties
        }
    }
}

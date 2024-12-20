﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.GlobalEntities
{
    public class Navigation : IDisposable
    {
        public Navigation()
        {
        }
        public int ID { get; set; }
        public int ModulID { get; set; } = 0;
        public int ParentID { get; set; } = 0;
        public int MenuLevel { get; set; } = 0;
        public int MenuOrder { get; set; } = 0;
        public int MenuFormType { get; set; } = 0;
        public bool MenuActive { get; set; } = false;
        public string MenuIconType { get; set; } = string.Empty;
        public string MenuIcon { get; set; } = string.Empty;
        public string? MenuLink { get; set; } = string.Empty;
        public int MenuTag { get; set; } = 0;
        public string EditFormName { get; set; } = string.Empty;
        public string EditFormPath { get; set; } = string.Empty;
        public string MenuPath { get; set; } = string.Empty;
        public string? ListSourceName { get; set; } = string.Empty;
        public int ListSourceType { get; set; } = 0; // 0: View 1: StoredProc 2: Entity

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
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

            builder.ToTable("Navigation");
            // Navigate Properties
        }
    }
}
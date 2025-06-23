using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class ReportFile : BaseEntity
    {
        public ReportFile()
        {
        }

        public int? RunType { get; set; }
        public int? FormName { get; set; }
        public string ReportName { get; set; }
        public string StoredProcedure { get; set; }
        public int? OrderBy { get; set; }
        public string ReportStream { get; set; }
        public int? TypeID { get; set; }
        public int? IconIndex { get; set; }
        public string IconPath { get; set; }
        public string PageColor { get; set; }
        public string PageLink { get; set; }
        public string PageHeight { get; set; }
        public int? Version { get; set; }
        public int? ModuleID { get; set; }
        public bool IsSystem { get; set; }
        public bool IsActive { get; set; }
        public int? CompanyID { get; set; }
        public bool FState { get; set; }
    }

    /*EntityMap Oluştur*/
    public class ReportFile_Configuration : IEntityTypeConfiguration<ReportFile>
    {
        public void Configure(EntityTypeBuilder<ReportFile> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();

            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("ReportFile");
            // Navigate Properties
        }
    }
}


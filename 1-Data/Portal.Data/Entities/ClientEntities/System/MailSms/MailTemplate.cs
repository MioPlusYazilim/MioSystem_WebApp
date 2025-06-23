using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class MailTemplate : BaseEntity
    {
        public MailTemplate()
        {
        }

        public string Code { get; set; }
        public string Template { get; set; }
        public int TransactionStatusID { get; set; }
        public int SourceID { get; set; }
        public bool IsActive { get; set; }
        public int SettingID { get; set; }
        public int ModuleID { get; set; }
        public int CompanyID { get; set; }
        public bool FState { get; set; }
    }

    /*EntityMap Oluştur*/
    public class MailTemplate_Configuration : IEntityTypeConfiguration<MailTemplate>
    {
        public void Configure(EntityTypeBuilder<MailTemplate> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();

            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("MailTemplate");
            // Navigate Properties
        }
    }
}

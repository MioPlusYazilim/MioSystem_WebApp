using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class MailSetting : BaseEntity
    {
        public MailSetting()
        {
        }

        public string MailSender { get; set; }
        public string MailTitle { get; set; }
        public string MailServer { get; set; }
        public string MailUser { get; set; }
        public string MailPassword { get; set; }
        public int IncomingPort { get; set; }
        public int OutgoingPort { get; set; }
        public int DelayTime { get; set; }
        public bool IsSSL { get; set; }
        public int SourceID { get; set; }
        public bool IsActive { get; set; }
        public int CompanyID { get; set; }
        public bool FState { get; set; }
    }

    /*EntityMap Oluştur*/
    public class MailSetting_Configuration : IEntityTypeConfiguration<MailSetting>
    {
        public void Configure(EntityTypeBuilder<MailSetting> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();

            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("MailSetting");
            // Navigate Properties
        }
    }
}



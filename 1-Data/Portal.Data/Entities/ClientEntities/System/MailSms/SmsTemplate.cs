using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class SmsTemplate : BaseEntity
    {
        public SmsTemplate()
        {
        }

        public string Code { get; set; }
        public string Template { get; set; }
        public int TransactionStatusID { get; set; }
        public int SettingID { get; set; }
        public int SourceID { get; set; }
        public bool IsActive { get; set; }
        public int ModuleID { get; set; }
        public int CompanyID { get; set; }
        public bool FState { get; set; }
    }

    /*EntityMap Oluştur*/
    public class SmsTemplate_Configuration : IEntityTypeConfiguration<SmsTemplate>
    {
        public void Configure(EntityTypeBuilder<SmsTemplate> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();

            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("SmsTemplate");
            // Navigate Properties
        }
    }
}
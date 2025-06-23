using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class MailingSendList : BaseEntity
    {
        public MailingSendList()
        {
        }

        public int MailSettingID { get; set; }
        public bool IsSend { get; set; }
        public DateTime? SendDate { get; set; }
        public DateTime? SendTimeOut { get; set; }
        public string ToMail { get; set; }
        public string BccMail { get; set; }
        public string MailContent { get; set; }
        public int MailSpecialID { get; set; }
        public string ServerResponse { get; set; }
        public int MasterID { get; set; }
        public int DetailID { get; set; }
        public int? TransactionGroupID { get; set; }
        public int TransactionStatusID { get; set; }
        public int? TrialCount { get; set; }
        public int SourceID { get; set; }
        public int? ModuleID { get; set; }
        public int CompanyID { get; set; }
        public bool FState { get; set; }
    }

    /*EntityMap Oluştur*/
    public class MailingSendList_Configuration : IEntityTypeConfiguration<MailingSendList>
    {
        public void Configure(EntityTypeBuilder<MailingSendList> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();

            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("MailingSendList");
            // Navigate Properties
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class SmsSendList : BaseEntity
    {
        public SmsSendList()
        {
        }

        public int SmsSettingID { get; set; }
        public bool IsSend { get; set; }
        public DateTime? SendDate { get; set; }
        public DateTime? SendTimeOut { get; set; }
        public string ToSms { get; set; }
        public string Sender { get; set; }
        public string SmsContent { get; set; }
        public string SmsSpecialID { get; set; }
        public string SmsServerResponse { get; set; }
        public int MasterID { get; set; }
        public int DetailID { get; set; }
        public int? TransactionGroupID { get; set; }
        public int? TransactionStatusID { get; set; }
        public int? TrialCount { get; set; }
        public int SourceID { get; set; }
        public int? ModuleID { get; set; }
        public int CompanyID { get; set; }
        public bool FState { get; set; }
    }

    /*EntityMap Oluştur*/
    public class SmsSendList_Configuration : IEntityTypeConfiguration<SmsSendList>
    {
        public void Configure(EntityTypeBuilder<SmsSendList> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();

            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("SmsSendList");
            // Navigate Properties
        }
    }
}

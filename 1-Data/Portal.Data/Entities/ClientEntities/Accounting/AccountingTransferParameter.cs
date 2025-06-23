using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class AccountingTransferParameter : BaseEntity
    {
        public AccountingTransferParameter()
        {
        }

        public int? AccountingSystemID { get; set; }
        public string ServerName { get; set; }
        public string DataBaseName { get; set; }
        public string UserName { get; set; }
        public string UserPassWord { get; set; }
        public string LoginName { get; set; }
        public string LoginPassWord { get; set; }
        public string VersionInfo { get; set; }
        public string TransferModel { get; set; }
        public bool IsProjeCreate { get; set; }
        public bool IsCostCenterCreate { get; set; }
        public bool IsReferanceCreate { get; set; }
        public bool IsCheckDocumant { get; set; }
        public int UserID { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public string CompanyCode { get; set; }
        public string BranchCode { get; set; }
        public bool IsActive { get; set; }
        public int CompanyID { get; set; }
        public bool FState { get; set; }
    }

    /*EntityMap Oluştur*/
    public class AccountingTransferParameter_Configuration : IEntityTypeConfiguration<AccountingTransferParameter>
    {
        public void Configure(EntityTypeBuilder<AccountingTransferParameter> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();

            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("AccountingTransferParameter");
            // Navigate Properties
        }
    }
}



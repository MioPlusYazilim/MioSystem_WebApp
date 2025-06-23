using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class IntegratorSystemParameter : BaseEntity
    {
        public IntegratorSystemParameter()
        {
        }

        public int IntegratorSystemID { get; set; }
        public string AgentCode { get; set; }
        public string LoginName { get; set; }
        public string LoginPassword { get; set; }
        public string VersionInfo { get; set; }
        public string TransferModel { get; set; }
        public DateTime? BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        public long? ActiveCompanyID { get; set; }
        public long? ActiveBranchID { get; set; }
        public string ActiveBranchCode { get; set; }
        public string MoneyCaseCode { get; set; }
        public string TemplateCode { get; set; }
        public bool IsActive { get; set; }
        public int CompanyID { get; set; }
        public bool FState { get; set; }
    }

    /*EntityMap Oluştur*/
    public class IntegratorSystemParameter_Configuration : IEntityTypeConfiguration<IntegratorSystemParameter>
    {
        public void Configure(EntityTypeBuilder<IntegratorSystemParameter> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();

            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("IntegratorSystemParameter");
            // Navigate Properties
        }
    }
}


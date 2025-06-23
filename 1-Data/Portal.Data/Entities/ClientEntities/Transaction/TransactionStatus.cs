using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class TransactionStatus : BaseEntity
    {
        public TransactionStatus()
        {
        }

        public string ColorCode { get; set; }
        public bool IsCancel { get; set; }
        public bool IsArchive { get; set; }
        public bool IsConfirmed { get; set; }
        public bool IsBegin { get; set; }
        public bool IsInvoice { get; set; }
        public int ModuleID { get; set; }
        public string FieldValue { get; set; }
        public int CompanyID { get; set; }
        public bool FState { get; set; }
    }

    /*EntityMap Oluştur*/
    public class TransactionStatus_Configuration : IEntityTypeConfiguration<TransactionStatus>
    {
        public void Configure(EntityTypeBuilder<TransactionStatus> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();
            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("TransactionStatus");
            // Navigate Properties
        }
    }
}
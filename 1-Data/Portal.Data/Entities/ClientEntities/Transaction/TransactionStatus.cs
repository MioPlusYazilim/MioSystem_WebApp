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
            builder.Property(t => t.ColorCode).HasColumnName("ColorCode").HasMaxLength(40);
            builder.Property(t => t.IsCancel).HasColumnName("IsCancel").IsRequired();
            builder.Property(t => t.IsArchive).HasColumnName("IsArchive").IsRequired();
            builder.Property(t => t.IsConfirmed).HasColumnName("IsConfirmed").IsRequired();
            builder.Property(t => t.IsBegin).HasColumnName("IsBegin").IsRequired();
            builder.Property(t => t.IsInvoice).HasColumnName("IsInvoice").IsRequired();
            builder.Property(t => t.ModuleID).HasColumnName("ModuleID").IsRequired();
            builder.Property(t => t.FieldValue).HasColumnName("FieldValue").IsRequired().HasMaxLength(250);
            builder.Property(t => t.CompanyID).HasColumnName("CompanyID").IsRequired();
            builder.Property(t => t.Deleted).HasColumnName("Deleted").IsRequired();
            builder.Property(t => t.FState).HasColumnName("FState").IsRequired();

            builder.Ignore(i => i.Deleted);
            builder.ToTable("TransactionStatus");
            // Navigate Properties
        }
    }
}
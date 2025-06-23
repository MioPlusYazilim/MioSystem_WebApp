using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class ParseParameter : BaseEntity
    {
        public ParseParameter()
        {
        }

        public int SupplierID { get; set; }
        public int LineTypeID { get; set; }
        public int OtherLineTypeID { get; set; }
        public bool IsCurrency { get; set; }
        public bool IsRefund { get; set; }
        public bool IsCancel { get; set; }
        public bool IsReservation { get; set; }
        public string FilePath { get; set; }
        public string ErrorFilePath { get; set; }
        public string LogFilePath { get; set; }
        public string BackupFilePath { get; set; }
        public int WaitTime { get; set; }
        public int SupplierCustomerID { get; set; }
        public int ModuleID { get; set; }
        public int CompanyID { get; set; }
        public bool FState { get; set; }
    }

    /*EntityMap Oluştur*/
    public class ParseParameter_Configuration : IEntityTypeConfiguration<ParseParameter>
    {
        public void Configure(EntityTypeBuilder<ParseParameter> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();

            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("ParseParameter");
            // Navigate Properties
        }
    }
}


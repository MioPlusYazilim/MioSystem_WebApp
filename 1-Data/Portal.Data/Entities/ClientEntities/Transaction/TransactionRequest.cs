using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class TransactionRequest : BaseEntity
    {
        public TransactionRequest()
        {
        }

        public int? ParentID { get; set; }
        public DateTime RequestDate { get; set; }
        public int RequestEmployeeID { get; set; }
        public string RequestEmployeeName { get; set; }
        public string RequestEmployeePhone { get; set; }
        public string RequestEmployeeMail { get; set; }
    }

    /*EntityMap Oluştur*/
    public class TransactionRequest_Configuration : IEntityTypeConfiguration<TransactionRequest>
    {
        public void Configure(EntityTypeBuilder<TransactionRequest> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();
            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("TransactionRequest");
            // Navigate Properties
        }
    }
}
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class TransactionCustomer : BaseEntity
    {
        public TransactionCustomer()
        {
        }

        public int? ParentID { get; set; }
        public int CustomerTypeID { get; set; }
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerMail { get; set; }
        public string CustomerLocation { get; set; }
    }

    /*EntityMap Oluştur*/
    public class TransactionCustomer_Configuration : IEntityTypeConfiguration<TransactionCustomer>
    {
        public void Configure(EntityTypeBuilder<TransactionCustomer> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();
            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("TransactionCustomer");
            // Navigate Properties
        }
    }
}

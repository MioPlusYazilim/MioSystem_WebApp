using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class CustomerService : BaseEntity
    {
        public CustomerService()
        {
        }

        public int CustomerGroupID { get; set; }
        public int CustomerID { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Notes { get; set; }
    }

    /*EntityMap Oluştur*/
    public class CustomerService_Configuration : IEntityTypeConfiguration<CustomerService>
    {
        public void Configure(EntityTypeBuilder<CustomerService> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();

            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("CustomerService");
            // Navigate Properties
        }
    }
}


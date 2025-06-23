using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class CustomerGlobal : BaseEntity
    {
        public CustomerGlobal()
        {
        }

        public int CustomerID { get; set; }
        public DateTime? GlobalDate { get; set; }
        public string GlobalID { get; set; }
        public string GlobalCode { get; set; }
        public string GlobalName { get; set; }
    }

    /*EntityMap Oluştur*/
    public class CustomerGlobal_Configuration : IEntityTypeConfiguration<CustomerGlobal>
    {
        public void Configure(EntityTypeBuilder<CustomerGlobal> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();

            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("CustomerGlobal");
            // Navigate Properties
        }
    }
}

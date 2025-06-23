using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class Customer : BaseEntity
    {
        public Customer()
        {
        }
        public int TypeID { get; set; }
        public int GroupID { get; set; }
        public int ParentID { get; set; }
        public string Code { get; set; }
        public string CodeName { get; set; }
        public string ModuleIDs { get; set; }
        public bool IsActive { get; set; }
        public int CompanyID { get; set; }
        public bool FState { get; set; }
    }

    /*EntityMap Oluştur*/
    public class Customer_Configuration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();

            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("Customer");
            // Navigate Properties
        }
    }
}


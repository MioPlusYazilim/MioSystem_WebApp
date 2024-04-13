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
            builder.Property(t => t.ID).ValueGeneratedOnAdd();
            builder.Property(t => t.TypeID).IsRequired();
            builder.Property(t => t.GroupID).IsRequired();
            builder.Property(t => t.ParentID).IsRequired();
            builder.Property(t => t.Code).IsRequired().HasMaxLength(50);
            builder.Property(t => t.CodeName).IsRequired().HasMaxLength(500);
            builder.Property(t => t.ModuleIDs).IsRequired().HasMaxLength(50);
            builder.Property(t => t.IsActive).IsRequired();
            builder.Property(t => t.CompanyID).IsRequired();
            builder.Property(t => t.Deleted).IsRequired();
            builder.Property(t => t.FState).IsRequired();

            builder.Ignore(i => i.Deleted);
            builder.ToTable("Customer");
            // Navigate Properties
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class Department : BaseEntity
    {
        public Department()
        {
        }

        public int ParentID { get; set; }
        public string Code { get; set; }
        public string CodeName { get; set; }
        public string PositionCode { get; set; }
        public bool IsActive { get; set; }
        public int CompanyID { get; set; }
        public bool FState { get; set; }
    }

    /*EntityMap Oluştur*/
    public class Department_Configuration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();
            

            builder.Ignore(i => i.Deleted);
            builder.ToTable("Department");
            // Navigate Properties
        }
    }
}


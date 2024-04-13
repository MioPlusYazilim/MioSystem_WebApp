using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class EmployeeSelectView : BaseEntity
    {
        public EmployeeSelectView()
        {
        }

        public int CustomerID { get; set; }
        public string FullName { get; set; }
        public int DepartmentID { get; set; }
        public int CustomerGrupID { get; set; }
    }

    /*EntityMap Oluştur*/
    public class EmployeeSelectView_Configuration : IEntityTypeConfiguration<EmployeeSelectView>
    {
        public void Configure(EntityTypeBuilder<EmployeeSelectView> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings

            builder.Ignore(i => i.Deleted);
            builder.ToTable("EmployeeSelectView");
            // Navigate Properties
        }
    }
}
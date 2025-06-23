using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class EmployeeApprover : BaseEntity
    {
        public EmployeeApprover()
        {
        }

        public int ApprovingLevel { get; set; }
        public int ApproverID { get; set; }
        public int EmployeeID { get; set; }
    }

    /*EntityMap Oluştur*/
    public class EmployeeApprover_Configuration : IEntityTypeConfiguration<EmployeeApprover>
    {
        public void Configure(EntityTypeBuilder<EmployeeApprover> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();

            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("EmployeeApprover");
            // Navigate Properties
        }
    }
}


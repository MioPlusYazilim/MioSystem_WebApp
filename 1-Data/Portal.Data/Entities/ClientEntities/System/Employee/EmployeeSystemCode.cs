using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class EmployeeSystemCode : BaseEntity
    {
        public EmployeeSystemCode()
        {
        }

        public int EmployeeID { get; set; }
        public string SystemCode { get; set; }
        public virtual Employee employee { get; set; }
    }

    /*EntityMap Oluştur*/
    public class EmployeeSystemCode_Configuration : IEntityTypeConfiguration<EmployeeSystemCode>
    {
        public void Configure(EntityTypeBuilder<EmployeeSystemCode> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();
            builder.Property(t => t.EmployeeID).HasColumnName("EmployeeID").IsRequired();
            builder.Property(t => t.SystemCode).HasColumnName("SystemCode").HasMaxLength(40);

            builder.Ignore(i => i.Deleted);
            builder.ToTable("EmployeeSystemCode");
            // Navigate Properties
        }
    }
}

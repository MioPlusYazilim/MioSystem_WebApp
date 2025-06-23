using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class EmployeeDocument : BaseEntity
    {
        public EmployeeDocument()
        {
        }

        public int EmployeeID { get; set; }
        public string DocumentName { get; set; }
        public byte[] DocumentValue { get; set; }
        public string DocumentLink { get; set; }
        public DateTime EndDate { get; set; }
    }

    /*EntityMap Oluştur*/
    public class EmployeeDocument_Configuration : IEntityTypeConfiguration<EmployeeDocument>
    {
        public void Configure(EntityTypeBuilder<EmployeeDocument> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();

            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("EmployeeDocument");
            // Navigate Properties
        }
    }
}

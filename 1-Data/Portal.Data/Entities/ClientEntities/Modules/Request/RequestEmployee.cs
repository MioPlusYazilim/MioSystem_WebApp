using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities.Modules.Request
{
    public class RequestEmployee : BaseEntity
    {
        public RequestEmployee()
        {
        }

        public int RequestID { get; set; }
        public int EmployeeID { get; set; }
        public int TravelPolicyID { get; set; }
        public string Notes { get; set; }
    }

    /*EntityMap Oluştur*/
    public class RequestEmployee_Configuration : IEntityTypeConfiguration<RequestEmployee>
    {
        public void Configure(EntityTypeBuilder<RequestEmployee> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();
            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("RequestEmployee");
            // Navigate Properties
        }
    }
}


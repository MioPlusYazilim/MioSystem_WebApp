using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class EmployeeParameter : BaseEntity
    {
        public EmployeeParameter()
        {
        }

        public int EmployeeID { get; set; }
        public DateTime? BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public string Notes { get; set; }
        public string LanguangePreference { get; set; }
        public string FoodPreference { get; set; }
        public string SeatPreference { get; set; }
        public bool IsSeflBooker { get; set; }
        public bool IsArranger { get; set; }
        public bool IsApprover { get; set; }
        public bool IsOnlineBooker { get; set; }
    }

    /*EntityMap Oluştur*/
    public class EmployeeParameter_Configuration : IEntityTypeConfiguration<EmployeeParameter>
    {
        public void Configure(EntityTypeBuilder<EmployeeParameter> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();

            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("EmployeeParameter");
            // Navigate Properties
        }
    }
}


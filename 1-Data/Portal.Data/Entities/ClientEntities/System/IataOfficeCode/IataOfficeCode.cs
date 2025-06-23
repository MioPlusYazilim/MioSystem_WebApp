using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class IataOfficeCode : BaseEntity
    {
        public IataOfficeCode()
        {
        }

        public string Code { get; set; }
        public int CustomerID { get; set; }
        public int StaffID { get; set; }
        public int CompanyID { get; set; }
        public bool FState { get; set; }
    }

    /*EntityMap Oluştur*/
    public class IataOfficeCode_Configuration : IEntityTypeConfiguration<IataOfficeCode>
    {
        public void Configure(EntityTypeBuilder<IataOfficeCode> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();

            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("IataOfficeCode");
            // Navigate Properties
        }
    }
}

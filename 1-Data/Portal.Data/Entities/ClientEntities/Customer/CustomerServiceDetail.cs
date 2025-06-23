using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class CustomerServiceDetail : BaseEntity
    {
        public CustomerServiceDetail()
        {
        }

        public int CustomerServiceID { get; set; }
        public bool IsInternational { get; set; }
        public bool IsOnlineService { get; set; }
        public bool IsTaxIncluding { get; set; }
        public int? ServiceCardID { get; set; }
        public string CurrencyCode { get; set; }
        public int? RateTypeID { get; set; }
        public double ServiceRate { get; set; }
        public double ServiceAmount { get; set; }
        public double ShiftServiceRate { get; set; }
        public double ShiftServiceAmount { get; set; }
        public string ModuleIDs { get; set; }
        public bool IsActive { get; set; }
    }

    /*EntityMap Oluştur*/
    public class CustomerServiceDetail_Configuration : IEntityTypeConfiguration<CustomerServiceDetail>
    {
        public void Configure(EntityTypeBuilder<CustomerServiceDetail> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();

            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("CustomerServiceDetail");
            // Navigate Properties
        }
    }
}


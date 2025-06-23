using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Portal.Data.Entities.ClientEntities
{
    public class AirlineService : BaseEntity
    {
        public AirlineService()
        {
        }

        public string Code { get; set; }
        public string DomDistance { get; set; }
        public string IntDistance { get; set; }
        public DateTime Begindate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsSalesService { get; set; }
        public bool IsRefundService { get; set; }
        public bool IsCancelService { get; set; }
        public bool IsFreeService { get; set; }
        public bool IsAirlineService { get; set; }
        public int CompanyID { get; set; }
        public bool FState { get; set; }
    }

    /*EntityMap Oluştur*/
    public class AirlineService_Configuration : IEntityTypeConfiguration<AirlineService>
    {
        public void Configure(EntityTypeBuilder<AirlineService> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();

            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("AirlineService");
            // Navigate Properties
        }
    }
}

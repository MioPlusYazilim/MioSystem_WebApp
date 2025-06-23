using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class AirlineServiceDetail : BaseEntity
    {
        public AirlineServiceDetail()
        {
        }

        public int AirlineServiceID { get; set; }
        public bool IsSegment { get; set; }
        public string AirlineCodes { get; set; }
        public string LineTypeIDs { get; set; }
        public string DistanceIDs { get; set; }
        public string ClassTypeIDs { get; set; }
        public string CurrencyCode { get; set; }
        public double SalesAmount { get; set; }
        public double ReissueAmount { get; set; }
        public double RefundAmount { get; set; }
        public double CancelAmount { get; set; }
        public double OnlineAmount { get; set; }
        public double FreeTicketAmount { get; set; }
        public double OvertimeAmount { get; set; }
        public double WeekendAmount { get; set; }
        public double CheckInAmount { get; set; }
        public double MinServiceAmount { get; set; }
        public string ExceptionalCurrencyCode { get; set; }
        public double ExceptionalAmount { get; set; }
        public double ServiceRate { get; set; }
        public double TaxRate { get; set; }
        public bool IsTaxIncluding { get; set; }
        public bool IsServiceTaxIncluding { get; set; }
        public int LongDistance { get; set; }
    }

    /*EntityMap Oluştur*/
    public class AirlineServiceDetail_Configuration : IEntityTypeConfiguration<AirlineServiceDetail>
    {
        public void Configure(EntityTypeBuilder<AirlineServiceDetail> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();

            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("AirlineServiceDetail");
            // Navigate Properties
        }
    }
}


using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class InvoiceSeries : BaseEntity
    {
        public InvoiceSeries()
        {
        }

        public int InvoiceTypeID { get; set; }
        public string DocumentSeries { get; set; }
        public int? DocumentNo { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
        public int DepartmentID { get; set; }
        public int ModuleID { get; set; }
        public int UserID { get; set; }
        public int CompanyID { get; set; }
        public int FState { get; set; }
    }

    /*EntityMap Oluştur*/
    public class InvoiceSeries_Configuration : IEntityTypeConfiguration<InvoiceSeries>
    {
        public void Configure(EntityTypeBuilder<InvoiceSeries> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();

            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("InvoiceSeries");
            // Navigate Properties
        }
    }
}

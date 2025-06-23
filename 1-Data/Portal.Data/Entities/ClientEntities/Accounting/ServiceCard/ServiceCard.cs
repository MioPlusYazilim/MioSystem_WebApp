using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class ServiceCard : BaseEntity
    {
        public ServiceCard()
        {
        }

        public int? GroupID { get; set; }
        public string Code { get; set; }
        public string CodeName { get; set; }
        public string Barcode { get; set; }
        public double TaxRate { get; set; }
        public double SalesTaxRate { get; set; }
        public double BuyingTaxRate { get; set; }
        public bool IsInternational { get; set; }
        public string Property { get; set; }
        public string ModuleIDs { get; set; }
        public int CompanyID { get; set; }
        public bool FState { get; set; }
    }

    /*EntityMap Oluştur*/
    public class ServiceCard_Configuration : IEntityTypeConfiguration<ServiceCard>
    {
        public void Configure(EntityTypeBuilder<ServiceCard> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();
            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("ServiceCard");
            // Navigate Properties
        }
    }
}


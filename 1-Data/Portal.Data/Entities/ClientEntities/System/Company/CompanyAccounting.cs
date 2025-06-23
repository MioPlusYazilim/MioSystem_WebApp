using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class CompanyAccounting : BaseEntity
    {
        public CompanyAccounting()
        {
        }

        public int CompanyID { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public string TaxOffice { get; set; }
        public string TaxNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string EMailAddress { get; set; }
        public string WebSiteAddress { get; set; }
        public int InvoiceTemplateID { get; set; }
        public bool IsEInvoice { get; set; }
        public DateTime? EInvoiceDate { get; set; }
        public string EInvoiceModel { get; set; }
        public int EInvoiceIntegratorID { get; set; }
        public int EInvoiceTemplateID { get; set; }
        public bool IsEArchive { get; set; }
        public DateTime? EArchiveDate { get; set; }
        public string EArchiveModel { get; set; }
        public int EArchiveIntegratorID { get; set; }
        public int EArchiveTemplateID { get; set; }
        public bool IsWaybill { get; set; }
        public DateTime? EWaybillDate { get; set; }
        public string EWaybillModel { get; set; }
        public int EWaybillIntegratorID { get; set; }
        public int EWaybillTemplateID { get; set; }
        public int CountryID { get; set; }
        public int CityID { get; set; }
        public string DistrictID { get; set; }
        public string MersisNumber { get; set; }
        public string TradeRegisterNo { get; set; }
        public string UrnAddress { get; set; }
        public string IBANNumber { get; set; }
        public int AccountingAppsID { get; set; }
    }

    /*EntityMap Oluştur*/
    public class CompanyAccounting_Configuration : IEntityTypeConfiguration<CompanyAccounting>
    {
        public void Configure(EntityTypeBuilder<CompanyAccounting> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();

            builder.HasQueryFilter(m => EF.Property<bool>(m, "Deleted") == false);
            builder.Ignore(i => i.Deleted);
            builder.ToTable("CompanyAccounting");
            // Navigate Properties
        }
    }
}



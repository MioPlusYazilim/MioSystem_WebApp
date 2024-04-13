using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class CompanyGetInfoView : BaseEntity
    {
        public CompanyGetInfoView()
        {
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Fax1 { get; set; }
        public string Fax2 { get; set; }
        public string EMail { get; set; }
        public string WebAddress { get; set; }
        public string Address { get; set; }
        public string TaxOffice { get; set; }
        public string TaxNumber { get; set; }
        public string MapLink { get; set; }
        public byte[] Logo { get; set; }
        public string LogoLink { get; set; }
    }

    /*EntityMap Oluştur*/
    public class CompanyGetInfoView_Configuration : IEntityTypeConfiguration<CompanyGetInfoView>
    {
        public void Configure(EntityTypeBuilder<CompanyGetInfoView> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Ignore(i => i.Deleted);
            builder.ToTable("CompanyGetInfoView");
            // Navigate Properties
        }
    }
}
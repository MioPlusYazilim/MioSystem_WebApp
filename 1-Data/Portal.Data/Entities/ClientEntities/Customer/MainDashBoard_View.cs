using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class MainDashBoard_View : BaseEntity
    {
        public MainDashBoard_View()
        {
        }

        public int Count { get; set; }
        public int Month { get; set; }
        public double Price { get; set; }
        public string ModuleName { get; set; }
        public int prmStaffID { get; set; }
        public int prmDepartmentID { get; set; }
        public int? prmEmployeeID { get; set; }
        public int? prmCorpurateDepartmentID { get; set; }
        public int prmModuleID { get; set; }
    }

    /*EntityMap Oluştur*/
    public class MainDashBoard_View_Configuration : IEntityTypeConfiguration<MainDashBoard_View>
    {
        public void Configure(EntityTypeBuilder<MainDashBoard_View> builder)
        {

            // Properties, Table & Column Mappings
            builder.ToTable("MainDashBoard_View");
            // Navigate Properties
        }
    }
}
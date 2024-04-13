using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portal.Data.Entities.ClientEntities
{
    public class EmployeeParameters : BaseEntity
    {
        public EmployeeParameters()
        {
        }

        public int EmployeeID { get; set; }
        public int DutyID { get; set; }
        public int DepartmentID { get; set; }
        public int AuthoryGroup { get; set; }
        public int AuthoryLevel { get; set; }
        public int AuthoryRole { get; set; }
        public string SelfRecordModulIDs { get; set; }
        public string AuthorizedCustomerIDs { get; set; }
        public string AuthorizedCustomerGroupIDs { get; set; }
        public string AuthorizedIPAdressess { get; set; }
        public string AuthorizedDevices { get; set; }
        public string WinTheme { get; set; }
        public string WebTheme { get; set; }
        public string DisplayLanguage { get; set; }

        public virtual Employee employee { get; set; }

        public virtual List<int> selfModulList { get { return (SelfRecordModulIDs ?? "").Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList(); } }
        public virtual List<int> customerList { get { return (AuthorizedCustomerIDs ?? "").Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList(); } }
        public virtual List<int> customerGroupList { get { return (AuthorizedCustomerGroupIDs ?? "").Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList(); } }
        public virtual List<int> ipAdreesessList { get { return (AuthorizedIPAdressess ?? "").Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList(); } }
        public virtual List<int> devicessList { get { return (AuthorizedDevices ?? "").Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList(); } }
    }

    /*EntityMap Oluştur*/
    public class EmployeeParameters_Configuration : IEntityTypeConfiguration<EmployeeParameters>
    {
        public void Configure(EntityTypeBuilder<EmployeeParameters> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ID);

            // Properties, Table & Column Mappings
            builder.Property(t => t.ID).HasColumnName("ID").ValueGeneratedOnAdd();

            builder.Ignore(c => c.selfModulList);
            builder.Ignore(c => c.customerList);
            builder.Ignore(c => c.customerGroupList);
            builder.Ignore(c => c.ipAdreesessList);
            builder.Ignore(c => c.devicessList);
            builder.Ignore(c => c.Deleted);

            builder.ToTable("EmployeeParameters");
            // Navigate Properties
        }
    }
}


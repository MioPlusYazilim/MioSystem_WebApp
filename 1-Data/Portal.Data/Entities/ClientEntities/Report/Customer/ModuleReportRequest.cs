using System;

namespace Portal.Data.Entities.ClientEntities
{
    public class ModuleReportRequest
    {
        public ModuleReportRequest()
        {
            reportGlobalParameters = new ReportGlobalParameters();
            reportCustomerParameters = new ReportCustomerParameters();
        }
        public ReportGlobalParameters reportGlobalParameters { get; set; }
        public ReportCustomerParameters reportCustomerParameters { get; set; }
    }
}

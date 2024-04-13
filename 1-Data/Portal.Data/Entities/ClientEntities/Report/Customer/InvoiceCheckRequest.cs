using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Portal.Data.Entities.ClientEntities
{
    public class InvoiceCheckRequest
    {
        public DateTime? processDate1 { get; set; }
        public DateTime? processDate2 { get; set; }
        public DateTime? serviceBeginDate1 { get; set; }
        public DateTime? serviceBeginDate2 { get; set; }
        public DateTime? serviceEndDate1 { get; set; }
        public DateTime? serviceEndDate2 { get; set; }
        public int isDomestic { get; set; } = 0;
        public string moduleIDs { get; set; } = string.Empty;
        public string issuedBy { get; set; }=string.Empty;
        public string costCenter { get; set; } = string.Empty;
        public string requestCode { get; set; } = string.Empty;
        public string confirmationCode { get; set; } = string.Empty;
    }
}

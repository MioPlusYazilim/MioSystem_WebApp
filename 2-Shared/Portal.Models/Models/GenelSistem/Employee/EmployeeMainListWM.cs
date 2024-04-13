using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.Model
{
    public class EmployeeMainListWM
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string email { get; set; }
        public string mobilePhone { get; set; }
        public string authoryGroup { get; set; }
        public string authoryLevel { get; set; }
        public bool deleted { get; set; }
        public string authorizedCustomerIDs { get; set; }
        public string authorizedCustomerGroupIDs { get; set; }

        public virtual List<int> cariList { get { return (authorizedCustomerIDs ?? "0").Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList(); } }
        public virtual List<int> cariGrupList { get { return (authorizedCustomerGroupIDs ?? "0").Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList(); } }
    }
}

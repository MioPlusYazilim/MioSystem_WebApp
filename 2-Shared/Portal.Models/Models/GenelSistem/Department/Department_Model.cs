using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.Model
{
    public class Department_Model : BaseModel
    {
        public Department_Model()
        {
        }

        public int ParentID { get; set; }
        public string Code { get; set; }
        public string CodeName { get; set; }
        public string PositionCode { get; set; }
        public bool IsActive { get; set; }
        public int CompanyID { get; set; }
        public bool FState { get; set; }
    }
}

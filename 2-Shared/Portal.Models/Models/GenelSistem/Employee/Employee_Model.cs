using System;
using System.Collections.Generic;

namespace Portal.Model
{
    public class Employee_Model : BaseModel
    {

        public Employee_Model()
        {
            employeeParameters = new EmployeeAuthory_Model();
            employeeSystemCodes = new List<EmployeeSystemCode_Model>();
        }

        public string firstName { get; set; } = string.Empty;
        public string lastName { get; set; }=string.Empty;
        public string longName { get; set; }= string.Empty;
        public string email { get; set; } = string.Empty;
        public string gSMNumber { get; set; } = string.Empty;
        public int customerID { get; set; } = 0;
        public string modulIDs { get; set; } = string.Empty;
        public int companyID { get; set; }= 0;
        public bool fState { get; set; }= false;

        public virtual EmployeeAuthory_Model employeeParameters { get; set; }
        public virtual List<EmployeeSystemCode_Model> employeeSystemCodes { get; set; }

    }
}

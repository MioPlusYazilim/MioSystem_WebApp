using System;
using System.Collections.Generic;

namespace Portal.Model
{
    public class Employee_Dto : BaseModel
    {

        public Employee_Dto()
        {
            employeeParameters = new EmployeeParameters_Dto();
            employeeSystemCodes = new List<EmployeeSystemCode_Dto>();
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

        public virtual EmployeeParameters_Dto employeeParameters { get; set; }
        public virtual List<EmployeeSystemCode_Dto> employeeSystemCodes { get; set; }

    }
}

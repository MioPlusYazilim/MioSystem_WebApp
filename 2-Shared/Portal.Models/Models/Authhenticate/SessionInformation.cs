using System.Collections.Generic;


namespace Portal.Model
{
    public class SessionInformation
    {
        public int EmployeeID { get; set; } = 0;
        public int AuthoryGroup { get; set; } = 1;
        public int AuthoryLevel { get; set; } = 1;
        public int DepartmentID { get; set; } = 0;
        public string ClientKey { get; set; } = string.Empty;
        public string ClientConnetionString { get; set; } = string.Empty;
        public string Language { get; set; } = "tr-TR";
        public List<int> CustomerIDs { get; set; } = new List<int>();
        public List<int> CustomerGroupIDs { get; set; } = new List<int>();
    }

}

namespace Portal.Model
{
    public class EmployeeAuthory_Model : BaseModel
    {
        public EmployeeAuthory_Model()
        {
        }
        public int employeeID { get; set; } = 0;
        public int dutyID { get; set; } = 0;
        public int authoryGroup { get; set; } = 0;
        public int authoryLevel { get; set; } = 0;
        public int authoryRole { get; set; } = 0;
        public string selfRecordModulIDs { get; set; } = string.Empty;
        public string authorizedCustomerIDs { get; set; } = string.Empty;
        public string authorizedCustomerGroupIDs { get; set; } = string.Empty;
        public string authorizedIPAdressess { get; set; } = string.Empty;
        public string authorizedDevices { get; set; } = string.Empty;

        public virtual List<int> selfModulList { get { return (selfRecordModulIDs ?? "").Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList(); } }
        public virtual List<int> customerList { get { return (authorizedCustomerIDs ?? "").Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList(); } }
        public virtual List<int> customerGroupList { get { return (authorizedCustomerGroupIDs ?? "").Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList(); } }
        public virtual List<int> ipAdreesessList { get { return (authorizedIPAdressess ?? "").Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList(); } }
        public virtual List<int> devicessList { get { return (authorizedDevices ?? "").Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList(); } }
    }
}

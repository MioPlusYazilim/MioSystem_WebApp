
namespace Portal.Model
{
    public class EmployeeSystemCode_Model : BaseModel
    {
        public EmployeeSystemCode_Model()
        {
        }
        public int employeeID { get; set; } = 0;
        public string systemCode { get; set; }=string.Empty;
    }
}
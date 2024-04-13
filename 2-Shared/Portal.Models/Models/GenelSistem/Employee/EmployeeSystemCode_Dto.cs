
namespace Portal.Model
{
    public class EmployeeSystemCode_Dto : BaseModel
    {
        public EmployeeSystemCode_Dto()
        {
        }
        public int employeeID { get; set; } = 0;
        public string systemCode { get; set; }=string.Empty;
    }
}
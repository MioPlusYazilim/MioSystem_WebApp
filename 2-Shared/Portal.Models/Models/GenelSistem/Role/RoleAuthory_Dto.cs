namespace Portal.Model
{
    public class RoleAuthory_Dto : BaseModel
    {
        public RoleAuthory_Dto()
        {
        }
        public int roleID { get; set; } = 0;
        public int menuID { get; set; } = 0;
        public bool allowList { get; set; } = false;
        public bool allowNew { get; set; } = false;
        public bool allowEdit { get; set; } = false;
        public bool allowDelete { get; set; } = false;
        public bool allowPrint { get; set; } = false;
        public string reportIDs { get; set; } = string.Empty;
    }
}
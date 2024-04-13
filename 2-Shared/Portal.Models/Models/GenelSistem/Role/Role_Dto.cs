using System;
using System.Collections.Generic;

namespace Portal.Model
{
    public class Role_Dto : BaseModel
    {
        public Role_Dto()
        {
            authories = new List<RoleAuthory_Dto>();
        }
        public string roleName { get; set; }
        public string description { get; set; }
        public bool active { get; set; }
        public int companyID { get; set; }
        public virtual List<RoleAuthory_Dto> authories { get; set; }
    }
}
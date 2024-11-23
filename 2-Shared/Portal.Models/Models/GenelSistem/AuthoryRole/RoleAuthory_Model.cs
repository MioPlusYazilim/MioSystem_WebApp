using System;
using System.Collections.Generic;

namespace Portal.Model
{
    public class RoleAuthory_Model : BaseModel
    {
        public RoleAuthory_Model()
        {
            authories = new List<RoleAuthoryPermission_Model>();
        }
        public string roleName { get; set; }
        public string note { get; set; }
        public bool active { get; set; }
        public int companyID { get; set; }
        public virtual List<RoleAuthoryPermission_Model> authories { get; set; }
    }
}
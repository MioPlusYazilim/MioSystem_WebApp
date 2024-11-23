using Portal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MioSystem.Utils
{
    public class BaseFormSettings
    {
        public Login FormUser { get; set; } = Login.GetLoginUser();
        public NavigationAuthory_Model FormPermissions { get; set; }
        public int FormModulID { get; set; } = 0;
        public int FormID { get; set; } = 0;
        public int FormAuthoryID { get; set; } = 0;
        public void Init()
        {
            FormUser = Login.GetLoginUser();
            if (FormUser != null && FormUser.authories != null)
            {
                var auth = FormUser.authories.FirstOrDefault(x => x.id == FormAuthoryID);
                if (auth != null)
                {
                    FormPermissions = auth;
                }
            }
        }
    }
}

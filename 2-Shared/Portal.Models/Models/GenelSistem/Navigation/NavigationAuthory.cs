using System.Collections.Generic;

namespace Portal.Model
{
    public class NavigationRole : BaseModel
    {
        public int modulID { get; set; }
        public int formType { get; set; }
        public int menuTag { get; set; }
        public int menuCardType { get; set; }
        public bool isInternational { get; set; }
        public string menuName { get; set; }
        public string editFormName { get; set; }
        public string editFormPath { get; set; }
        public string listFormName { get; set; }
        public string formCaption { get; set; }
        public string editFormCaption { get; set; }
        public bool allowList { get; set; }
        public bool allowNew { get; set; }
        public bool allowDelete { get; set; }
        public bool allowEdit { get; set; }
        public bool allowPrint { get; set; }
        public string reportIDs { get; set; }
    }
}
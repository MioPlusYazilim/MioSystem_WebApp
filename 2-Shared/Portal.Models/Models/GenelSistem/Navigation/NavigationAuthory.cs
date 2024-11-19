using System.Collections.Generic;

namespace Portal.Model
{
    public class NavigationAuthory : BaseModel
    {
        public int modulID { get; set; } = 0;
        public int formType { get; set; } = 0;
        public int authoryID { get; set; } = 0;
        public string menuName { get; set; } = string.Empty;
        public string editFormName { get; set; } = string.Empty;
        public string editFormPath { get; set; } = string.Empty;
        public string listFormCaption { get; set; } = string.Empty;
        public string editFormCaption { get; set; } = string.Empty;
        public string listSourceName { get; set; } = string.Empty;
        public int listSourceType { get; set; } = 0;
        public bool allowList { get; set; } = false;
        public bool allowNew { get; set; } = false;
        public bool allowDelete { get; set; } = false;
        public bool allowEdit { get; set; } = false;
        public bool allowPrint { get; set; } = false;
        public string reportIDs { get; set; } = string.Empty;
        public int listTypeID { get; set; } = 0;
    }
}
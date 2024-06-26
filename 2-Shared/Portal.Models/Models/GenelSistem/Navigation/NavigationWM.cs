using System.Collections.Generic;

namespace Portal.Model
{
    public class NavigationM : BaseModel
    {
        public int parentID { get; set; } = 0;
        public int modulID { get; set; } = 0;
        public int menuLevel { get; set; } = 0;
        public int menuOrder { get; set; } = 0;
        public int formType { get; set; } = 0;
        public string menuIcon { get; set; } = string.Empty;
        public string menuLink { get; set; } = string.Empty;
        public int menuTag { get; set; } = 0;
        public int menuCardType { get; set; } = 0;
        public bool isInternational { get; set; } = false;
        public string menuName { get; set; } = string.Empty;
        public string editFormName { get; set; } = string.Empty;
        public string editFormPath { get; set; } = string.Empty;
        public string listFormName { get; set; } = string.Empty;
        public string listFormPath { get; set; } = string.Empty;
        public string menuPath { get; set; } = string.Empty;
        public string formCaption { get; set; } = string.Empty;
        public string editFormCaption { get; set; } = string.Empty;
        public string listMethodName { get; set; } = string.Empty;
        public bool allowList { get; set; } = false;
        public bool allowNew { get; set; } = false;
        public bool allowDelete { get; set; } = false;
        public bool allowEdit { get; set; } = false;
        public bool allowPrint { get; set; } = false;
        public string reportIDs { get; set; } = string.Empty;
        public List<NavigationM> items { get; set; } = new List<NavigationM>();
    }
}
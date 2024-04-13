using System.Collections.Generic;

namespace Portal.Model
{
    public class NavigationM : BaseModel
    {
        public int parentID { get; set; }
        public int modulID { get; set; }
        public int menuLevel { get; set; }
        public int menuOrder { get; set; }
        public int formType { get; set; }
        public string menuIcon { get; set; }
        public string menuLink { get; set; }
        public int menuTag { get; set; }
        public int menuCardType { get; set; }
        public bool isInternational { get; set; }
        public string menuName { get; set; }
        public string editFormName { get; set; }
        public string editFormPath { get; set; }
        public string listFormName { get; set; }
        public string listFormPath { get; set; }
        public string menuPath { get; set; }
        public string formCaption { get; set; }
        public string editFormCaption { get; set; }
        public bool allowList { get; set; }
        public bool allowNew { get; set; }
        public bool allowDelete { get; set; }
        public bool allowEdit { get; set; }
        public bool allowPrint { get; set; }
        public string reportIDs { get; set; }
        public List<NavigationM> items { get; set; } = new List<NavigationM>();
    }
}
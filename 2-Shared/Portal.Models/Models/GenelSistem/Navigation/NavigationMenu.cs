using System.Collections.Generic;

namespace Portal.Model
{
    public class NavigationMenu : BaseModel
    {
        public int modulID { get; set; } = 0;
        public string menuIcon { get; set; } = string.Empty;
        public int authoryID { get; set; } = 0;
        public string menuName { get; set; } = string.Empty;
        public int menuType { get; set; } = 0;
        public List<NavigationMenu> items { get; set; } = new List<NavigationMenu>();
    }
}
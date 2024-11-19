using System.Collections.Generic;

namespace Portal.Model
{
    public sealed class Login
    {
        public Login() { 
        }

        private static Login? _instance;


        public static Login GetLoginUser()
        {
            if (_instance == null)
            {
                _instance = new Login();
            }
            return _instance;
        }

        public int employeeID { get; set; } = 0;
        public string fullName { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
        public int authoryGroup { get; set; } = 0;
        public int authoryLevel { get; set; } = 0;
        public string profileImagePath { get; set; } = string.Empty;
        public string token { get; set; } = string.Empty;
        public string refreshToken { get; set; } = string.Empty;
        public int companyID { get; set; } = 0;
        public string companyName { get; set; } = string.Empty;
        public string companyCode { get; set; } = string.Empty;
        public int departmentID { get; set; } = 0;
        public string workingLang { get; set; } = "tr-TR";
        public string winTheme { get; set; } = string.Empty;
        public string webTheme { get; set; } = string.Empty;
        public string displayLanguage { get; set; } = string.Empty;
        public string clientKey { get; set; } = string.Empty;
        public string globalKey { get; set; } = string.Empty;
        public List<int> customerIDs { get; set; } = [];
        public List<int> customerGroupIDs { get; set; } = [];
        public List<NavigationAuthory> authories { get; set; } = [];
        public List<NavigationMenu> mainMenu { get; set; } = [];
        public List<NavigationMenu> settingsMenu { get; set; } = [];

        
    }
}

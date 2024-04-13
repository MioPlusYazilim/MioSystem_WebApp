using System.Collections.Generic;

namespace Portal.Model
{
    public sealed class LoginResponse
    {
        public LoginResponse() { 
        }

        private static LoginResponse? _instance;


        public static LoginResponse GetLoginResponse()
        {
            if (_instance == null)
            {
                _instance = new LoginResponse();
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
        public List<NavigationRole> navigationAuthories { get; set; } = [];
        public List<NavigationM> mainMenuNavigations { get; set; } = [];
        public List<NavigationM> settingsMenuNavigations { get; set; } = [];

        
    }
}

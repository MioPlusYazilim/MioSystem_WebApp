using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.Model
{
    public class passwordResetRequest
    {
        public string token { get; set; } = string.Empty;
        public string password { get; set; } = string.Empty;
    }
}

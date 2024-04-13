using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.Model
{
    public class refreshTokenRequest
    {
        [Required] 
        public string requestValue { get; set; } = string.Empty;
    }
}

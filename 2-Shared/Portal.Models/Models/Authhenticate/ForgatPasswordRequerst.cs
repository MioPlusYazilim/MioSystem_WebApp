using System.ComponentModel.DataAnnotations;

namespace Portal.Model
{
    public class forgatPasswordRequerst
    {
        [Required] 
        public string requestValue { get; set; } = string.Empty;
    }
}

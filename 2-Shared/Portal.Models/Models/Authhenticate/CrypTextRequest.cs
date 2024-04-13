using System.ComponentModel.DataAnnotations;

namespace Portal.Model
{
    public class crypTextRequest
    {
        [Required]
        public string requestValue { get; set; } = string.Empty;
    }
}

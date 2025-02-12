using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.Model
{
    public class AirPort_Model : BaseModel
    {
        public AirPort_Model()
        { }

        public string LanguageCode { get; set; }
        public string FieldValue { get; set; }
        public string FieldName { get; set; }
        public string CityName { get; set; }
        public string CountryCode { get; set; }
    }
}

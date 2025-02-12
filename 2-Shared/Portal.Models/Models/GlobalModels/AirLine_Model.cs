using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.Model
{
    public class AirLine_Model : BaseModel
    {
        public AirLine_Model()
        { }
        public string LanguageCode { get; set; }
        public string FieldValue { get; set; }
        public string FieldName { get; set; }
        public string FormNo { get; set; }
        public string CountryCode { get; set; }
    }
}
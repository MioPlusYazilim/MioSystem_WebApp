using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.Model
{
    public class FlightLineType_Model : BaseModel
    {
        public FlightLineType_Model()
        { }
        public string LanguageCode { get; set; }
        public string FieldValue { get; set; }
        public string FieldName { get; set; }
        public string GroupValue { get; set; }
    }
}

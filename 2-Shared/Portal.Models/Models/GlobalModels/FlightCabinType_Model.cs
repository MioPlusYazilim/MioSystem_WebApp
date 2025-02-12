using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.Model
{
    public class FlightCabinType_Model : BaseModel
    {
        public FlightCabinType_Model()
        { }
        public string LanguageCode { get; set; }
        public string FieldValue { get; set; }
        public string FieldName { get; set; }
        public string SupplierCode { get; set; }
        public bool IsSubCabin { get; set; }
        public int FlightSupplierID { get; set; }
    }
}

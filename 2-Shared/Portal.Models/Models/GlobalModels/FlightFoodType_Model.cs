using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.Model
{
    public class FlightFoodType_Model : BaseModel
    {
        public FlightFoodType_Model()
        { }
        public string LanguageCode { get; set; }
        public string FieldValue { get; set; }
        public string FieldName { get; set; }
        public int FlightSupplierID { get; set; }
    }
}

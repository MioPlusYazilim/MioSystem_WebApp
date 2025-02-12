using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.Model
{
    public class FlightDistance_Model : BaseModel
    {
        public FlightDistance_Model()
        { }
        public string Departure { get; set; }
        public string Arrival { get; set; }
        public string FlyTime { get; set; }
        public float Mile { get; set; }
        public float Carbon { get; set; }
    }
}

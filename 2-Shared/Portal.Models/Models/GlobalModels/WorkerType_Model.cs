using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.Model
{
    public class WorkerType_Model : BaseModel
    {
        public WorkerType_Model()
        { }
        public string LanguageCode { get; set; }
        public string FieldValue { get; set; }
        public string FieldName { get; set; }
    }
}

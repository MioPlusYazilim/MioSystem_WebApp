using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.Model
{
    public class ExceptionCode_Model : BaseModel
    {
        public ExceptionCode_Model()
        { }
        public string LanguageCode { get; set; }
        public string FieldValue { get; set; }
        public string FieldName { get; set; }
        public int ExceptionTypeID { get; set; }
        public int Numerator { get; set; }
        public int DeNumerator { get; set; }
    }
}

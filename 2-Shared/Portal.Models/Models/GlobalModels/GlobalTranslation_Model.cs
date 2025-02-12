using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.Model
{
    public class GlobalTranslation_Model : BaseModel
    {
        public GlobalTranslation_Model()
        { }

        public int GlobalDeclarationID { get; set; }
        public string LanguageCode { get; set; }
        public string FieldValue { get; set; }
        public string FieldName { get; set; }
        public string FieldReport { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Model
{
    public class CariTalimatBilgisiVM : BaseModel
    {
        public CariTalimatBilgisiVM()
        {
        }
        public int cariID { get; set; }
        public DateTime baslamaTarihi { get; set; }
        public int talimatTipi { get; set; }
        public bool aktif { get; set; }
        public int modulID { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Model
{
    public class CariDokumanVM : BaseModel
    {
        public CariDokumanVM()
        {
        }
        public int cariID { get; set; }
        public string belgeAdi { get; set; }
        public byte[] belgeData { get; set; }
        public DateTime bitisTarihi { get; set; }
    }
}
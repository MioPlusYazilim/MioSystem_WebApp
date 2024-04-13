using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Model
{
    public class CariKurumsalVM : BaseModel
    {
        public CariKurumsalVM()
        {
        }
        public int cariID { get; set; }
        public int islemTipiID { get; set; }
        public int grupID { get; set; }
        public string kod { get; set; }
        public string adi { get; set; }
        public string grupKodu { get; set; }
        public string modulIDs { get; set; }
    }
}

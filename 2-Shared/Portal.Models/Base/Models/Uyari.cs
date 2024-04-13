using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.Model
{
    public class Uyari
    {
        public string id { get; set; }
        public UyariTipi Tip { get; set; }
        public string Mesaj { get; set; }
        public bool OtomatikKapanma { get; set; }
        public bool SayfaDegisimindeKoru { get; set; }
    }

    public enum UyariTipi
    {
        Basarili,
        Hata,
        Bilgi,
        Ikaz
    }
}

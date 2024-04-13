using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Model
{
    public class CariParametreVM : BaseModel
    {
        public CariParametreVM()
        {
        }
        public int cariID { get; set; }
        public string customerTypeIDs { get; set; }
        public bool globalCari { get; set; }
        public DateTime? globalTarih { get; set; }
        public string globalID { get; set; }
        public string globalKodu { get; set; }
        public string globalAdi { get; set; }
        public bool kurumsalCari { get; set; }
        public bool alternatifFiyatKullan { get; set; }
        public bool pozisyonOlustur { get; set; }
        public string pozisyonOnDeger { get; set; }
        public string referans1 { get; set; }
        public string referans2 { get; set; }
        public bool uyariNotuGoster { get; set; }
        public string uyariNotu { get; set; }
        public bool smsGonder { get; set; }
        public string smsModulIDs { get; set; }
        public bool mailGonder { get; set; }
        public string mailModulIDs { get; set; }
        public bool faturaMailGonder { get; set; }
        public bool dekontMailGonder { get; set; }
        public bool mailFaturaPdfEkle { get; set; }
        public bool mailFaturaPdfFiyatGoster { get; set; }
        public bool mailBiletPdfEkle { get; set; }
        public bool mailBiletdPdfFiyatGoster { get; set; }
        public bool krediKontroluYap { get; set; }
        public double krediUstLimit { get; set; }
        public string haritaKoordinat { get; set; }
    }
}
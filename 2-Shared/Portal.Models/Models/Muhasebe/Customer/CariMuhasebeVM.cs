using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Model
{
    public class CariMuhasebeVM : BaseModel
    {
        public CariMuhasebeVM()
        {
        }
        public int cariID { get; set; }
        public string vergiNumarasi { get; set; }
        public string vergiDairesi { get; set; }
        public string unvan { get; set; }
        public string adres { get; set; }
        public string postakodu { get; set; }
        public string telefon { get; set; }
        public string faks { get; set; }
        public string eMail { get; set; }
        public string webSite { get; set; }
        public string lokasyonKodu { get; set; }
        public string ulkeKodu { get; set; }
        public string dovizKodu { get; set; }
        public int dovizKuruTipiID { get; set; }
        public double dovizKuru { get; set; }
        public int odemeTipiID { get; set; }
        public int odemeVadeID { get; set; }
        public bool kdvMuafCari { get; set; }
        public bool eFaturaCarisi { get; set; }
        public bool kurumsalCari { get; set; }
        public bool tevkifatliCari { get; set; }
        public int tevkifatTipiID { get; set; }
        public double tevkifatLimiti { get; set; }
        public int faturaTipiID { get; set; }
        public int faturaSablonID { get; set; }
        public int dekontSablonID { get; set; }
        public string faturaUlke { get; set; }
        public string faturaSehir { get; set; }
        public string faturaIlce { get; set; }
        public string faturaMahalle { get; set; }
        public string urnAdresi { get; set; }
        public string muhasebeGrubu { get; set; }
        public string alisMuhasebeKodu { get; set; }
        public string satisMuhasebeKodu { get; set; }
        public string dekontMuhasebeKodu { get; set; }
        public string masrafMerkezi { get; set; }
        public bool gIBOdemeBilgisi { get; set; }
        public bool gIBVadeBilgisi { get; set; }
    }
}
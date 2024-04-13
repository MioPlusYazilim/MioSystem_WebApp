namespace Portal.Model
{
    public class CariVM : BaseModel
    {
        public CariVM()
        {
            cariDokumanlar = new List<CariDokumanVM>();
            cariDigerSistemKodlari = new List<CariDigerSistemKoduVM>();
            cariTalimatBilgileri = new List<CariTalimatBilgisiVM>();
        }
        public int calismaTipiID { get; set; }
        public string grupAdi { get; set; }
        public string kodu { get; set; }
        public string adi { get; set; }
        public string modulIDs { get; set; }
        public bool aktif { get; set; }
        public int firmaID { get; set; }
        public bool fState { get; set; }
        public virtual CariMuhasebeVM cariMuhasebe { get; set; }
        public virtual CariKurumsalVM cariKurumsal { get; set; }
        public virtual CariParametreVM cariParametre { get; set; }
        public virtual List<CariDokumanVM> cariDokumanlar { get; set; }
        public virtual List<CariDigerSistemKoduVM> cariDigerSistemKodlari { get; set; }
        public virtual List<CariTalimatBilgisiVM> cariTalimatBilgileri { get; set; }
    }
}

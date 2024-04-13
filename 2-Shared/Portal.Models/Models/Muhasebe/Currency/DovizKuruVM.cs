namespace Portal.Model
{
    public class DovizKuruVM : BaseModel
    {
        public DovizKuruVM()
        {
        }
        public int dovizID { get; set; }
        public DateTime tarih { get; set; }
        public double serbestAlis { get; set; }
        public double serbestSatis { get; set; }
        public double merkezAlis { get; set; }
        public double merkezSatis { get; set; }
    }
}
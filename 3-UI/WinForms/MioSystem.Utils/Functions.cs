using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Windows.Forms;

namespace MioSystem.Utils
{
    public interface IFunctions : IDisposable
    {
        string GenerateUniqueId();
        string ByteArrayToString(byte[] ba);
        byte[] StringToByteArray(string hex);
        int IndexOfInt(int[] arr, int? value);
        DateTime ValidateMinDate(DateTime? dateTime);
        DateTime ValidateMaxDate(DateTime? dateTime);
        DateTime StartDayOfWeek(DateTime dt, DayOfWeek startOfWeek);

        string ReadFromFile(string FName);
        string[] GetAllFileNamesFromFolder(string Path, string Filter);
        string[] ReadLinesFromFile(string FName);
        bool WriteToFile(string Message, string FName);
        string GetDataDirectory();
        string CreateFileAndGetPath(string FileName, byte[] inputBytes);
        void CreateFileAndShow(string FileName, byte[] inputBytes);
        void DeleteAllFilesInFolder(string folderPath);
        string YaziylaTutar(decimal tutar);
        bool TCKimlikDogrulama(string TCKimlikNo, ref string Aciklama);
        string TurkceHarfCevir(string metin);
        void EnterNoveNextControl(object sender, KeyPressEventArgs e);
    }
    public class Functions : IFunctions
    {
        public string GenerateUniqueId()
        {
            long i = 1;
            foreach (byte b in Guid.NewGuid().ToByteArray())
            {
                i *= ((int)b + 1);
            }
            return string.Format("{0:x}", i - DateTime.Now.Ticks);
        }
        public string ByteArrayToString(byte[] ba)
        {
            string hex = string.Empty;
            foreach (byte byteValue in ba)
            {
                hex += byteValue.ToString() + "-";
            }
            return hex;
        }
        public byte[] StringToByteArray(string hex)
        {
            string[] kelimeler = hex.Split('-');
            byte[] bytes = new byte[kelimeler.Length - 1];
            int cnt = 0;
            foreach (string k in kelimeler)
            {
                if (k.Length > 0)
                    bytes[cnt] = Convert.ToByte(k);
                cnt += 1;
            }
            return bytes;
        }
        public int IndexOfInt(int[] arr, int? value)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }
        public DateTime ValidateMinDate(DateTime? dateTime)
        {
            try
            {
                if (dateTime != null && dateTime > (DateTime)SqlDateTime.MinValue && dateTime < (DateTime)SqlDateTime.MaxValue)
                    return (DateTime)dateTime;
                else
                    return (DateTime)SqlDateTime.MinValue;
            }
            catch (Exception ex)
            {
                return (DateTime)SqlDateTime.MinValue;
            }
        }
        public DateTime ValidateMaxDate(DateTime? dateTime)
        {
            try
            {
                if (dateTime != null && dateTime > (DateTime)SqlDateTime.MinValue && dateTime < (DateTime)SqlDateTime.MaxValue)
                    return (DateTime)dateTime;
                else
                    return (DateTime)SqlDateTime.MaxValue;
            }
            catch (Exception ex)
            {
                return (DateTime)SqlDateTime.MaxValue;
            }
        }
        public DateTime StartDayOfWeek(DateTime dt, DayOfWeek startOfWeek)
        {
            int diff = dt.DayOfWeek - startOfWeek;
            if (diff < 0)
            {
                diff += 7;
            }

            return dt.AddDays(-1 * diff).Date;
        }

        public string ReadFromFile(string FName)
        {
            string yazi = "";
            try
            {
                using (StreamReader sr = File.OpenText(GetDataDirectory() + "\\" + FName))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        yazi = yazi + s;
                    }
                }
            }
            catch (Exception)
            {

            }
            return yazi;
        }
        public string[] GetAllFileNamesFromFolder(string Path, string Filter)
        {
            List<string> filenames = new List<string>();
            DirectoryInfo di = new DirectoryInfo(Path);
            FileInfo[] files = di.GetFiles(string.IsNullOrEmpty(Filter) ? "*.*" : Filter).OrderBy(f => f.Name).ToArray();
            foreach (FileInfo file in files)
            {
                filenames.Add(file.Name);
            }
            return filenames.ToArray();
        }
        public string[] ReadLinesFromFile(string FName)
        {
            string[] lines = null;
            try
            {
                string allLines = string.Empty;
                using (StreamReader sr = File.OpenText(GetDataDirectory() + "\\" + FName))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        allLines += allLines.Length == 0 ? s : ";" + s;
                    }
                }
                lines = allLines.Split(';');
            }
            catch (Exception ex)
            {

            }
            return lines;
        }
        public bool WriteToFile(string Message, string FName)
        {
            var filePath = GetDataDirectory() + "\\" + FName;
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            try
            {
                using (var fs = new FileStream(filePath, FileMode.CreateNew))
                {
                    using (var sw = new StreamWriter(fs))
                    {
                        sw.WriteLine(Message);
                        sw.Close();
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public string GetDataDirectory()
        {
            //if (ApplicationDeployment.IsNetworkDeployed)
            //{
            //    return ApplicationDeployment.CurrentDeployment.DataDirectory;
            //}
            //else
            //{
            //    return Application.StartupPath;
            //}
            return Application.StartupPath;
        }
        public string CreateFileAndGetPath(string FileName, byte[] inputBytes)
        {
            if (File.Exists(Application.StartupPath + "\\" + FileName))
                File.Delete(Application.StartupPath + "\\" + FileName);
            File.WriteAllBytes(Application.StartupPath + "\\" + FileName, inputBytes);
            if (File.Exists(Application.StartupPath + "\\" + FileName))
                return Application.StartupPath + "\\" + FileName;
            else
                return string.Empty;
        }
        public void CreateFileAndShow(string FileName, byte[] inputBytes)
        {
            if (File.Exists(Application.StartupPath + "\\" + FileName))
                File.Delete(Application.StartupPath + "\\" + FileName);
            File.WriteAllBytes(Application.StartupPath + "\\" + FileName, inputBytes);
            if (File.Exists(Application.StartupPath + "\\" + FileName))
                Process.Start(Application.StartupPath + "\\" + FileName);
        }
        public void DeleteAllFilesInFolder(string folderPath)
        {
            System.IO.DirectoryInfo di = new DirectoryInfo(folderPath);

            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
        }
        public string YaziylaTutar(decimal tutar)
        {
            string sTutar = tutar.ToString("F2").Replace('.', ','); // Replace('.',',') ondalık ayracının . olma durumu için            
            string lira = sTutar.Substring(0, sTutar.IndexOf(',')); //tutarın tam kısmı
            string kurus = sTutar.Substring(sTutar.IndexOf(',') + 1, 2);
            string yazi = "";

            string[] birler = { "", "Bir", "İki", "Üç", "Dört", "Beş", "Altı", "Yedi", "Sekiz", "Dokuz" };
            string[] onlar = { "", "On", "Yirmi", "Otuz", "Kırk", "Elli", "Altmış", "Yetmiş", "Seksen", "Doksan" };
            string[] binler = { "Katrilyon", "Trilyon", "Milyar", "Milyon", "Bin", "" }; //KATRİLYON'un önüne ekleme yapılarak artırabilir.

            int grupSayisi = 6; //sayıdaki 3'lü grup sayısı. katrilyon içi 6. (1.234,00 daki grup sayısı 2'dir.)
                                //KATRİLYON'un başına ekleyeceğiniz her değer için grup sayısını artırınız.

            lira = lira.PadLeft(grupSayisi * 3, '0'); //sayının soluna '0' eklenerek sayı 'grup sayısı x 3' basakmaklı yapılıyor.            

            string grupDegeri;

            for (int i = 0; i < grupSayisi * 3; i += 3) //sayı 3'erli gruplar halinde ele alınıyor.
            {
                grupDegeri = "";

                if (lira.Substring(i, 1) != "0")
                    grupDegeri += birler[Convert.ToInt32(lira.Substring(i, 1))] + "Yüz"; //yüzler                

                if (grupDegeri == "BirYüz") //biryüz düzeltiliyor.
                    grupDegeri = "Yüz";

                grupDegeri += onlar[Convert.ToInt32(lira.Substring(i + 1, 1))]; //onlar

                grupDegeri += birler[Convert.ToInt32(lira.Substring(i + 2, 1))]; //birler                

                if (grupDegeri != "") //binler
                    grupDegeri += binler[i / 3];

                if (grupDegeri == "BirBin") //birbin düzeltiliyor.
                    grupDegeri = "Bin";

                yazi += grupDegeri;
            }

            if (yazi != "")
                yazi += " TL ";

            int yaziUzunlugu = yazi.Length;

            if (kurus.Substring(0, 1) != "0") //kuruş onlar
                yazi += onlar[Convert.ToInt32(kurus.Substring(0, 1))];

            if (kurus.Substring(1, 1) != "0") //kuruş birler
                yazi += birler[Convert.ToInt32(kurus.Substring(1, 1))];

            if (yazi.Length > yaziUzunlugu)
                yazi += " Kr.";
            else
                yazi += "Sıfır Kr.";

            return yazi;
        }
        public bool TCKimlikDogrulama(string TCKimlikNo, ref string Aciklama)
        {
            bool sonuc = false;
            if (TCKimlikNo.Length == 0)
                return sonuc = true;
            if (TCKimlikNo.Length == 11)
            {
                if (Convert.ToInt32(TCKimlikNo[0].ToString()) != 0) //tc kimlik numaranın ilk hanesi 0 değilse
                {
                    Int64 ATCNO, BTCNO, TcNo;
                    long C1, C2, C3, C4, C5, C6, C7, C8, C9, Q1, Q2;

                    TcNo = Int64.Parse(TCKimlikNo);

                    ATCNO = TcNo / 100;
                    BTCNO = TcNo / 100;

                    C1 = ATCNO % 10; ATCNO = ATCNO / 10;
                    C2 = ATCNO % 10; ATCNO = ATCNO / 10;
                    C3 = ATCNO % 10; ATCNO = ATCNO / 10;
                    C4 = ATCNO % 10; ATCNO = ATCNO / 10;
                    C5 = ATCNO % 10; ATCNO = ATCNO / 10;
                    C6 = ATCNO % 10; ATCNO = ATCNO / 10;
                    C7 = ATCNO % 10; ATCNO = ATCNO / 10;
                    C8 = ATCNO % 10; ATCNO = ATCNO / 10;
                    C9 = ATCNO % 10; ATCNO = ATCNO / 10;
                    Q1 = ((10 - ((((C1 + C3 + C5 + C7 + C9) * 3) + (C2 + C4 + C6 + C8)) % 10)) % 10);
                    Q2 = ((10 - (((((C2 + C4 + C6 + C8) + Q1) * 3) + (C1 + C3 + C5 + C7 + C9)) % 10)) % 10);

                    sonuc = ((BTCNO * 100) + (Q1 * 10) + Q2 == TcNo);
                    Aciklama = sonuc ? "T.C.Kimlik No Doğrulandı." : "Hatalı T.C. Kimlik No";
                }
                else
                    Aciklama = "T.C.Kimlik No 0 ile başlayamaz";
            }
            else
                Aciklama = "T.C.Kimlik No 11 haneli olmalıdır.";
            return sonuc;
        }
        public string TurkceHarfCevir(string metin)
        {
            if (string.IsNullOrEmpty(metin)) return string.Empty;
            string[] türkcekarakterler = { "ı", "ğ", "İ", "Ğ", "ç", "Ç", "ş", "Ş", "ö", "Ö", "ü", "Ü" };
            string[] ingilizce = { "I", "G", "I", "G", "C", "C", "S", "S", "O", "O", "U", "U" };
            //            char[] ingilizce = { 'i', 'g', 'I', 'G', 'c', 'C', 's', 'S', 'o', 'O', 'u', 'U' };
            for (int i = 0; i < türkcekarakterler.Length; i++)
            {
                metin = metin.Replace(türkcekarakterler[i], ingilizce[i]);
            }
            return metin;
        }
        public void EnterNoveNextControl(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SendKeys.Send("{TAB}");
            }
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

    }
}

namespace Portal.Helpers
{
    public class LogManager : IDisposable
    {
        public void WriteLog(string txtLog)
        {
            try
            {
                using (StreamWriter Mesaj = File.AppendText(AppFolder + LogFileName))
                {
                    Mesaj.WriteLine(txtLog);
                    Mesaj.Close();
                }
            }
            catch (Exception ex)
            {
            }
        }

        public string AppFolder
        {
            get { return Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location); }

        }
        public string LogFileName
        {
            get { return "\\" + System.DateTime.Now.Day.ToString().PadLeft(2, '0') + System.DateTime.Now.Month.ToString().PadLeft(2, '0') + System.DateTime.Now.Year.ToString() + "Logs.txt"; }

        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}

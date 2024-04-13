using System.Reflection;


namespace Portal.Win.Forms
{
    public partial class FrmAbout : Form
    {
        public FrmAbout()
        {
            InitializeComponent();
            //string versiyonNumber = string.Empty;
            //if (ApplicationDeployment.IsNetworkDeployed)
            //{
            //    Version ver = ApplicationDeployment.CurrentDeployment.CurrentVersion;
            //    versiyonNumber = string.Format("{0}.{1}.{2}.{3}", ver.Major.ToString().PadLeft(2, '0'), ver.Minor.ToString().PadLeft(2, '0'), ver.Build.ToString().PadLeft(2, '0'), ver.Revision.ToString().PadLeft(2, '0'));
            //}
            //else
            //{
            //    var ver = Assembly.GetExecutingAssembly().GetName().Version;
            //    versiyonNumber = string.Format("{0}.{1}.{2}.{3}", ver.Major.ToString().PadLeft(2, '0'), ver.Minor.ToString().PadLeft(2, '0'), ver.Build.ToString().PadLeft(2, '0'), ver.Revision.ToString().PadLeft(2, '0'));
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

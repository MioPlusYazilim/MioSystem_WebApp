using Portal.Helpers;
using Portal.Model;
using Portal.Win.Forms.Base;

namespace Portal.Win.Forms
{
    public partial class FrmAppBaseFormModul : FrmAppBaseForm
    {
        public int ModulID = 0;
        public FrmAppBaseFormModul()
        {
            InitializeComponent();
        }
        public FrmAppBaseFormModul(object[] args)
        {
            InitializeComponent();
            this.ModulID = new ObjectConvert().ToInt32(args, "ModulID");
            //this.FormCaption = new ObjectConvert().ToString(args, "FormCaption");
            SetformModul();
            OpenMainList();
        }

        void SetformModul()
        {
            switch (ModulID) {
                case 0:
                    this.Text = "Sistem";
                    break;
                case 1:
                    this.Text = "Sistem";
                    break;
                case 2:
                    this.Text = "Ön Muhasebe";
                    break;
                case 3:
                    this.Text = "Vize";
                    break;
                case 4:
                    this.Text = "Uçak Bilet";
                    break;
                case 5:
                    this.Text = "Gemi Tur";
                    break;
                case 6:
                    this.Text = "Kara Tur";
                    break;
                case 7:
                    this.Text = "Otel Konaklama";
                    break;
                case 8:
                    this.Text = "Transfer";
                    break;
                case 9:
                    this.Text = "Araç Kiralama";
                    break;
                case 10:
                    this.Text = "Kongre Kayıt";
                    break;
                case 11:
                    this.Text = "Diğer İşlemler";
                    break;
                case 12:
                    this.Text = "Mice";
                    break;
                case 13:
                    this.Text = "Tren-Otobüs Bilet";
                    break;
                case 14:
                    this.Text = "Restaurant Eğlence";
                    break;
            }
        }
        void OpenMainList()
        {
            NavigationRole yetki = loginUser.navigationAuthories.FirstOrDefault(x => x.modulID == ModulID && x.formType == 8);
            if (yetki == null)
                return;
            if(yetki.allowList==false)
                return;
            using(CheckForm chForm = new CheckForm())
            {
                object[] args ={new CustomDataObject("FormID", 0), 
                                new CustomDataObject("FormCaption", "SQLQueryManager") };

                //XtraForm designer = (XtraForm)Activator.CreateInstance(new CheckForm().GetFormTypeFromDll("FrmSQLQueryManager"), (object)args);
                //designer.MdiParent = Application.OpenForms[0];
                //designer.Show();
            }
        }
    }
}
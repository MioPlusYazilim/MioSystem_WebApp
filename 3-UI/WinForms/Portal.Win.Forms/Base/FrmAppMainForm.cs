using DevExpress.LookAndFeel;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Portal.Model;
using Portal.Model.Utils;
using Portal.Helpers;
using Portal.Win.DxUtils;
using Portal.Win.Utils;
using System.Data;
using System.Diagnostics;
using Portal.Win.Forms.Base;
using DevExpress.XtraBars.Ribbon;
using System.Windows.Controls.Ribbon;

namespace Portal.Win.Forms
{
    public partial class FrmAppMainForm : FrmAppBaseForm
    {
        public static DateTime SQLServerDate = DateTime.Now;
        public static bool RefreshDefaults = false;
        public object[] margs;

        public FrmAppMainForm()
        {
            InitializeComponent();
        }
        public void SetLoginUserInfo()
        {
            //barButtonReportDesigner.Visibility = (loginUser.authoryGroup == 1 && loginUser.authoryLevel == 3) ? BarItemVisibility.Always : BarItemVisibility.Never;

            DevExpress.LookAndFeel.UserLookAndFeel.Default.StyleChanged += Default_StyleChanged;

            var modulList = loginUser.mainMenuNavigations.Select(s => s.id).Distinct().ToList();
            foreach (RibbonPage ripages in ribbonControlAppMain.Pages)
            {
                if (Convert.ToInt32(ripages.Tag) > 1)
                    ripages.Visible = modulList.Contains(Convert.ToInt32(ripages.Tag));
            }

            OpenModuleMainForms(0);
            //barStaticItemCompanyName.Caption = loginUser.companyCode;
            //barStaticItemKullanici.Caption = loginUser.fullName;
            //barStaticItemLoginDate.Caption = DateTime.Now.ToShortDateString();
            //barStaticItemLoginTime.Caption = DateTime.Now.ToShortTimeString();
            ////barStaticItemVersiyon.Caption = LoginUser.versionNumber;
            //if (loginUser.displayLanguage=="en-EN")
            //{
            //    barButtonSettings.Caption = "Settings";
            //    barButtonKurlar.Caption = "Currency (Exchange)";
            //    barSubKullanici.Caption = "User";
            //    barBottonInfo.Caption = "About";
            //    BarBottonRefresh.Caption = "Refresh Data";
            //    barButtonReportDesigner.Caption = "Report Design";
            //    barButtonYetkiYenile.Caption = "Refresh Authorities";
            //    barButtonSifreDegistir.Caption = "Change Password";
            //    barButtonItem4.Caption = "Refresh All Data";
            //    barButtonItemCariGuncelle.Caption = "Customer Refresh Data";
            //    barButtonKullaniciDegistir.Caption = "Change User";
            //    barButtonItem6.Caption = "Change Company";
            //    barStaticItem2.Caption = "User Name:";
            //    barStaticItem3.Caption = "Login Name:";
            //    barStaticItem4.Caption = "Company Name:";
            //    barButtonItem7.Caption = "Version Control";
            //    barButtonItem3.Caption = "Log View";
            //}
        }



        private void MainForm_Load(object sender, EventArgs e)
        {
            SetLoginUserInfo();
        }


        void SaveUserSkin()
        {
            try
            {
                if (loginUser.winTheme != DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName)
                {
                    loginUser.winTheme = DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName;
                    if (string.IsNullOrEmpty(UserLookAndFeel.Default.ActiveSvgPaletteName) == false)
                        loginUser.winTheme += ";" + UserLookAndFeel.Default.ActiveSvgPaletteName;
                    // Skin Kaydetme burada olacak
                }
            }
            catch (Exception ex)
            {
            }
        }
        private void Default_StyleChanged(object sender, EventArgs e)
        {
            SaveUserSkin();
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (new DxFunctions().FlyBoxOnay(this, "Onay", "Program kapatılacak\nOnaylıyor musunuz?") != System.Windows.Forms.DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
            catch
            {
            }
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                string strProcessName = Process.GetCurrentProcess().ProcessName;
                foreach (System.Diagnostics.Process p in System.Diagnostics.Process.GetProcesses())
                    if (p.ProcessName == strProcessName)
                        p.Kill();
                this.Dispose();
            }
            catch
            {
            }
        }




        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void barButtonReportDesigner_ItemClick(object sender, ItemClickEventArgs e)
        {
            //if (!LoginUser.isAdmin) return;
            //bool bulundu = false;

            //foreach (Form OpenForm in Application.OpenForms)
            //{
            //    if (OpenForm is XtraForm)
            //    {
            //        if (OpenForm.GetType() == new CheckForm().GetFormTypeFromDll("FrmReportDesigner"))
            //        {
            //            bulundu = true;
            //            ((XtraForm)OpenForm).BringToFront();
            //            break;
            //        }

            //    }
            //}
            //if (bulundu) return;
            //object[] args ={new CustomDataObject("FormID",0),
            //                new CustomDataObject("FormCaption","Rapor Dizayn")};

            //XtraForm designer = (XtraForm)Activator.CreateInstance(new CheckForm().GetFormTypeFromDll("FrmReportDesigner"), (object)args);
            //designer.MdiParent = Application.OpenForms[0];
            //designer.Show();
        }

        private void barButtonKurlar_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void barButtonSettings_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonYetkiYenile_ItemClick(object sender, ItemClickEventArgs e)
        {
            //LoginUser.WorkingPath = AppDomain.CurrentDomain.BaseDirectory;
            //LoginUser.UserMenuList = new MioMainSpContext().MainMenuListForUser(LoginUser.userID, LoginUser.officeID, LoginUser.Version == 0 ? 1 : LoginUser.Version);
            //LoginUser.UserYetkiList = new MioMainSpContext().MainNavigationMListForUser(LoginUser.userID, LoginUser.officeID, LoginUser.Version == 0 ? 1 : LoginUser.Version);
            //SetLoginUserInfo();
        }

        private void barButtonSifreDegistir_ItemClick(object sender, ItemClickEventArgs e)
        {
            //using (FrmUserSifre Sifre = new FrmUserSifre())
            //{
            //    Sifre.ShowDialog(this);
            //}
        }

        private void barButtonKullaniciDegistir_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (FrmLogin login = new FrmLogin())
            {
                if (login.ShowDialog(this) == DialogResult.OK)
                {
                    SetLoginUserInfo();
                }
            }
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            //using (FrmShowMessage mform = new FrmShowMessage(true))
            //{
            //    using (PopUpDialog pd = new PopUpDialog(this, mform))
            //        pd.ShowDialog();
            //}
        }


        private void barButtonAbout_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmAbout AB = new FrmAbout();
            AB.ShowDialog();
        }

        private void barButtonDashBoardDesigner_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowDashBoardViewer();
            //ShowDashBoardDesigner();
        }
        private void ShowDashBoardDesigner()
        {
            //    if (!LoginUser.isAdmin) return;
            //    bool bulundu = false;

            //    foreach (Form OpenForm in Application.OpenForms)
            //    {
            //        if (OpenForm is XtraForm)
            //        {
            //            if (OpenForm.GetType() == new CheckForm().GetFormTypeFromDll("FrmDashBoardDesigner"))
            //            {
            //                bulundu = true;
            //                ((XtraForm)OpenForm).BringToFront();
            //                break;
            //            }
            //        }
            //    }
            //    if (bulundu) return;
            //    object[] args ={new CustomDataObject("FormID",0),
            //                    new CustomDataObject("FormCaption","DashBoard Dizayn")};


            //XtraForm designer = (XtraForm)Activator.CreateInstance(new CheckForm().GetFormTypeFromDll("FrmDashBoardDesigner"), (object)args);
            //    designer.MdiParent = Application.OpenForms[0];
            //    designer.Show();
        }
        private void ShowDashBoardViewer()
        {

            //if (!LoginUser.isAdmin) return;
            //bool bulundu = false;

            //foreach (Form OpenForm in Application.OpenForms)
            //{
            //    if (OpenForm is XtraForm)
            //    {
            //        if (OpenForm.GetType() == new CheckForm().GetFormTypeFromDll("FrmDashBoardViewer"))
            //        {
            //            bulundu = true;
            //            ((XtraForm)OpenForm).BringToFront();
            //            break;
            //        }

            //    }
            //}

            //if (bulundu) return;
            //object[] args ={new CustomDataObject("FormID", 0), 
            //                new CustomDataObject("FormCaption", "DashBoard") };

            //XtraForm designer = (XtraForm)Activator.CreateInstance(new CheckForm().GetFormTypeFromDll("FrmDashBoardViewer"), (object)args);
            //designer.MdiParent = Application.OpenForms[0];
            //designer.Show();
        }

        private void skinDropDownButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            //bool bulundu = false;

            //foreach (Form OpenForm in Application.OpenForms)
            //{
            //    if (OpenForm is XtraForm)
            //    {
            //        if (OpenForm.GetType() == new CheckForm().GetFormTypeFromDll("FrmMailKontrol"))
            //        {
            //            bulundu = true;
            //            ((XtraForm)OpenForm).BringToFront();
            //            break;
            //        }

            //    }
            //}

            //if (bulundu) return;
            //object[] args ={new CustomDataObject("FormID", 0), 
            //                new CustomDataObject("FormCaption", "Mail Kontrol") };

            //XtraForm designer = (XtraForm)Activator.CreateInstance(new CheckForm().GetFormTypeFromDll("FrmMailKontrol"), (object)args);
            //designer.MdiParent = Application.OpenForms[0];
            //designer.Show();
        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            //bool bulundu = false;

            //foreach (Form OpenForm in Application.OpenForms)
            //{
            //    if (OpenForm is XtraForm)
            //    {
            //        if (OpenForm.GetType() == new CheckForm().GetFormTypeFromDll("FrmSmsKontrol"))
            //        {
            //            bulundu = true;
            //            ((XtraForm)OpenForm).BringToFront();
            //            break;
            //        }

            //    }
            //}

            //if (bulundu) return;
            //object[] args ={new CustomDataObject("FormID", 0), 
            //                new CustomDataObject("FormCaption", "Sms Kontrol") };

            //XtraForm designer = (XtraForm)Activator.CreateInstance(new CheckForm().GetFormTypeFromDll("FrmSmsKontrol"), (object)args);
            //designer.MdiParent = Application.OpenForms[0];
            //designer.Show();
        }

        private void barButtonItemSqlQuery_ItemClick(object sender, ItemClickEventArgs e)
        {
            //if (!LoginUser.isAdmin) return;
            //bool bulundu = false;

            //foreach (Form OpenForm in Application.OpenForms)
            //{
            //    if (OpenForm is XtraForm)
            //    {
            //        if (OpenForm.GetType() == new CheckForm().GetFormTypeFromDll("FrmSQLQueryManager"))
            //        {
            //            bulundu = true;
            //            ((XtraForm)OpenForm).BringToFront();
            //            break;
            //        }

            //    }
            //}

            //if (bulundu) return;
            //object[] args ={new CustomDataObject("FormID", 0), 
            //                new CustomDataObject("FormCaption", "SQLQueryManager") };

            //XtraForm designer = (XtraForm)Activator.CreateInstance(new CheckForm().GetFormTypeFromDll("FrmSQLQueryManager"), (object)args);
            //designer.MdiParent = Application.OpenForms[0];
            //designer.Show();
        }

        private void ribbonControlAppMain_SelectedPageChanged(object sender, EventArgs e)
        {
            DevExpress.XtraBars.Ribbon.RibbonControl ribbon = (DevExpress.XtraBars.Ribbon.RibbonControl)sender;
            OpenModuleMainForms(Convert.ToInt32(ribbon.SelectedPage.Tag));
        }
        void OpenModuleMainForms(int ModulID)
        {
            bool bulundu = false;
            foreach (Form OpenForm in Application.OpenForms)
            {
                if (OpenForm is FrmAppBaseFormModul)
                {
                    if(((FrmAppBaseFormModul)OpenForm).ModulID == ModulID)
                    {
                        bulundu = true;
                        ((FrmAppBaseFormModul)OpenForm).BringToFront();
                        return;
                    }
                }
            }

            object[] args ={new CustomDataObject("ModulID", ModulID), 
                            new CustomDataObject("FormCaption", "") };
            FrmAppBaseFormModul frmAppBaseFormModul = new FrmAppBaseFormModul(args);
            frmAppBaseFormModul.MdiParent = this;
            frmAppBaseFormModul.Show();
        }
    }
}

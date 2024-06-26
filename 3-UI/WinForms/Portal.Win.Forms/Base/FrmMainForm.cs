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

namespace Portal.Win.Forms
{
    public partial class FrmMainForm : FrmAppBaseForm
    {
        public static DateTime SQLServerDate = DateTime.Now;
        public static bool RefreshDefaults = false;
        public object[] margs;

        public FrmMainForm()
        {
            InitializeComponent();
        }
        public void SetLoginUserInfo()
        {
            // barButtonSettings.Visibility = LoginUser.Admin ? BarItemVisibility.Always : BarItemVisibility.Never;
            barButtonReportDesigner.Visibility = (loginUser.authoryGroup == 1 && loginUser.authoryLevel == 3) ? BarItemVisibility.Always : BarItemVisibility.Never;
            //UsernavButton.Caption = LoginUser.PersonelName;

            DevExpress.LookAndFeel.UserLookAndFeel.Default.StyleChanged += Default_StyleChanged;
            barStaticItemCompanyName.Caption = loginUser.companyCode;
            barStaticItemKullanici.Caption = loginUser.fullName;
            barStaticItemLoginDate.Caption = DateTime.Now.ToShortDateString();
            barStaticItemLoginTime.Caption = DateTime.Now.ToShortTimeString();
            //barStaticItemVersiyon.Caption = LoginUser.versionNumber;
            if (loginUser.displayLanguage=="en-EN")
            {
                barButtonSettings.Caption = "Settings";
                barButtonKurlar.Caption = "Currency (Exchange)";
                barSubKullanici.Caption = "User";
                barBottonInfo.Caption = "About";
                BarBottonRefresh.Caption = "Refresh Data";
                barButtonReportDesigner.Caption = "Report Design";
                barButtonYetkiYenile.Caption = "Refresh Authorities";
                barButtonSifreDegistir.Caption = "Change Password";
                barButtonItem4.Caption = "Refresh All Data";
                barButtonItemCariGuncelle.Caption = "Customer Refresh Data";
                barButtonKullaniciDegistir.Caption = "Change User";
                barButtonItem6.Caption = "Change Company";
                barStaticItem2.Caption = "User Name:";
                barStaticItem3.Caption = "Login Name:";
                barStaticItem4.Caption = "Company Name:";
                barButtonItem7.Caption = "Version Control";
                barButtonItem3.Caption = "Log View";
            }
            createBarMenu(barMainMenu);
        }

        

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetLoginUserInfo();
        }
        
        #region Default Menu ayarları

        #region BarMenuCreate
        private void createBarMenu(object Mymenu)
        {
            if (Mymenu.GetType() == typeof(DevExpress.XtraBars.Bar))
            {
                BarSubItem BarMainItem = null;
                BarSubItem MyBarSub = null;
                BarListItem MyItem = null;
                Bar MyBar = (DevExpress.XtraBars.Bar)Mymenu;
                MyBar.ItemLinks.Clear();

                foreach (var lvl0 in loginUser.mainMenuNavigations.OrderBy(o => o.menuOrder))
                {
                    BarMainItem = new BarSubItem();
                    BarMainItem.ImageIndex = 0;
                    BarMainItem.PaintStyle = BarItemPaintStyle.Caption;
                    BarMainItem.Caption = lvl0.menuName;
                    BarMainItem.Tag = lvl0.id;

                    foreach (var lvl1 in lvl0.items.OrderBy(o => o.menuOrder))
                    {
                        MyBarSub = new BarSubItem();
                        MyBarSub.Caption = lvl1.menuName;
                        MyBarSub.Tag = lvl1.id;

                        foreach (var lvl2 in lvl1.items.OrderBy(o => o.menuOrder))
                        {
                            MyItem = new BarListItem();
                            MyItem.Strings.Add(lvl2.menuName);
                            MyItem.Tag = lvl2.menuTag.ToString() + ";" + lvl2.formType.ToString();
                            MyItem.ItemClick += myBarMenuItem_ItemClick;
                            MyBarSub.ItemLinks.Add(MyItem);
                            barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { MyItem });
                        }
                        BarMainItem.ItemLinks.Add(MyBarSub);
                        barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { MyBarSub });
                    }
                    barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { BarMainItem });
                    MyBar.ItemLinks.Add(BarMainItem);
                    BarMainItem.Links[0].BeginGroup = true;
                }
            }
        }

        private void myBarMenuItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            BarListItem mybItem = e.Item as BarListItem;
            if (mybItem.ItemIndex < 0) return;
            int MenuID = Convert.ToInt32(mybItem.Tag.ToString().Split(';')[0]);
            int FormType = Convert.ToInt32(mybItem.Tag.ToString().Split(';')[1]);
            OpenMenuForm(MenuID, FormType);
        }
        void OpenMenuForm(int MenuID, int FormType)
        {
            NavigationRole MyMenu = loginUser.navigationAuthories.FirstOrDefault(x => x.menuTag == MenuID);
            if (MyMenu != null)
            {
                if (MyMenu.allowList)
                {
                    //MainMenuFlyoutPanel.HidePopup();
                    object[] args ={new CustomDataObject("MenuID",MenuID),
                                new CustomDataObject("FormID",0),
                                new CustomDataObject("FormType",FormType),
                                new CustomDataObject("FormCaption",(MyMenu.formType==8 && FormType==2)? MyMenu.editFormCaption: MyMenu.formCaption),
                                new CustomDataObject("NavigationAuthory",MyMenu)};
                    new MioUtils().ActivateMyForm(args);
                }
            }
        }
        #endregion

        #endregion
        void SaveUserSkin()
        {
            try
            {
                if (loginUser.winTheme!= DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName)
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
            bool bulundu = false;
            foreach (Form OpenForm in Application.OpenForms)
            {
                if (OpenForm is XtraForm)
                {
                    if (OpenForm.GetType() == new CheckForm().GetFormTypeFromDll("FrmSettings"))
                    {
                        bulundu = true;
                        ((XtraForm)OpenForm).BringToFront();
                        break;
                    }

                }
            }
            if (bulundu == false)
            {
                FrmSettings frmSettings = new FrmSettings();
                frmSettings.MdiParent = this;
                frmSettings.Show();
            }
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

        private void FrmMainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Control && e.KeyCode == Keys.Q)
            {
                barEditItemSearch.Links[0].Focus();
            }
        }

        private void barButtonItemCariGuncelle_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
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
    }
}

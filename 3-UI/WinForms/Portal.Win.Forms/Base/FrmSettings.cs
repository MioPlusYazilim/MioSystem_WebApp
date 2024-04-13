using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraPrinting;
using Portal.Data.Services.GlobalContextService;
using Portal.Helpers;
using Portal.Model;
using Portal.Win.DxUtils;
using Portal.Win.Forms.Base;
using Portal.Win.Utils;
using System.Data;

namespace Portal.Win.Forms
{
    public partial class FrmSettings : FrmBaseForm
    {
        string HeaderlabelText = string.Empty;
        DxFunctions dxFunctions;
        LoginResponse loginResponse;

        public List<BarButtonItem> singleButtonList = new List<BarButtonItem>();
        public List<BarButtonItem> yazdirButtonList = new List<BarButtonItem>();
        public List<BarButtonItem> ekIslemButtonList = new List<BarButtonItem>();
        public List<BarSubItem> ekIslemSubItemList = new List<BarSubItem>();
        public List<CustomDataObject> ekIslemSubItemButtonList = new List<CustomDataObject>();

        public FrmSettings()
        {
            InitializeComponent();
            //this.Size = new Size(1000, 500);
            xtraTabControlForms.SelectedTabPage = xtraTabPageList;
            xtraTabControlForms.ShowTabHeader = DefaultBoolean.False;
            dxFunctions= new DxFunctions();
            loginResponse =  LoginResponse.GetLoginResponse();
        }


        void SetQuickMenuTiles()
        {
            TileItem MyTile;
            foreach (var item in loginResponse.settingsMenuNavigations)
            {
                try
                {
                    MyTile = new TileItem();
                    MyTile.Tag = item.id;
                    MyTile.ItemSize = TileItemSize.Medium;

                    TileItemElement tileCaption = new TileItemElement();
                    tileCaption.Text = item.menuName;
                    //tileCaption.Image = ImgQMenu.Images[item.iconName];
                    tileCaption.TextAlignment = TileItemContentAlignment.BottomLeft;
                    tileCaption.ImageAlignment = TileItemContentAlignment.TopCenter;

                    MyTile.Elements.Add(tileCaption);
                    //MyTile.AppearanceItem.Normal.BackColor = DbNull.ToInt32(item.GIconIndex) == 0 ? Color.Green : ((Bitmap)ImgQMenu.Images[Convert.ToInt32(item.GIconIndex)]).GetPixel(1, 1);
                    MyTile.AppearanceItem.Normal.BackColor = Color.Gray;
                    MyTile.AppearanceItem.Normal.Options.UseBackColor = true;
                    //MyTile.AppearanceItem.Normal.BorderColor = MyTile.AppearanceItem.Normal.BackColor;
                    MyTile.AppearanceItem.Normal.BorderColor = Color.DarkGray;
                    MyTile.AppearanceItem.Normal.Options.UseBorderColor = true;
                    MyTile.ItemClick += MyTile_ItemClick;

                    SettingsTileGroup.Items.Add(MyTile);
                }
                catch (Exception ex)
                {
                }
            }
        }

        private void MyTile_ItemClick(object sender, TileItemEventArgs e)
        {
            SetMenu(Convert.ToInt32(e.Item.Tag));
            this.Text = e.Item.Text;
            HeaderlabelControl.Text = "";
            panelControlFormContainer.Controls.Clear();
            tempGridControl.DataSource = null;
            tempGridView.Columns.Clear();
            xtraTabControl1.SelectedTabPage = SettingsDetailXtraTabPage;
        }

        public void SetMenu(int MenuID)
        {

            MainMenuaccordionControl.Elements.Clear();
            AccordionControlElement ParentGroup;
            AccordionControlElement ChildItem;

            foreach (var item in loginResponse.settingsMenuNavigations.FirstOrDefault(x => x.id == MenuID).items)
            {
                ParentGroup = MainMenuaccordionControl.GetElements().Where(x => x.Style==ElementStyle.Group && Convert.ToInt32(x.Tag) == item.id).FirstOrDefault();
                if (ParentGroup == null)
                {
                    ParentGroup = new AccordionControlElement();
                    ParentGroup.Text = item.menuName;
                    ParentGroup.Tag = item.id;
                    MainMenuaccordionControl.Elements.Add(ParentGroup);
                }
                foreach (var child in item.items)
                {
                    ChildItem = new AccordionControlElement();
                    ChildItem.Text = child.menuName;
                    ChildItem.Tag = child.menuTag;
                    ChildItem.Style = ElementStyle.Item;
                    ChildItem.Click += new EventHandler(accordionControlElement_Click);
                    ParentGroup.Elements.Add(ChildItem);
                }
            }
        }

        private void accordionControlElement_Click(object sender, EventArgs e)
        {
            try
            {
                string FormDll = string.Empty;
                string FormName = string.Empty;
                int fMenuID = 0;
                int fFormType = 0;

                NavigationRole MyMenu = loginResponse.navigationAuthories.FirstOrDefault(x => x.menuTag == Convert.ToInt32(((AccordionControlElement)sender).Tag));
                if (MyMenu == null) return;
                FormName = MyMenu.editFormName;
                FormDll = "Portal.Win.Forms";
                fMenuID = MyMenu.menuTag;
                fFormType = MyMenu.formType;
                panelControlFormContainer.Controls.Clear();
                tempGridControl.DataSource = null;

                object[] args = {new CustomDataObject("MenuID", fMenuID),
                              new CustomDataObject("FormType", fFormType),
                              new CustomDataObject("NavigationAuthory",MyMenu)};

                if (fMenuID > 0)
                {
                    xtraTabControlForms.SelectedTabPage = xtraTabPageList;

                    Type tForm = new CheckForm().GetFormTypeFromDll(FormName);
                    if (tForm != null)
                    {
                        FrmBaseFormEdit baseForm = new CheckForm().OpenForm<FrmBaseFormEdit>(args);
                        panelControlFormContainer.Height = baseForm.ClientSize.Height + 10;
                        baseForm.TopLevel = false;
                        baseForm.TopMost = true;
                        baseForm.menugoster = false;
                        panelControlFormContainer.Controls.Add(baseForm);
                        baseForm.Show();
                        RefreshGridDataSource(baseForm);
                    }
                    HeaderlabelText = ((AccordionControlElement)sender).Text;
                    HeaderlabelControl.Text = HeaderlabelText;
                    setBarButtons(false, MyMenu);
                }
            }
            catch(Exception ex)
            {
                MessageManager.MessageBoxHata("Dikkat", new GlobalContextService().GetSystemMessageValue("FormProcessError").ToString(),  ex.Message);
            }
        }

        public void RefreshGridDataSource(FrmBaseFormEdit oForm)
        {
            tempGridView.Columns.Clear();
            BindingSource source = new BindingSource();
            source.DataSource = oForm.GetList(); 
            tempGridControl.DataSource = source;
            dxFunctions.SetcustomColumns(tempGridView, oForm._cols);
            dxFunctions.SetGrid(tempGridView, false);
            tempGridControl.RefreshDataSource();
        }
        private void tempGridView_DoubleClick(object sender, EventArgs e)
        {

            dxFunctions.ShowWaitForm("");
            try
            {
                GridView view = sender as GridView;
                GridHitInfo hitInfo = view.CalcHitInfo((e as MouseEventArgs).Location);
                if (hitInfo.InRowCell)
                {
                    int rowHandle = view.FocusedRowHandle;
                    if (view.IsDataRow(rowHandle))
                    {
                        var myform = (FrmBaseFormEdit)panelControlFormContainer.Controls[0];
                        myform.FormID = Convert.ToInt32(view.GetRowCellValue(view.FocusedRowHandle, "id"));
                        myform.SetFormEntity();
                        xtraTabControlForms.SelectedTabPage = xtraTabPageEditForm;
                        setBarButtons(true, myform.yetki);
                    }
                }
            }
            catch (Exception ex)
            {
            }
            dxFunctions.CloseWaitForm();
        }

        private void MainFormYeni_Load(object sender, EventArgs e)
        {
            xtraTabControl1.ShowTabHeader = DefaultBoolean.False;
            SettingsTileControl.Text = loginResponse.companyCode + " Sistem Ayarları";
            SetQuickMenuTiles();
            this.ForceRefresh();
        }

        private void accordionControlElementAneMenu_Click(object sender, EventArgs e)
        {
            this.Text = "Ayarlar";
            HeaderlabelControl.Text = "";
            panelControlFormContainer.Controls.Clear();
            tempGridControl.DataSource = null;
            tempGridView.Columns.Clear();
            xtraTabControl1.SelectedTabPage = TileMenuXtraTabPage;
        }

        private void FrmSettings_KeyDown(object sender, KeyEventArgs e)
        {
            if (panelControlFormContainer.Controls.Count > 0)
            {
                FrmBaseFormEdit edit = (FrmBaseFormEdit)panelControlFormContainer.Controls[0];
                switch (e.KeyCode)
                {
                    case Keys.F2: edit.FormYeni(); break;
                    case Keys.F3: edit.FormSil(); break;
                    case Keys.F4: edit.FormKaydet(); break;
//                    case Keys.F5: edit.FormYenile(); break;
//                    case Keys.F6:
//                        edit.btn
 //             BarSubItemLink link = e.Item.Links[0] as BarSubItemLink;
//                        link.OpenMenu(); ; break;
                }
                //MessageBox.Show(e.KeyCode.ToString());
            }
        }

        private void BarBtnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (panelControlFormContainer.Controls.Count == 0) return;
            ((FrmBaseFormEdit)panelControlFormContainer.Controls[0]).FormYeni();
            xtraTabControlForms.SelectedTabPage = xtraTabPageEditForm;
            setBarButtons(true, ((FrmBaseFormEdit)panelControlFormContainer.Controls[0]).yetki);
        }

        private void BarBtnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (panelControlFormContainer.Controls.Count == 0) return;
            var baseForm = (FrmBaseFormEdit)panelControlFormContainer.Controls[0];
            if (baseForm.FormKaydet())
            {
                baseForm.GetList();
                RefreshGridDataSource(baseForm);
                HeaderlabelControl.Text = HeaderlabelText;
            }
        }

        private void BarBtnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (panelControlFormContainer.Controls.Count == 0) return;
            var baseForm = (FrmBaseFormEdit)panelControlFormContainer.Controls[0];
            baseForm.FormSil();
            baseForm.GetList();
            RefreshGridDataSource(baseForm);
            xtraTabControlForms.SelectedTabPage = xtraTabPageList;
        }
        private void BarBtnFind_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (panelControlFormContainer.Controls.Count == 0) return;
            ((FrmBaseFormEdit)panelControlFormContainer.Controls[0]).FormAra();
        }
        private void panelControlFormContainer_ControlAdded(object sender, ControlEventArgs e)
        {
            var myform = (FrmBaseFormEdit)panelControlFormContainer.Controls[0];
            myform.TopLevel = false;
            myform.TopMost = true;
            myform.FormBorderStyle= FormBorderStyle.None;
            myform.Dock = DockStyle.Fill;
            myform.Show();
        }

        void setBarButtons(bool set, NavigationRole yetki)
        {
            // BarBtnNew.Enabled = set;
            BarBtnSave.Visibility = set ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            BarBtnDelete.Visibility = set ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            barBtnPrint.Visibility = set ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            BarBtnExtra.Visibility = set ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            barButtonItemRefresh.Visibility = set ? DevExpress.XtraBars.BarItemVisibility.Never : DevExpress.XtraBars.BarItemVisibility.Always;
            if (yetki.allowPrint)
                barButtonItemPrintList.Visibility = set ? DevExpress.XtraBars.BarItemVisibility.Never : DevExpress.XtraBars.BarItemVisibility.Always;
            else
                barButtonItemPrintList.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

            if (yetki.editFormName == "FrmCariler")
                barBtnCariEfaturaKontrol.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            else
                barBtnCariEfaturaKontrol.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
        }

        private void panelControlFormContainer_ControlRemoved(object sender, ControlEventArgs e)
        {
            BarBtnFind.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            bar1.Visible = true;
        }


        private void barButtonItemCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (panelControlFormContainer.Controls.Count > 0)
            {
                xtraTabControlForms.SelectedTabPage = xtraTabPageList;
                setBarButtons(false, ((FrmBaseFormEdit)panelControlFormContainer.Controls[0]).yetki);
            }
        }

        private void barButtonItemRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (panelControlFormContainer.Controls.Count > 0)
            {
                FrmBaseFormEdit baseForm = (FrmBaseFormEdit)panelControlFormContainer.Controls[0];
                baseForm.GetList();
                RefreshGridDataSource(baseForm);
            }
        }
        private void BarBtnCopy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (panelControlFormContainer.Controls.Count == 0) return;
            ((FrmBaseFormEdit)panelControlFormContainer.Controls[0]).FormKopya();
            HeaderlabelControl.Text = HeaderlabelText + " (KOPYA)";
        }

        private void barButtonItemPrintList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (PrintingSystem ps = new PrintingSystem())
            {
                using (PrintableComponentLink link = new PrintableComponentLink(ps))
                {
                    link.Component = tempGridControl;
                    link.CreateDocument();
                    ps.PreviewFormEx.WindowState = FormWindowState.Maximized;
                    ps.PreviewFormEx.ShowDialog();
                }
            }
        }
    }
}

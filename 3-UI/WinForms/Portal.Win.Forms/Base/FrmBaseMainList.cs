using DevExpress.Data.Filtering;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraPrinting;
using Portal.Helpers;
using Portal.Model;
using Portal.Win.DxUtils;
using Portal.Win.Forms.Base;
using System.Data;
using System.Data.SqlClient;

namespace Portal.Win.Forms
{
    public partial class FrmBaseMainList : FrmBaseForm
    {
        public int MenuID;
        public int FormID = 0;
        public NavigationRole yetki;
        string FormCaption = string.Empty;
        public bool btnYeni = true;
        public int SelectedID = 0;
        public string viewName = string.Empty;
        public string KeyField = "ID";
        public string SortExp = "";
        public CriteriaOperator filterString = string.Empty;

        //UserViewLayouts UsrLayout;
        public SqlCommand TempCommand;
        public DataTable TempTable;
        public DxFunctions dxFunctions;
        MioUtils mutils;
        public FrmBaseMainList()
        {
            InitializeComponent();
            dxFunctions = new DxFunctions();
            mutils = new MioUtils();
        }
        public FrmBaseMainList(object[] args)
        {
            dxFunctions = new DxFunctions();
            mutils = new MioUtils();
            this.MenuID = new ObjectConvert().ToInt32(args, "MenuID");
            this.FormCaption = new ObjectConvert().ToString(args, "FormCaption");
            this.yetki = (NavigationRole)new ObjectConvert().ToObject(args, "NavigationAuthory");
            TempCommand = new SqlCommand();
            InitializeComponent();
            barBtnNew.Enabled = btnYeni;
            barBtnPrint.Enabled = this.yetki.allowPrint;
            SetFormCaption();
            if (loginUser.displayLanguage == "en-EN")
            {
                barBtnPrint.Caption = "Print";
                barBtnRefresh.Caption = "Refresh";
                barBtnEdit.Caption = "Edit";
                barBtnNew.Caption = "New";
                BarBtnClose.Caption = "Close";
            }
        }

        public void CariHareketGizle()
        {
            barToggleSwitchTopluGuncelleme.Visibility = BarItemVisibility.Never;
        }
        public void SetFaturaYeni()
        {
            barBtnNew.Visibility = BarItemVisibility.Never;
            barSubItemYeni.Visibility = BarItemVisibility.Always;
        }
        public void SetFormResources()
        {
        }
        public void ButonEkleBarMenu(BarButtonItem btn)
        {
            btn.AllowGlyphSkinning = DefaultBoolean.True;
            BarMenuMgn.Items.Add(btn);
            bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(btn)});
        }
        public void SetFormCaption()
        {
            this.Text = FormCaption;
        }

        public virtual void LoadList()
        {
            
            //mutils.ShowWaitForm("Liste Yükleniyor");
            //try
            //{
            //    if (viewName.Length > 0 && LoginUser.ConnStr.Length > 0)
            //    {
            //        xpoLoader = new XPODataLoader(LoginUser.ConnStr, viewName);
            //        tempGridControl.DataSource = xpoLoader.FillGridXPO(filterString, KeyField);
            //        tempGridControl.ForceInitialize();
            //        new DxFunctions().SetGrid(tempGridView, false);
            //    }
            //    mutils.CloseWaitForm();
            //}
            //catch (Exception ex)
            //{
            //    mutils.CloseWaitForm();
            //}
        }


        public virtual void LoadListAdo()
        {
            //mutils.ShowWaitForm("Liste Yükleniyor");
            //try
            //{
            //    if (viewName.Length > 0 && LoginUser.ConnStr.Length > 0)
            //    {
            //        using (SqlConnection SQLConnect = new SqlConnection(LoginUser.ConnStr))
            //        {
            //            SQLConnect.Open();
            //            TempCommand.Connection = SQLConnect;
            //            using (SqlDataAdapter da = new SqlDataAdapter(TempCommand))
            //            {
            //                TempTable = new DataTable();
            //                da.Fill(TempTable);
            //                tempGridControl.DataSource = TempTable;
            //            }
            //        }
            //        new DxFunctions().SetGrid(tempGridView, false);
            //    }
            //    mutils.CloseWaitForm();
            //}
            //catch (Exception)
            //{
            //    mutils.CloseWaitForm();
            //}
        }

        public virtual void LoadListAdo(string QueryStr)
        {
            //mutils.ShowWaitForm("Liste Yükleniyor");
            //try
            //{
            //    if (viewName.Length > 0 && LoginUser.ConnStr.Length > 0)
            //    {
            //        using (SqlConnection SQLConnect = new SqlConnection(LoginUser.ConnStr))
            //        {
            //            SQLConnect.Open();
            //            TempCommand.Connection = SQLConnect;
            //            TempCommand.CommandText = QueryStr;
            //            TempCommand.CommandTimeout = 300;
            //            using (SqlDataAdapter da = new SqlDataAdapter(TempCommand))
            //            {
            //                TempTable = new DataTable();
            //                da.Fill(TempTable);
            //                tempGridControl.DataSource = TempTable;
            //            }
            //        }
            //        tempGridControl.ForceInitialize();
            //        new DxFunctions().SetGrid(tempGridView, false);

            //    }
            //    mutils.CloseWaitForm();
            //}
            //catch (Exception ex)
            //{
            //    mutils.CloseWaitForm();
            //}
        }
        private void barBtnDefaultView_ItemClick(object sender, ItemClickEventArgs e)
        {
            //if(Messages.MessageBoxOnay("Dikkat","Liste Görünüm ayarlarınız silinecek...","Onaylıyor musunuz?")==DialogResult.Yes)
            //{
            //    using (UserQueries query = new UserQueries())
            //    {
            //        string MyViewName = "view_" + yetki.EditFormName;
            //        query.DeleteUserViewLayout(MyViewName, LoginUser.UserID);
            //        tempGridView.Columns.Clear();
            //        tempGridView.OptionsBehavior.Editable = false;
            //        new DxFunctions().SetGrid(tempGridView, false);
            //    }
            //}
        }
        public virtual void SetLayout()
        {
            //try
            //{
            //    string MyViewName = "view_" + yetki.EditFormName;
            //    using (UserQueries query = new UserQueries())
            //        UsrLayout = query.UserLayoutGetInfo(MyViewName, LoginUser.UserID);
            //    if (UsrLayout != null)
            //    {
            //        byte[] byteArray = Encoding.UTF8.GetBytes(UsrLayout.Layout);
            //        using (MemoryStream stream = new MemoryStream(byteArray))
            //        {
            //            //tempGridControl.MainView.RestoreLayoutFromStream(stream);
            //            tempGridView.RestoreLayoutFromStream(stream);
            //            stream.Seek(0, System.IO.SeekOrigin.Begin);
            //            stream.Flush();
            //        }
            //    }
            //    tempGridView.ActiveFilter.Clear();
            //    tempGridView.OptionsView.ColumnAutoWidth = false;
            //    tempGridView.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            //    tempGridView.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            //    SetGridMultiselect(false);
            //}
            //catch (Exception ex)
            //{
            //}
        }
        void SaveLayout()
        {
            //try
            //{
            //    string LayoutTxt = string.Empty;
            //    using (Stream str = new System.IO.MemoryStream())
            //    {
            //        //tempGridControl.MainView.SaveLayoutToStream(str);
            //        tempGridView.SaveLayoutToStream(str);
            //        str.Seek(0, System.IO.SeekOrigin.Begin);
            //        using (StreamReader reader = new StreamReader(str))
            //        {
            //            LayoutTxt = reader.ReadToEnd();
            //        }
            //    }

            //    using (MainDataContext db = new MainDataContext())
            //    {
            //        using (UnitOfWork myworker = new UnitOfWork(db))
            //        {
            //            IRepository<UserViewLayouts> FormRepo = new Repository<UserViewLayouts>(db);

            //            UsrLayout = UsrLayout == null ? new UserViewLayouts() : UsrLayout;
            //            if (UsrLayout.ID > 0)
            //                FormRepo.Update(UsrLayout);
            //            else
            //            {
            //                FormRepo.Add(UsrLayout);
            //                UsrLayout.UserID = LoginUser.UserID;
            //                UsrLayout.ViewName = "view_" + yetki.EditFormName;
            //                UsrLayout.Caption = yetki.FormCaption;
            //                UsrLayout.CreatedBy = LoginUser.UserID;
            //                UsrLayout.CreatedOn = DateTime.Now;
            //            }
            //            UsrLayout.Layout = LayoutTxt;
            //            UsrLayout.ModifiedBy = LoginUser.UserID;
            //            UsrLayout.ModifiedOn = DateTime.Now;
            //            myworker.SaveChanges();
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //}
        }
        public virtual void OpenMyForm()
        {

            bool FormExist = false;
            foreach (Form OpenForm in Application.OpenForms)
            {
                if (OpenForm is XtraForm)
                {
                    if ((OpenForm.GetType() == new CheckForm().GetFormTypeFromDll(yetki.editFormName)) && ((FrmBaseFormEdit)OpenForm).FormID == SelectedID && ((FrmBaseFormEdit)OpenForm).yetki.menuCardType == yetki.menuCardType)
                    {
                        OpenForm.BringToFront();
                        FormExist = true;
                        break;
                    }
                }
            }
            if (!FormExist)
            {
                try
                {
                    if (yetki.allowList && yetki.allowNew && yetki.allowEdit)
                    {
                        object[] args ={new CustomDataObject("MenuID",yetki.menuTag),
                                new CustomDataObject("FormID",SelectedID),
                                new CustomDataObject("FormType",2),
                                new CustomDataObject("FormCaption",yetki.editFormCaption),
                                new CustomDataObject("NavigationAuthory",yetki)};
                        XtraForm myform = new CheckForm().OpenForm<FrmBaseFormEdit>(args);
                        myform.MdiParent = Application.OpenForms[0];
                        myform.Show();
                    }

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        public virtual void OpenMyForm(NavigationM yetki)
        {
            bool FormExist = false;
            foreach (Form OpenForm in Application.OpenForms)
            {
                if (OpenForm is XtraForm)
                {
                    if ((OpenForm.GetType() == new CheckForm().GetFormTypeFromDll(yetki.editFormName)) && ((FrmBaseFormEdit)OpenForm).FormID == SelectedID && ((FrmBaseFormEdit)OpenForm).yetki.menuCardType == yetki.menuCardType)
                    {
                        OpenForm.BringToFront();
                        FormExist = true;
                        break;
                    }
                }
            }
            if (!FormExist)
            {
                if (yetki.allowList && yetki.allowNew && yetki.allowEdit)
                {
                    
                    object[] args ={new CustomDataObject("MenuID",yetki.menuTag),
                                new CustomDataObject("FormID",SelectedID),
                                new CustomDataObject("FormType",2),
                                new CustomDataObject("FormCaption",yetki.editFormCaption),
                                new CustomDataObject("NavigationAuthory",yetki)};
                    XtraForm myform = new CheckForm().OpenForm<FrmBaseFormEdit>(args);
                    myform.MdiParent = Application.OpenForms[0];
                    myform.Show();
                }
            }
        }
        public virtual void TempListGridView_DoubleClick(object sender, EventArgs e)
        {
            GridView view = sender as GridView;
            GridHitInfo hitInfo = view.CalcHitInfo((e as MouseEventArgs).Location);
            if (hitInfo.InRowCell)
            {
                int rowHandle = view.FocusedRowHandle;
                if (view.IsDataRow(rowHandle))
                {
                    string KeyData = Convert.ToString(view.GetRowCellValue(view.FocusedRowHandle, KeyField));
                    SelectedID = Convert.ToInt32(KeyField == "ID" ? KeyData : KeyData.Split('-')[1]);
                    OpenMyForm();
                }
            }

        }

        public virtual void FormNew()
        {
            SelectedID = 0;
            OpenMyForm();
        }
        public virtual void FormEdit()
        {
            if (tempGridView.DataRowCount > 0)
            {
                string KeyData = Convert.ToString(tempGridView.GetRowCellValue(tempGridView.FocusedRowHandle, KeyField));
                SelectedID = Convert.ToInt32(KeyField == "ID" ? KeyData : KeyData.Split('-')[1]);
                OpenMyForm();
            }
        }
        private void BarBtnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormNew();
        }

        private void BarBtnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormEdit();
        }

        private void BarBtnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dxFunctions.ShowWaitForm("Liste Yükleniyor");
            LoadList();
            dxFunctions.CloseWaitForm();

        }

        private void BarBtnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveLayout();
            this.Close();
            GC.Collect(GC.MaxGeneration);
        }
        public void SetcustomColumns(object[] args)
        {
            new DxFunctions().SetcustomColumns(tempGridView, args);
        }
        public void ShowFindBox(bool show)
        {
            if (show)
                tempGridView.ShowFindPanel();
            else
                tempGridView.HideFindPanel();
        }
        public virtual void TempGridView_RowStyle(object sender, RowStyleEventArgs e)
        {

        }

        public virtual void TempGridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {

        }

        private void barBtnPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (yetki.allowPrint)
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

        private void TempMainList_Shown(object sender, EventArgs e)
        {
            LoadList();
            SetLayout();
        }

        
        private void barButtonItemLanguage_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void barButtonItemSatisFaturasi_ItemClick(object sender, ItemClickEventArgs e)
        {
            //YeniFatura(Convert.ToInt32(e.Item.Tag));
        }

        private void barToggleSwitchTopluGuncelleme_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            SetGridMultiselect(barToggleSwitchTopluGuncelleme.Checked);
        }

        void SetGridMultiselect(bool isMultiselect)
        {
            tempGridView.OptionsSelection.MultiSelect = isMultiselect;
            tempGridView.OptionsSelection.MultiSelectMode = isMultiselect ? DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect : DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect;
            tempGridView.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = isMultiselect ? DevExpress.Utils.DefaultBoolean.True : DevExpress.Utils.DefaultBoolean.False;
            tempGridView.OptionsSelection.ShowCheckBoxSelectorInGroupRow = isMultiselect ? DevExpress.Utils.DefaultBoolean.True : DevExpress.Utils.DefaultBoolean.False;
        }
        private void barButtonItemSecimiGuncelle_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void tempGridView_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (barToggleSwitchTopluGuncelleme.Checked == false)
                return;

            barButtonItemSecimiGuncelle.Visibility = tempGridView.GetSelectedRows().ToList().Count > 0 ? BarItemVisibility.Always : BarItemVisibility.Never;
        }
    }
}
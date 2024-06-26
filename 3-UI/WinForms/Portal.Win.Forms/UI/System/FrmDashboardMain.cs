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
    public partial class FrmDashboardMain : FrmAppBaseForm
    {
        DxFunctions dxFunctions;
        MioUtils mutils;
        public FrmDashboardMain()
        {
            InitializeComponent();
            dxFunctions = new DxFunctions();
            mutils = new MioUtils();
        }
        public FrmDashboardMain(object[] args)
        {
            dxFunctions = new DxFunctions();
            mutils = new MioUtils();
        }

        public void SetFormResources()
        {
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
       


    }
}
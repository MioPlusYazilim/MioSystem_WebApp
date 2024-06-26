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
    public partial class FrmAppBaseFormMainList : FrmAppBaseForm
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

        //UserViewLayouts UsrLayout;
        public DxFunctions dxFunctions;
        public MioUtils mutils;
        public FrmAppBaseFormMainList()
        {
            InitializeComponent();
            dxFunctions = new DxFunctions();
            mutils = new MioUtils();
        }
        public FrmAppBaseFormMainList(object[] args)
        {
            InitializeComponent();
            dxFunctions = new DxFunctions();
            mutils = new MioUtils();
            this.MenuID = new ObjectConvert().ToInt32(args, "MenuID");
        }

        private void barToggleSwitchItemSelectMultiple_CheckedChanged(object sender, ItemClickEventArgs e)
        {

            SetGridMultiselect(barToggleSwitchItemSelectMultiple.Checked);
        }

        void SetGridMultiselect(bool isMultiselect)
        {
            gridViewMainList.OptionsSelection.MultiSelect = isMultiselect;
            gridViewMainList.OptionsSelection.MultiSelectMode = isMultiselect ? DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect : DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect;
            gridViewMainList.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = isMultiselect ? DevExpress.Utils.DefaultBoolean.True : DevExpress.Utils.DefaultBoolean.False;
            gridViewMainList.OptionsSelection.ShowCheckBoxSelectorInGroupRow = isMultiselect ? DevExpress.Utils.DefaultBoolean.True : DevExpress.Utils.DefaultBoolean.False;
        }
        private void barButtonItemSecimiGuncelle_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void gridViewMainList_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (barToggleSwitchItemSelectMultiple.Checked == false)
                return;

            barButtonItemUpdateSelectedData.Visibility = gridViewMainList.GetSelectedRows().ToList().Count > 0 ? BarItemVisibility.Always : BarItemVisibility.Never;
        }
    }
}
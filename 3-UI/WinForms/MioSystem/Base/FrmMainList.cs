using DevExpress.XtraBars.FluentDesignSystem;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraRichEdit.Fields;
using MioPortal.Data.Services;
using MioSystem.Utils;
using Portal.Data.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace MioSystem.Base
{
    public partial class FrmMainList : FrmBaseUserControl
    {
        public FrmMainList(BaseFormSettings _formSettings) : base(_formSettings)
        {
            InitializeComponent();
        }

        private void FrmMainList_Load(object sender, EventArgs e)
        {
            SetMenuButtonAuthory();
            if (!string.IsNullOrEmpty(formSettings.FormPermissions.listSourceName))
                gridControlMainList.DataSource = LoadData();
        }
        void SetMenuButtonAuthory()
        {
            if (formSettings.FormPermissions == null)
                return;
            barButtonItemNew.Enabled = formSettings.FormPermissions.allowNew;
            barButtonItemEdit.Enabled = formSettings.FormPermissions.allowEdit;
            barButtonItemDelete.Enabled = formSettings.FormPermissions.allowDelete;
            barButtonItemPrint.Enabled = formSettings.FormPermissions.allowPrint;
            ribbonPageGroupAdditionalOperations.Visible = formSettings.FormPermissions.formType != 1;
           
        }
        private void barButtonItemClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Parent.Controls.Remove(this);
            this.Dispose();
        }

        object LoadData()
        {
            using (var service = new ClientDefinitionsService())
            {
                var query = string.Format("select * from {0} where {1}", formSettings.FormPermissions.listSourceName, GetWhereCondition());
                return service.GetObjectMainList(query);
            }
        }
        string GetWhereCondition()
        {
            return "1=1";
        }

        private void gridViewMainList_DoubleClick(object sender, EventArgs e)
        {
            GridView view = sender as GridView;
            GridHitInfo hitInfo = view.CalcHitInfo((e as MouseEventArgs).Location);
            if (hitInfo.InRowCell)
            {
                int rowHandle = view.FocusedRowHandle;
                if (view.IsDataRow(rowHandle))
                {
                    string KeyData = Convert.ToString(view.GetRowCellValue(view.FocusedRowHandle, "KeyID"));
                    //SelectedID = Convert.ToInt32(KeyField == "ID" ? KeyData : KeyData.Split('-')[1]);
                    OpenForm(Convert.ToInt32(KeyData));
                }
            }
        }

        void OpenForm(int ID)
        {
            FormFactory.CreateEditForm(AppDocumentManager, formSettings, ID);
        }

        private void barButtonItemNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm(0);
        }

        private void barButtonItemEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}

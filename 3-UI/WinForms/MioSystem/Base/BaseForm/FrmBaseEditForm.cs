using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using MioSystem.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MioSystem.Base
{
    public partial class FrmBaseEditForm : FrmBaseUserControl
    {

        public FrmBaseEditForm()
        {

        }
        public FrmBaseEditForm(BaseFormSettings _formSettings) : base(_formSettings)
        {
            InitializeComponent();
        }
        void SetMenuButtonAuthory()
        {
            barButtonItemNew.Enabled = formSettings.FormPermissions.allowNew;
            barButtonItemSave.Enabled = formSettings.FormID == 0 ? (formSettings.FormPermissions.allowNew || formSettings.FormPermissions.allowEdit) : formSettings.FormPermissions.allowEdit;
            barButtonItemDelete.Enabled = formSettings.FormPermissions.allowDelete;
            barButtonItemPrint.Enabled = formSettings.FormPermissions.allowPrint;
        }

        private void barButtonItemNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormNew();
            SetMenuButtonAuthory();
        }

        private void barButtonItemSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormSave();
        }

        private void barButtonItemDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormDelete();
        }

        private void barButtonItemPrint_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItemClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Parent.Controls.Remove(this);
            this.Dispose();
        }

        public virtual void FormNew()
        {

        }

        public virtual void FormSave()
        {

        }
        public virtual void FormDelete()
        {

        }
        public virtual void FormPrint()
        {

        }
    }
}

using DevExpress.XtraBars.Docking2010;
using MioSystem.Utils;
using Portal.Model;
using System;
using System.Linq;

namespace MioSystem.Base
{
    public partial class FrmBaseUserControl : DevExpress.XtraEditors.XtraUserControl
    {

        public BaseFormSettings formSettings {  get; set; }
        public DocumentManager AppDocumentManager {  get; set; }
        public string FormCaption { get; set; } = string.Empty;

        public FrmBaseUserControl()
        {
            InitializeComponent();
        }
        public FrmBaseUserControl(BaseFormSettings _formSettings)
        {
            formSettings = _formSettings;
            InitializeComponent();
            formSettings?.Init();
        }
        public virtual void InitCaption()
        {
            string fCaption = string.Empty;

            if (formSettings != null && formSettings.FormPermissions != null)
            {
                if (this.GetType() == typeof(FrmMainList))
                    fCaption = formSettings.FormPermissions.listFormCaption;
                else
                    fCaption = formSettings.FormPermissions.editFormCaption + "[" + FormCaption + "]";
            }
            if (AppDocumentManager != null)
                FormFactory.SetFormCaption(AppDocumentManager, this.Name, fCaption);
        }
        private void FrmBaseUserControl_Load(object sender, EventArgs e)
        {
            InitCaption();
        }

        
    }
}

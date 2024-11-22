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


        public FrmBaseUserControl()
        {
            InitializeComponent();
        }
        public FrmBaseUserControl(BaseFormSettings _formSettings)
        {
           formSettings = _formSettings;
            
            InitializeComponent();
            formSettings.Init();
        }
        public virtual void InitCaption(string caption)
        {

            if(AppDocumentManager!=null && AppDocumentManager.View.ActiveDocument != null && formSettings.FormPermissions != null)
            {
                string formCaption = this.GetType()==typeof(FrmMainList)? formSettings.FormPermissions.listFormCaption : formSettings.FormPermissions.editFormCaption;
                if (formSettings.FormPermissions.formType != 1)
                    formCaption = formCaption + "[" + caption+ "]";
               AppDocumentManager.View.ActiveDocument.Caption = formCaption;
            }
        }
        private void FrmBaseUserControl_Load(object sender, EventArgs e)
        {
            InitCaption("");
        }

        
    }
}

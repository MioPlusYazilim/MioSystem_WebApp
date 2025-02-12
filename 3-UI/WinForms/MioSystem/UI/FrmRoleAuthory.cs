using DevExpress.XtraEditors;
using MioPortal.Data.Services;
using MioSystem.Base;
using MioSystem.DxUtils;
using MioSystem.Utils;
using Portal.Data.Services.GlobalContextService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MioSystem.UI
{
    public partial class FrmRoleAuthory : FrmBaseEditForm
    {
        public FrmRoleAuthory(BaseFormSettings _formSettings) : base(_formSettings)
        {
            InitializeComponent();
            FormCaption = _formSettings.FormID.ToString();
            LoadData();
        }
        void LoadData()
        {
            using (var service = new GlobalContextService())
            {
                using(var dxfunc = new DxFunctions())
               dxfunc.SetEditDataSource(cbTest,service.GetAirLineSelectList(formSettings.FormUser.displayLanguage),"value","code,name","");
            }
        }
    }
}

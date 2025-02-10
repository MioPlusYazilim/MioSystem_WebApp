using DevExpress.XtraEditors;
using MioSystem.Base;
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

namespace MioSystem.UI
{
    public partial class FrmRoleAuthory : FrmBaseEditForm
    {
        public FrmRoleAuthory(BaseFormSettings _formSettings) : base(_formSettings)
        {
            InitializeComponent();
            if (formSettings != null)
                FormCaption = _formSettings.FormID.ToString();
        }
    }
}

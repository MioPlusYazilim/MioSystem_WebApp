using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using Portal.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portal.Win.Forms.Base
{
    public partial class FrmAppBaseForm : XtraForm
    {
        public LoginResponse loginUser;
        public FrmAppBaseForm()
        {
            loginUser = LoginResponse.GetLoginResponse();
            InitializeComponent();
            
        }
        public FrmAppBaseForm(object[] args)
        {
            loginUser = LoginResponse.GetLoginResponse();
            InitializeComponent();
        }
    }
}

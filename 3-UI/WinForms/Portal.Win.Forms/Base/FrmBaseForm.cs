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
    public partial class FrmBaseForm : XtraForm
    {
        public LoginResponse loginUser;
        public FrmBaseForm()
        {
            loginUser = LoginResponse.GetLoginResponse();
            InitializeComponent();
            
        }
        public FrmBaseForm(object[] args)
        {
            loginUser = LoginResponse.GetLoginResponse();
            InitializeComponent();
        }
    }
}

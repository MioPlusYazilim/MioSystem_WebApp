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

namespace MioSystem
{
    public partial class FrmBaseForm : XtraForm
    {
        public Login loginUser = Login.GetLoginUser();
        public FrmBaseForm()
        {
            InitializeComponent();
            
        }
        public FrmBaseForm(object[] args)
        {
            InitializeComponent();
        }
    }
}

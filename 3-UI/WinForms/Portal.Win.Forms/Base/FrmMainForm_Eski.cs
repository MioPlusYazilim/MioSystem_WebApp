using DevExpress.Xpo.Helpers;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors.Filtering;
using Portal.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Portal.Win.Forms
{
    public partial class FrmMainForm_Eski : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Login LoginUser { get; set; }
        public FrmMainForm_Eski()
        {
            InitializeComponent();
           
        }
        private void FrmMainForm_Load(object sender, EventArgs e)
        {
        }
    }
}

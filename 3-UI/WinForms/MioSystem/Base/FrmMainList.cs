using DevExpress.XtraEditors;
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
    public partial class FrmMainList : DevExpress.XtraEditors.XtraUserControl
    {
        public FrmMainList()
        {
            InitializeComponent();
        }

        private void barButtonItemClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Parent.Controls.Remove(this);
            this.Dispose();
        }
    }
}

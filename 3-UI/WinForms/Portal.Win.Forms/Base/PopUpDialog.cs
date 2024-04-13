using DevExpress.XtraEditors;

namespace Portal.Win.Forms
{
    public partial class PopUpDialog : XtraForm
    {
        private XtraForm FrmParent;
        private XtraForm FrmContainer;
        private XtraForm dialog;
        private UserControl ucDialog;
        public PopUpDialog(XtraForm parent)
        {
            InitializeComponent();
            this.FrmParent = parent;
            SetFormProperties();
            FrmContainer = new XtraForm();
            this.Shown += PopUpDialog_Shown;
           
        }

        private void PopUpDialog_Shown(object sender, EventArgs e)
        {
            FrmContainer.ShowDialog();
            this.Close();
        }

        public PopUpDialog(XtraUserControl child)
        {
            InitializeComponent();
            this.FrmParent = (XtraForm)Application.OpenForms[0];
            this.ucDialog = child;
            SetFormProperties();
            this.Shown += PopUpDialog_LoadXtraUserControl;
        }
        public PopUpDialog(XtraForm parent,XtraForm child)
        {
            InitializeComponent();
            this.FrmParent = parent;
            this.dialog = child;
            SetFormProperties();
            this.Shown += PopUpDialog_LoadXtraform;
        }
        public PopUpDialog(XtraForm parent, XtraUserControl child)
        {
            InitializeComponent();
            this.FrmParent = parent;
            this.ucDialog = child;
            SetFormProperties();
            this.Shown += PopUpDialog_LoadXtraUserControl;
        }

        private void PopUpDialog_LoadXtraUserControl(object sender, EventArgs e)
        {
            try
            {
                XtraForm FrmContainer = new XtraForm();
                FrmContainer.ShowInTaskbar = false;
                FrmContainer.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
                FrmContainer.StartPosition = FormStartPosition.CenterParent;
                FrmContainer.Height = ucDialog.Height + 40;
                FrmContainer.Width = ucDialog.Width + 40;
                FrmContainer.Controls.Add(ucDialog);
                ucDialog.Dock = DockStyle.Fill;
                this.DialogResult = FrmContainer.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
            }
            
        }

        private void PopUpDialog_LoadXtraform(object sender, EventArgs e)
        {
            try
            {
                //dialog.Owner = this;
                dialog.StartPosition = FormStartPosition.CenterParent;
                this.DialogResult = dialog.ShowDialog(this);
                this.Close();
            }
            catch (Exception ex)
            {
            }
            
        }
        private void SetFormProperties()
        {
            try
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.BackColor = System.Drawing.Color.Gray;
                this.Opacity = 0.70;
                this.ShowInTaskbar = false;
                this.StartPosition = FormStartPosition.Manual;
                this.Size = FrmParent.ClientSize;
                this.Location = FrmParent.PointToScreen(System.Drawing.Point.Empty);
                FrmParent.Move += AdjustPosition;
                FrmParent.SizeChanged += AdjustPosition;
            }
            catch (Exception ex)
            {
            }
            
        }
        private void AdjustPosition(object sender, EventArgs e)
        {
            try
            {
                XtraForm parent = sender as XtraForm;
                this.Location = parent.PointToScreen(System.Drawing.Point.Empty);
                this.ClientSize = parent.ClientSize;
            }
            catch (Exception ex)
            {
            }
            
        }

    }
}

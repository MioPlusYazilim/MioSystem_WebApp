using System;
using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace Portal.Win.Forms
{
    public class MaskedDialog : XtraForm
    {
        private XtraForm FrmContainer;
        private XtraForm dialog;
        private UserControl ucDialog;

        private MaskedDialog(XtraForm parent, XtraForm Dialog)
        {
            this.dialog = Dialog;
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = System.Drawing.Color.Gray;
            this.Opacity = 0.70;
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.Manual;
            this.Size = parent.ClientSize;
            this.Location = parent.PointToScreen(System.Drawing.Point.Empty);
            parent.Move += AdjustPosition;
            parent.SizeChanged += AdjustPosition;
        }

        private MaskedDialog(XtraForm parent, XtraUserControl Dialog)
        {
            this.ucDialog = Dialog;
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = System.Drawing.Color.Gray;
            this.Opacity = 0.70;
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.Manual;
            this.Size = parent.ClientSize;
            this.Location = parent.PointToScreen(System.Drawing.Point.Empty);
            parent.Move += AdjustPosition;
            parent.SizeChanged += AdjustPosition;
        }

        private MaskedDialog(XtraUserControl Dialog)
        {
            this.BackColor = System.Drawing.Color.Gray;
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Size = Dialog.Size;
        }
        private void AdjustPosition(object sender, EventArgs e)
        {
            XtraForm parent = sender as XtraForm;
            this.Location = parent.PointToScreen(System.Drawing.Point.Empty);
            this.ClientSize = parent.ClientSize;
        }
        public static DialogResult ShowDialog(XtraForm parentform, XtraForm ChildForm)
        {
            MaskedDialog mask = new MaskedDialog(parentform, ChildForm);
            mask.Show(parentform);
            DialogResult result = ChildForm.ShowDialog(mask);
            ChildForm.Close();
            mask.Close();
            return result;
        }
        public static DialogResult ShowDialog(XtraUserControl ChildForm)
        {
            MaskedDialog mask = new MaskedDialog(ChildForm);
            mask.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            mask.Width = ChildForm.Width + 10;
            mask.Height = ChildForm.Height + 10;
            mask.Controls.Add(ChildForm);
            ChildForm.Dock = DockStyle.Fill;
            DialogResult result = mask.ShowDialog();
            mask.Close();
            return result;
        }
        public static DialogResult ShowDialog(XtraForm parentform, XtraUserControl ChildForm)
        {

            MaskedDialog mask = new MaskedDialog(parentform, ChildForm);
            XtraForm FrmContainer = new XtraForm();
            FrmContainer.ShowInTaskbar = false;
            FrmContainer.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            FrmContainer.StartPosition = FormStartPosition.CenterParent;
            FrmContainer.Height = ChildForm.Height + 40;
            FrmContainer.Width = ChildForm.Width + 10;

            FrmContainer.Controls.Add(ChildForm);
            mask.Show(parentform);
            DialogResult result = FrmContainer.ShowDialog(mask);
            FrmContainer.Close();
            mask.Close();
            return result;
        }


        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MaskedDialog
            // 
            this.ClientSize = new System.Drawing.Size(896, 477);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.KeyPreview = true;
            this.Name = "MaskedDialog";
            this.ResumeLayout(false);

        }
        public void CloseMask()
        {
            this.Close();
        }
    }
}


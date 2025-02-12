namespace MioSystem.UI
{
    partial class FrmRoleAuthory
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            textEdit1 = new DevExpress.XtraEditors.TextEdit();
            cbTest = new DevExpress.XtraEditors.LookUpEdit();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)dataLayoutControl1).BeginInit();
            dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbTest.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            dataLayoutControl1.Controls.Add(textEdit1);
            dataLayoutControl1.Controls.Add(cbTest);
            dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            dataLayoutControl1.Location = new System.Drawing.Point(0, 133);
            dataLayoutControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dataLayoutControl1.Name = "dataLayoutControl1";
            dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(698, 122, 650, 400);
            dataLayoutControl1.Root = Root;
            dataLayoutControl1.Size = new System.Drawing.Size(651, 281);
            dataLayoutControl1.TabIndex = 4;
            dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // textEdit1
            // 
            textEdit1.Location = new System.Drawing.Point(123, 12);
            textEdit1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            textEdit1.Name = "textEdit1";
            textEdit1.Size = new System.Drawing.Size(516, 20);
            textEdit1.StyleController = dataLayoutControl1;
            textEdit1.TabIndex = 4;
            // 
            // cbTest
            // 
            cbTest.Location = new System.Drawing.Point(123, 36);
            cbTest.MenuManager = ribbonControl1;
            cbTest.Name = "cbTest";
            cbTest.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cbTest.Properties.NullText = "";
            cbTest.Properties.PopupSizeable = false;
            cbTest.Size = new System.Drawing.Size(516, 20);
            cbTest.StyleController = dataLayoutControl1;
            cbTest.TabIndex = 5;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, emptySpaceItem1, layoutControlItem2 });
            Root.Name = "Root";
            Root.Size = new System.Drawing.Size(651, 281);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = textEdit1;
            layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new System.Drawing.Size(631, 24);
            layoutControlItem1.TextSize = new System.Drawing.Size(99, 13);
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.AllowHotTrack = false;
            emptySpaceItem1.Location = new System.Drawing.Point(0, 48);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new System.Drawing.Size(631, 213);
            emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = cbTest;
            layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new System.Drawing.Size(631, 24);
            layoutControlItem2.TextSize = new System.Drawing.Size(99, 13);
            // 
            // FrmRoleAuthory
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(dataLayoutControl1);
            Name = "FrmRoleAuthory";
            Size = new System.Drawing.Size(651, 414);
            Controls.SetChildIndex(dataLayoutControl1, 0);
            ((System.ComponentModel.ISupportInitialize)dataLayoutControl1).EndInit();
            dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbTest.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.LookUpEdit cbTest;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}

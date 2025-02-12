namespace MioSystem.Base
{
    partial class FrmBaseEditForm
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
            bar3 = new DevExpress.XtraBars.Bar();
            ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            barButtonItemNew = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemSave = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemDelete = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemPrint = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemClose = new DevExpress.XtraBars.BarButtonItem();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroupEdit = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroupClose = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).BeginInit();
            SuspendLayout();
            // 
            // bar3
            // 
            bar3.BarName = "Status bar";
            bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            bar3.DockCol = 0;
            bar3.DockRow = 0;
            bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            bar3.OptionsBar.AllowQuickCustomization = false;
            bar3.OptionsBar.DrawDragBorder = false;
            bar3.OptionsBar.UseWholeRow = true;
            bar3.Text = "Status bar";
            // 
            // ribbonControl1
            // 
            ribbonControl1.DrawGroupCaptions = DevExpress.Utils.DefaultBoolean.False;
            ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(26, 23, 26, 23);
            ribbonControl1.ExpandCollapseItem.Id = 0;
            ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbonControl1.ExpandCollapseItem, barButtonItemNew, barButtonItemSave, barButtonItemDelete, barButtonItemPrint, barButtonItemClose });
            ribbonControl1.Location = new System.Drawing.Point(0, 0);
            ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            ribbonControl1.MaxItemId = 7;
            ribbonControl1.Name = "ribbonControl1";
            ribbonControl1.OptionsExpandCollapseMenu.ShowQuickAccessToolbarItem = DevExpress.Utils.DefaultBoolean.False;
            ribbonControl1.OptionsExpandCollapseMenu.ShowRibbonGroup = DevExpress.Utils.DefaultBoolean.False;
            ribbonControl1.OptionsMenuMinWidth = 283;
            ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1 });
            ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            ribbonControl1.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            ribbonControl1.ShowMoreCommandsButton = DevExpress.Utils.DefaultBoolean.False;
            ribbonControl1.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            ribbonControl1.ShowPageKeyTipsMode = DevExpress.XtraBars.Ribbon.ShowPageKeyTipsMode.Hide;
            ribbonControl1.ShowQatLocationSelector = false;
            ribbonControl1.ShowToolbarCustomizeItem = false;
            ribbonControl1.Size = new System.Drawing.Size(642, 133);
            ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // barButtonItemNew
            // 
            barButtonItemNew.Caption = "Yeni";
            barButtonItemNew.Id = 1;
            barButtonItemNew.ImageOptions.Image = Properties.Resources.addfile_16x16;
            barButtonItemNew.ImageOptions.LargeImage = Properties.Resources.addfile_32x32;
            barButtonItemNew.Name = "barButtonItemNew";
            barButtonItemNew.ItemClick += barButtonItemNew_ItemClick;
            // 
            // barButtonItemSave
            // 
            barButtonItemSave.Caption = "Kaydet";
            barButtonItemSave.Id = 2;
            barButtonItemSave.ImageOptions.Image = Properties.Resources.save_16x162;
            barButtonItemSave.ImageOptions.LargeImage = Properties.Resources.save_32x323;
            barButtonItemSave.Name = "barButtonItemSave";
            barButtonItemSave.ItemClick += barButtonItemSave_ItemClick;
            // 
            // barButtonItemDelete
            // 
            barButtonItemDelete.Caption = "Sil";
            barButtonItemDelete.Id = 3;
            barButtonItemDelete.ImageOptions.Image = Properties.Resources.delete_16x161;
            barButtonItemDelete.ImageOptions.LargeImage = Properties.Resources.delete_32x321;
            barButtonItemDelete.Name = "barButtonItemDelete";
            barButtonItemDelete.ItemClick += barButtonItemDelete_ItemClick;
            // 
            // barButtonItemPrint
            // 
            barButtonItemPrint.Caption = "Yazdır";
            barButtonItemPrint.Id = 4;
            barButtonItemPrint.ImageOptions.Image = Properties.Resources.print_16x161;
            barButtonItemPrint.ImageOptions.LargeImage = Properties.Resources.print_32x321;
            barButtonItemPrint.Name = "barButtonItemPrint";
            barButtonItemPrint.ItemClick += barButtonItemPrint_ItemClick;
            // 
            // barButtonItemClose
            // 
            barButtonItemClose.Caption = "Kapat";
            barButtonItemClose.Id = 6;
            barButtonItemClose.ImageOptions.Image = Properties.Resources.close_16x161;
            barButtonItemClose.ImageOptions.LargeImage = Properties.Resources.close_32x321;
            barButtonItemClose.Name = "barButtonItemClose";
            barButtonItemClose.ItemClick += barButtonItemClose_ItemClick;
            // 
            // ribbonPage1
            // 
            ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroupEdit, ribbonPageGroupClose });
            ribbonPage1.Name = "ribbonPage1";
            ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroupEdit
            // 
            ribbonPageGroupEdit.ItemLinks.Add(barButtonItemNew);
            ribbonPageGroupEdit.ItemLinks.Add(barButtonItemSave);
            ribbonPageGroupEdit.ItemLinks.Add(barButtonItemDelete);
            ribbonPageGroupEdit.ItemLinks.Add(barButtonItemPrint);
            ribbonPageGroupEdit.Name = "ribbonPageGroupEdit";
            ribbonPageGroupEdit.Text = "Düzenle";
            // 
            // ribbonPageGroupClose
            // 
            ribbonPageGroupClose.Alignment = DevExpress.XtraBars.Ribbon.RibbonPageGroupAlignment.Far;
            ribbonPageGroupClose.ItemLinks.Add(barButtonItemClose);
            ribbonPageGroupClose.Name = "ribbonPageGroupClose";
            ribbonPageGroupClose.Text = "Kapat";
            // 
            // FrmBaseEditForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(ribbonControl1);
            Name = "FrmBaseEditForm";
            Size = new System.Drawing.Size(642, 367);
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem barButtonItemNew;
        private DevExpress.XtraBars.BarButtonItem barButtonItemSave;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDelete;
        private DevExpress.XtraBars.BarButtonItem barButtonItemPrint;
        private DevExpress.XtraBars.BarButtonItem barButtonItemClose;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupEdit;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupClose;
        public DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
    }
}

namespace MioSystem.Base
{
    partial class FrmMainList
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
            components = new System.ComponentModel.Container();
            barManager1 = new DevExpress.XtraBars.BarManager(components);
            bar2 = new DevExpress.XtraBars.Bar();
            barButtonItemNew = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemEdit = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemDelete = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemPrint = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemAdditional = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemFilter = new DevExpress.XtraBars.BarButtonItem();
            bar3 = new DevExpress.XtraBars.Bar();
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            barButtonItemClose = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
            SuspendLayout();
            // 
            // barManager1
            // 
            barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] { bar2, bar3 });
            barManager1.DockControls.Add(barDockControlTop);
            barManager1.DockControls.Add(barDockControlBottom);
            barManager1.DockControls.Add(barDockControlLeft);
            barManager1.DockControls.Add(barDockControlRight);
            barManager1.Form = this;
            barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { barButtonItemNew, barButtonItemEdit, barButtonItemDelete, barButtonItemPrint, barButtonItemAdditional, barButtonItemFilter, barButtonItemClose });
            barManager1.MainMenu = bar2;
            barManager1.MaxItemId = 7;
            barManager1.StatusBar = bar3;
            // 
            // bar2
            // 
            bar2.BarName = "Main menu";
            bar2.DockCol = 0;
            bar2.DockRow = 0;
            bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(barButtonItemNew), new DevExpress.XtraBars.LinkPersistInfo(barButtonItemEdit), new DevExpress.XtraBars.LinkPersistInfo(barButtonItemDelete), new DevExpress.XtraBars.LinkPersistInfo(barButtonItemPrint), new DevExpress.XtraBars.LinkPersistInfo(barButtonItemAdditional), new DevExpress.XtraBars.LinkPersistInfo(barButtonItemFilter, true), new DevExpress.XtraBars.LinkPersistInfo(barButtonItemClose) });
            bar2.OptionsBar.MultiLine = true;
            bar2.OptionsBar.UseWholeRow = true;
            bar2.Text = "Main menu";
            // 
            // barButtonItemNew
            // 
            barButtonItemNew.Caption = "Yeni";
            barButtonItemNew.Id = 0;
            barButtonItemNew.ImageOptions.Image = Properties.Resources.newdoc_16x16;
            barButtonItemNew.ImageOptions.LargeImage = Properties.Resources.newdoc_32x32;
            barButtonItemNew.Name = "barButtonItemNew";
            barButtonItemNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItemEdit
            // 
            barButtonItemEdit.Caption = "Değiştir";
            barButtonItemEdit.Id = 1;
            barButtonItemEdit.ImageOptions.Image = Properties.Resources.edit_16x16;
            barButtonItemEdit.ImageOptions.LargeImage = Properties.Resources.edit_32x32;
            barButtonItemEdit.Name = "barButtonItemEdit";
            barButtonItemEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItemDelete
            // 
            barButtonItemDelete.Caption = "Sil";
            barButtonItemDelete.Id = 2;
            barButtonItemDelete.ImageOptions.Image = Properties.Resources.delete_16x16;
            barButtonItemDelete.ImageOptions.LargeImage = Properties.Resources.delete_32x32;
            barButtonItemDelete.Name = "barButtonItemDelete";
            barButtonItemDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItemPrint
            // 
            barButtonItemPrint.Caption = "Yazdır";
            barButtonItemPrint.Id = 3;
            barButtonItemPrint.ImageOptions.Image = Properties.Resources.printer_16x16;
            barButtonItemPrint.ImageOptions.LargeImage = Properties.Resources.printer_32x32;
            barButtonItemPrint.Name = "barButtonItemPrint";
            barButtonItemPrint.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItemAdditional
            // 
            barButtonItemAdditional.Caption = "Ek İşlemler";
            barButtonItemAdditional.Id = 4;
            barButtonItemAdditional.ImageOptions.Image = Properties.Resources.expandcollapse_16x16;
            barButtonItemAdditional.ImageOptions.LargeImage = Properties.Resources.expandcollapse_32x32;
            barButtonItemAdditional.Name = "barButtonItemAdditional";
            barButtonItemAdditional.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItemFilter
            // 
            barButtonItemFilter.Caption = "Filtre";
            barButtonItemFilter.Id = 5;
            barButtonItemFilter.ImageOptions.Image = Properties.Resources.reapplyfilter_16x16;
            barButtonItemFilter.ImageOptions.LargeImage = Properties.Resources.reapplyfilter_32x32;
            barButtonItemFilter.Name = "barButtonItemFilter";
            barButtonItemFilter.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
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
            // barDockControlTop
            // 
            barDockControlTop.CausesValidation = false;
            barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            barDockControlTop.Location = new System.Drawing.Point(0, 0);
            barDockControlTop.Manager = barManager1;
            barDockControlTop.Size = new System.Drawing.Size(783, 30);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            barDockControlBottom.Location = new System.Drawing.Point(0, 428);
            barDockControlBottom.Manager = barManager1;
            barDockControlBottom.Size = new System.Drawing.Size(783, 20);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            barDockControlLeft.Manager = barManager1;
            barDockControlLeft.Size = new System.Drawing.Size(0, 398);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            barDockControlRight.Location = new System.Drawing.Point(783, 30);
            barDockControlRight.Manager = barManager1;
            barDockControlRight.Size = new System.Drawing.Size(0, 398);
            // 
            // barButtonItemClose
            // 
            barButtonItemClose.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            barButtonItemClose.Caption = "Kapat";
            barButtonItemClose.Id = 6;
            barButtonItemClose.ImageOptions.Image = Properties.Resources.close_16x16;
            barButtonItemClose.ImageOptions.LargeImage = Properties.Resources.close_32x32;
            barButtonItemClose.Name = "barButtonItemClose";
            barButtonItemClose.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            barButtonItemClose.ItemClick += barButtonItemClose_ItemClick;
            // 
            // FrmMainList
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Name = "FrmMainList";
            Size = new System.Drawing.Size(783, 448);
            ((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonItemNew;
        private DevExpress.XtraBars.BarButtonItem barButtonItemEdit;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDelete;
        private DevExpress.XtraBars.BarButtonItem barButtonItemPrint;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAdditional;
        private DevExpress.XtraBars.BarButtonItem barButtonItemFilter;
        private DevExpress.XtraBars.BarButtonItem barButtonItemClose;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}

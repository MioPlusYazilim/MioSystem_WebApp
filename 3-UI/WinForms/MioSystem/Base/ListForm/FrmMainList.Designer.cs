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
            gridControlMainList = new DevExpress.XtraGrid.GridControl();
            gridViewMainList = new DevExpress.XtraGrid.Views.Grid.GridView();
            ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            barButtonItemNew = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemEdit = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemDelete = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemPrint = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemFilter = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemClose = new DevExpress.XtraBars.BarButtonItem();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroupEdit = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroupAdditionalOperations = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroupClose = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            barButtonItemResetSettings = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemSaveSettings = new DevExpress.XtraBars.BarButtonItem();
            ribbonPageGroupGroupedActions = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)gridControlMainList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewMainList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).BeginInit();
            SuspendLayout();
            // 
            // gridControlMainList
            // 
            gridControlMainList.Dock = System.Windows.Forms.DockStyle.Fill;
            gridControlMainList.Location = new System.Drawing.Point(0, 163);
            gridControlMainList.MainView = gridViewMainList;
            gridControlMainList.Name = "gridControlMainList";
            gridControlMainList.Size = new System.Drawing.Size(863, 314);
            gridControlMainList.TabIndex = 4;
            gridControlMainList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewMainList });
            // 
            // gridViewMainList
            // 
            gridViewMainList.GridControl = gridControlMainList;
            gridViewMainList.Name = "gridViewMainList";
            gridViewMainList.OptionsBehavior.Editable = false;
            gridViewMainList.DoubleClick += gridViewMainList_DoubleClick;
            // 
            // ribbonControl1
            // 
            ribbonControl1.DrawGroupCaptions = DevExpress.Utils.DefaultBoolean.False;
            ribbonControl1.ExpandCollapseItem.Id = 0;
            ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbonControl1.ExpandCollapseItem, barButtonItemNew, barButtonItemEdit, barButtonItemDelete, barButtonItemPrint, barButtonItemFilter, barButtonItemClose, barButtonItemResetSettings, barButtonItemSaveSettings });
            ribbonControl1.Location = new System.Drawing.Point(0, 0);
            ribbonControl1.MaxItemId = 9;
            ribbonControl1.Name = "ribbonControl1";
            ribbonControl1.OptionsExpandCollapseMenu.ShowQuickAccessToolbarItem = DevExpress.Utils.DefaultBoolean.False;
            ribbonControl1.OptionsExpandCollapseMenu.ShowRibbonGroup = DevExpress.Utils.DefaultBoolean.False;
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
            ribbonControl1.Size = new System.Drawing.Size(863, 163);
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
            // barButtonItemEdit
            // 
            barButtonItemEdit.Caption = "Düzenle";
            barButtonItemEdit.Id = 2;
            barButtonItemEdit.ImageOptions.Image = Properties.Resources.edit_16x161;
            barButtonItemEdit.ImageOptions.LargeImage = Properties.Resources.edit_32x322;
            barButtonItemEdit.Name = "barButtonItemEdit";
            barButtonItemEdit.ItemClick += barButtonItemEdit_ItemClick;
            // 
            // barButtonItemDelete
            // 
            barButtonItemDelete.Caption = "Sil";
            barButtonItemDelete.Id = 3;
            barButtonItemDelete.ImageOptions.Image = Properties.Resources.delete_16x161;
            barButtonItemDelete.ImageOptions.LargeImage = Properties.Resources.delete_32x321;
            barButtonItemDelete.Name = "barButtonItemDelete";
            // 
            // barButtonItemPrint
            // 
            barButtonItemPrint.Caption = "Yazdır";
            barButtonItemPrint.Id = 4;
            barButtonItemPrint.ImageOptions.Image = Properties.Resources.print_16x161;
            barButtonItemPrint.ImageOptions.LargeImage = Properties.Resources.print_32x321;
            barButtonItemPrint.Name = "barButtonItemPrint";
            // 
            // barButtonItemFilter
            // 
            barButtonItemFilter.Caption = "Filtre";
            barButtonItemFilter.Id = 5;
            barButtonItemFilter.ImageOptions.Image = Properties.Resources.filter_16x16;
            barButtonItemFilter.ImageOptions.LargeImage = Properties.Resources.crossdatasourcefiltering_32x32;
            barButtonItemFilter.Name = "barButtonItemFilter";
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
            ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroupEdit, ribbonPageGroupAdditionalOperations, ribbonPageGroupClose, ribbonPageGroupGroupedActions });
            ribbonPage1.Name = "ribbonPage1";
            ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroupEdit
            // 
            ribbonPageGroupEdit.ItemLinks.Add(barButtonItemNew);
            ribbonPageGroupEdit.ItemLinks.Add(barButtonItemEdit);
            ribbonPageGroupEdit.ItemLinks.Add(barButtonItemDelete);
            ribbonPageGroupEdit.ItemLinks.Add(barButtonItemPrint);
            ribbonPageGroupEdit.Name = "ribbonPageGroupEdit";
            ribbonPageGroupEdit.Text = "Düzenle";
            // 
            // ribbonPageGroupAdditionalOperations
            // 
            ribbonPageGroupAdditionalOperations.ItemLinks.Add(barButtonItemFilter);
            ribbonPageGroupAdditionalOperations.Name = "ribbonPageGroupAdditionalOperations";
            ribbonPageGroupAdditionalOperations.Text = "Ek İşlemler";
            // 
            // ribbonPageGroupClose
            // 
            ribbonPageGroupClose.Alignment = DevExpress.XtraBars.Ribbon.RibbonPageGroupAlignment.Far;
            ribbonPageGroupClose.ItemLinks.Add(barButtonItemClose);
            ribbonPageGroupClose.Name = "ribbonPageGroupClose";
            ribbonPageGroupClose.Text = "Kapat";
            // 
            // barButtonItemResetSettings
            // 
            barButtonItemResetSettings.Caption = "Liste Ayarlarını Sıfırla";
            barButtonItemResetSettings.Id = 7;
            barButtonItemResetSettings.ImageOptions.Image = Properties.Resources.reset_16x161;
            barButtonItemResetSettings.ImageOptions.LargeImage = Properties.Resources.reset_32x321;
            barButtonItemResetSettings.Name = "barButtonItemResetSettings";
            barButtonItemResetSettings.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // barButtonItemSaveSettings
            // 
            barButtonItemSaveSettings.Caption = "Liste Ayarlarını Kaydet ";
            barButtonItemSaveSettings.Id = 8;
            barButtonItemSaveSettings.ImageOptions.Image = Properties.Resources.save_16x163;
            barButtonItemSaveSettings.ImageOptions.LargeImage = Properties.Resources.save_32x324;
            barButtonItemSaveSettings.Name = "barButtonItemSaveSettings";
            barButtonItemSaveSettings.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // ribbonPageGroupGroupedActions
            // 
            ribbonPageGroupGroupedActions.ItemLinks.Add(barButtonItemResetSettings);
            ribbonPageGroupGroupedActions.ItemLinks.Add(barButtonItemSaveSettings);
            ribbonPageGroupGroupedActions.Name = "ribbonPageGroupGroupedActions";
            ribbonPageGroupGroupedActions.Text = "ribbonPageGroup1";
            // 
            // FrmMainList
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(gridControlMainList);
            Controls.Add(ribbonControl1);
            Name = "FrmMainList";
            Size = new System.Drawing.Size(863, 477);
            Load += FrmMainList_Load;
            ((System.ComponentModel.ISupportInitialize)gridControlMainList).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewMainList).EndInit();
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControlMainList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMainList;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupEdit;
        private DevExpress.XtraBars.BarButtonItem barButtonItemNew;
        private DevExpress.XtraBars.BarButtonItem barButtonItemEdit;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDelete;
        private DevExpress.XtraBars.BarButtonItem barButtonItemPrint;
        private DevExpress.XtraBars.BarButtonItem barButtonItemFilter;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupAdditionalOperations;
        private DevExpress.XtraBars.BarButtonItem barButtonItemClose;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupClose;
        private DevExpress.XtraBars.BarButtonItem barButtonItemResetSettings;
        private DevExpress.XtraBars.BarButtonItem barButtonItemSaveSettings;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupGroupedActions;
    }
}

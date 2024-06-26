namespace Portal.Win.Forms
{
    partial class FrmAppBaseFormMainList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAppBaseFormMainList));
            ribbonControlBaseMainList = new DevExpress.XtraBars.Ribbon.RibbonControl();
            barButtonItemYeni = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemSaveLayout = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemResetLayout = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemUpdateSelectedData = new DevExpress.XtraBars.BarButtonItem();
            barToggleSwitchItemSelectMultiple = new DevExpress.XtraBars.BarToggleSwitchItem();
            barButtonItemPrint = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemToday = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemThisWeek = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemThisMonth = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemFilter = new DevExpress.XtraBars.BarButtonItem();
            ribbonPageBaseModul = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroupListOperations = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroupListFilter = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroupListSettings = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            gridControlMainList = new DevExpress.XtraGrid.GridControl();
            gridViewMainList = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)ribbonControlBaseMainList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControlMainList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewMainList).BeginInit();
            SuspendLayout();
            // 
            // ribbonControlBaseMainList
            // 
            ribbonControlBaseMainList.DrawGroupCaptions = DevExpress.Utils.DefaultBoolean.False;
            ribbonControlBaseMainList.EmptyAreaImageOptions.ImagePadding = new Padding(34, 40, 34, 40);
            ribbonControlBaseMainList.ExpandCollapseItem.Id = 0;
            ribbonControlBaseMainList.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbonControlBaseMainList.ExpandCollapseItem, barButtonItemYeni, barButtonItemSaveLayout, barButtonItemResetLayout, barButtonItemUpdateSelectedData, barToggleSwitchItemSelectMultiple, barButtonItemPrint, barButtonItemToday, barButtonItemThisWeek, barButtonItemThisMonth, barButtonItemFilter });
            ribbonControlBaseMainList.Location = new Point(0, 0);
            ribbonControlBaseMainList.Margin = new Padding(1);
            ribbonControlBaseMainList.MaxItemId = 47;
            ribbonControlBaseMainList.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            ribbonControlBaseMainList.Name = "ribbonControlBaseMainList";
            ribbonControlBaseMainList.OptionsMenuMinWidth = 377;
            ribbonControlBaseMainList.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPageBaseModul });
            ribbonControlBaseMainList.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            ribbonControlBaseMainList.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            ribbonControlBaseMainList.ShowMoreCommandsButton = DevExpress.Utils.DefaultBoolean.False;
            ribbonControlBaseMainList.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            ribbonControlBaseMainList.ShowQatLocationSelector = false;
            ribbonControlBaseMainList.ShowToolbarCustomizeItem = false;
            ribbonControlBaseMainList.Size = new Size(1032, 132);
            ribbonControlBaseMainList.Toolbar.ShowCustomizeItem = false;
            ribbonControlBaseMainList.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // barButtonItemYeni
            // 
            barButtonItemYeni.Caption = "Yeni";
            barButtonItemYeni.Id = 36;
            barButtonItemYeni.ImageOptions.Image = (Image)resources.GetObject("barButtonItemYeni.ImageOptions.Image");
            barButtonItemYeni.ImageOptions.LargeImage = (Image)resources.GetObject("barButtonItemYeni.ImageOptions.LargeImage");
            barButtonItemYeni.Name = "barButtonItemYeni";
            // 
            // barButtonItemSaveLayout
            // 
            barButtonItemSaveLayout.Caption = "Ayarları Sakla";
            barButtonItemSaveLayout.Id = 37;
            barButtonItemSaveLayout.ImageOptions.Image = (Image)resources.GetObject("barButtonItemSaveLayout.ImageOptions.Image");
            barButtonItemSaveLayout.ImageOptions.LargeImage = (Image)resources.GetObject("barButtonItemSaveLayout.ImageOptions.LargeImage");
            barButtonItemSaveLayout.Name = "barButtonItemSaveLayout";
            // 
            // barButtonItemResetLayout
            // 
            barButtonItemResetLayout.Caption = "Ayarları Sil";
            barButtonItemResetLayout.Id = 38;
            barButtonItemResetLayout.ImageOptions.Image = (Image)resources.GetObject("barButtonItemResetLayout.ImageOptions.Image");
            barButtonItemResetLayout.ImageOptions.LargeImage = (Image)resources.GetObject("barButtonItemResetLayout.ImageOptions.LargeImage");
            barButtonItemResetLayout.Name = "barButtonItemResetLayout";
            // 
            // barButtonItemUpdateSelectedData
            // 
            barButtonItemUpdateSelectedData.Caption = "Seçilenleri Güncelle";
            barButtonItemUpdateSelectedData.Id = 39;
            barButtonItemUpdateSelectedData.ImageOptions.Image = (Image)resources.GetObject("barButtonItemUpdateSelectedData.ImageOptions.Image");
            barButtonItemUpdateSelectedData.ImageOptions.LargeImage = (Image)resources.GetObject("barButtonItemUpdateSelectedData.ImageOptions.LargeImage");
            barButtonItemUpdateSelectedData.Name = "barButtonItemUpdateSelectedData";
            barButtonItemUpdateSelectedData.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // barToggleSwitchItemSelectMultiple
            // 
            barToggleSwitchItemSelectMultiple.Caption = "Toplu Kayıt Güncelle";
            barToggleSwitchItemSelectMultiple.Id = 40;
            barToggleSwitchItemSelectMultiple.Name = "barToggleSwitchItemSelectMultiple";
            barToggleSwitchItemSelectMultiple.CheckedChanged += barToggleSwitchItemSelectMultiple_CheckedChanged;
            // 
            // barButtonItemPrint
            // 
            barButtonItemPrint.Caption = "Yazdır";
            barButtonItemPrint.Id = 41;
            barButtonItemPrint.ImageOptions.Image = (Image)resources.GetObject("barButtonItemPrint.ImageOptions.Image");
            barButtonItemPrint.ImageOptions.LargeImage = (Image)resources.GetObject("barButtonItemPrint.ImageOptions.LargeImage");
            barButtonItemPrint.Name = "barButtonItemPrint";
            // 
            // barButtonItemToday
            // 
            barButtonItemToday.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            barButtonItemToday.Caption = "Bugün";
            barButtonItemToday.Down = true;
            barButtonItemToday.GroupIndex = 1;
            barButtonItemToday.Id = 43;
            barButtonItemToday.ImageOptions.Image = (Image)resources.GetObject("barButtonItemToday.ImageOptions.Image");
            barButtonItemToday.ImageOptions.LargeImage = (Image)resources.GetObject("barButtonItemToday.ImageOptions.LargeImage");
            barButtonItemToday.Name = "barButtonItemToday";
            // 
            // barButtonItemThisWeek
            // 
            barButtonItemThisWeek.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            barButtonItemThisWeek.Caption = "Bu Hafta";
            barButtonItemThisWeek.GroupIndex = 1;
            barButtonItemThisWeek.Id = 44;
            barButtonItemThisWeek.ImageOptions.Image = (Image)resources.GetObject("barButtonItemThisWeek.ImageOptions.Image");
            barButtonItemThisWeek.ImageOptions.LargeImage = (Image)resources.GetObject("barButtonItemThisWeek.ImageOptions.LargeImage");
            barButtonItemThisWeek.Name = "barButtonItemThisWeek";
            // 
            // barButtonItemThisMonth
            // 
            barButtonItemThisMonth.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            barButtonItemThisMonth.Caption = "Bu Ay";
            barButtonItemThisMonth.GroupIndex = 1;
            barButtonItemThisMonth.Id = 45;
            barButtonItemThisMonth.ImageOptions.Image = (Image)resources.GetObject("barButtonItemThisMonth.ImageOptions.Image");
            barButtonItemThisMonth.ImageOptions.LargeImage = (Image)resources.GetObject("barButtonItemThisMonth.ImageOptions.LargeImage");
            barButtonItemThisMonth.Name = "barButtonItemThisMonth";
            // 
            // barButtonItemFilter
            // 
            barButtonItemFilter.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            barButtonItemFilter.Caption = "Filtre";
            barButtonItemFilter.GroupIndex = 1;
            barButtonItemFilter.Id = 46;
            barButtonItemFilter.ImageOptions.Image = (Image)resources.GetObject("barButtonItemFilter.ImageOptions.Image");
            barButtonItemFilter.ImageOptions.LargeImage = (Image)resources.GetObject("barButtonItemFilter.ImageOptions.LargeImage");
            barButtonItemFilter.Name = "barButtonItemFilter";
            // 
            // ribbonPageBaseModul
            // 
            ribbonPageBaseModul.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroupListOperations, ribbonPageGroupListFilter, ribbonPageGroupListSettings });
            ribbonPageBaseModul.Name = "ribbonPageBaseModul";
            ribbonPageBaseModul.Text = "BaseModul";
            // 
            // ribbonPageGroupListOperations
            // 
            ribbonPageGroupListOperations.ItemLinks.Add(barButtonItemYeni);
            ribbonPageGroupListOperations.Name = "ribbonPageGroupListOperations";
            ribbonPageGroupListOperations.Text = "Lİst Operations";
            // 
            // ribbonPageGroupListFilter
            // 
            ribbonPageGroupListFilter.ItemLinks.Add(barButtonItemPrint);
            ribbonPageGroupListFilter.ItemLinks.Add(barButtonItemToday, true);
            ribbonPageGroupListFilter.ItemLinks.Add(barButtonItemThisWeek);
            ribbonPageGroupListFilter.ItemLinks.Add(barButtonItemThisMonth);
            ribbonPageGroupListFilter.ItemLinks.Add(barButtonItemFilter);
            ribbonPageGroupListFilter.Name = "ribbonPageGroupListFilter";
            ribbonPageGroupListFilter.Text = "Lİst Filter";
            // 
            // ribbonPageGroupListSettings
            // 
            ribbonPageGroupListSettings.ItemLinks.Add(barButtonItemSaveLayout, true);
            ribbonPageGroupListSettings.ItemLinks.Add(barButtonItemResetLayout);
            ribbonPageGroupListSettings.ItemLinks.Add(barToggleSwitchItemSelectMultiple, true);
            ribbonPageGroupListSettings.ItemLinks.Add(barButtonItemUpdateSelectedData);
            ribbonPageGroupListSettings.Name = "ribbonPageGroupListSettings";
            ribbonPageGroupListSettings.Text = "Lİst Settings";
            // 
            // gridControlMainList
            // 
            gridControlMainList.Dock = DockStyle.Fill;
            gridControlMainList.Location = new Point(0, 132);
            gridControlMainList.MainView = gridViewMainList;
            gridControlMainList.MenuManager = ribbonControlBaseMainList;
            gridControlMainList.Name = "gridControlMainList";
            gridControlMainList.Size = new Size(1032, 522);
            gridControlMainList.TabIndex = 2;
            gridControlMainList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewMainList });
            // 
            // gridViewMainList
            // 
            gridViewMainList.GridControl = gridControlMainList;
            gridViewMainList.Name = "gridViewMainList";
            gridViewMainList.OptionsView.ShowFooter = true;
            // 
            // FrmAppBaseFormMainList
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 654);
            Controls.Add(gridControlMainList);
            Controls.Add(ribbonControlBaseMainList);
            IconOptions.ShowIcon = false;
            Margin = new Padding(4);
            Name = "FrmAppBaseFormMainList";
            ShowInTaskbar = false;
            Text = "BaseFormMainList";
            ((System.ComponentModel.ISupportInitialize)ribbonControlBaseMainList).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControlMainList).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewMainList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageBaseModul;
        public DevExpress.XtraBars.Ribbon.RibbonControl ribbonControlBaseMainList;
        private DevExpress.XtraGrid.GridControl gridControlMainList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMainList;
        private DevExpress.XtraBars.BarButtonItem barButtonItemYeni;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupListSettings;
        private DevExpress.XtraBars.BarButtonItem barButtonItemSaveLayout;
        private DevExpress.XtraBars.BarButtonItem barButtonItemResetLayout;
        private DevExpress.XtraBars.BarButtonItem barButtonItemUpdateSelectedData;
        private DevExpress.XtraBars.BarToggleSwitchItem barToggleSwitchItemSelectMultiple;
        private DevExpress.XtraBars.BarButtonItem barButtonItemPrint;
        public DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupListOperations;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupListFilter;
        private DevExpress.XtraBars.BarButtonItem barButtonItemToday;
        private DevExpress.XtraBars.BarButtonItem barButtonItemThisWeek;
        private DevExpress.XtraBars.BarButtonItem barButtonItemThisMonth;
        private DevExpress.XtraBars.BarButtonItem barButtonItemFilter;
    }
}

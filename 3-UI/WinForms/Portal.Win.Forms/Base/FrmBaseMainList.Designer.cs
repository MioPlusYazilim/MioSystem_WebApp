namespace Portal.Win.Forms
{
    partial class FrmBaseMainList
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBaseMainList));
            this.BarMenuMgn = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barBtnNew = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItemYeni = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItemSatisFaturasi = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemAlisFaturasi = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemSatistanIadeFaturasi = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemAlistanIadeFaturasi = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemIadeDekont = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemMusteriDekontu = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemLanguage = new DevExpress.XtraBars.BarButtonItem();
            this.BarBtnClose = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnPrint = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnDefaultView = new DevExpress.XtraBars.BarButtonItem();
            this.barToggleSwitchTopluGuncelleme = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.barButtonItemSecimiGuncelle = new DevExpress.XtraBars.BarButtonItem();
            this.standaloneBarDockControl1 = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.ımageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.BarBtnReSize = new DevExpress.XtraBars.BarButtonItem();
            this.BarBtnCopy = new DevExpress.XtraBars.BarButtonItem();
            this.barToggleSwitchItem1 = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.tempGridControl = new DevExpress.XtraGrid.GridControl();
            this.tempGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.BarMenuMgn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ımageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // BarMenuMgn
            // 
            this.BarMenuMgn.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.BarMenuMgn.DockControls.Add(this.barDockControlTop);
            this.BarMenuMgn.DockControls.Add(this.barDockControlBottom);
            this.BarMenuMgn.DockControls.Add(this.barDockControlLeft);
            this.BarMenuMgn.DockControls.Add(this.barDockControlRight);
            this.BarMenuMgn.DockControls.Add(this.standaloneBarDockControl1);
            this.BarMenuMgn.Form = this;
            this.BarMenuMgn.Images = this.ımageCollection1;
            this.BarMenuMgn.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barBtnNew,
            this.barBtnEdit,
            this.BarBtnClose,
            this.barBtnRefresh,
            this.BarBtnReSize,
            this.BarBtnCopy,
            this.barBtnPrint,
            this.barButtonItemLanguage,
            this.barSubItemYeni,
            this.barButtonItemSatisFaturasi,
            this.barButtonItemAlisFaturasi,
            this.barButtonItemSatistanIadeFaturasi,
            this.barButtonItemAlistanIadeFaturasi,
            this.barButtonItemIadeDekont,
            this.barButtonItemMusteriDekontu,
            this.barBtnDefaultView,
            this.barToggleSwitchItem1,
            this.barToggleSwitchTopluGuncelleme,
            this.barButtonItemSecimiGuncelle});
            this.BarMenuMgn.MaxItemId = 50;
            this.BarMenuMgn.MdiMenuMergeStyle = DevExpress.XtraBars.BarMdiMenuMergeStyle.Never;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnNew),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItemYeni),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnRefresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemLanguage, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.BarBtnClose, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnPrint),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnDefaultView, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barToggleSwitchTopluGuncelleme, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemSecimiGuncelle)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.StandaloneBarDockControl = this.standaloneBarDockControl1;
            this.bar1.Text = "Tools";
            // 
            // barBtnNew
            // 
            this.barBtnNew.Caption = "&Yeni";
            this.barBtnNew.CausesValidation = true;
            this.barBtnNew.Hint = "Mevcut işlem için yeni bir kayıt yaratmak için kullanınız.";
            this.barBtnNew.Id = 0;
            this.barBtnNew.ImageOptions.ImageIndex = 0;
            this.barBtnNew.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F2);
            this.barBtnNew.Name = "barBtnNew";
            this.barBtnNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnNew.ShortcutKeyDisplayString = "F2";
            this.barBtnNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarBtnNew_ItemClick);
            // 
            // barSubItemYeni
            // 
            this.barSubItemYeni.Caption = "Yeni";
            this.barSubItemYeni.Id = 38;
            this.barSubItemYeni.ImageOptions.ImageIndex = 0;
            this.barSubItemYeni.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemSatisFaturasi),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemAlisFaturasi),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemSatistanIadeFaturasi),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemAlistanIadeFaturasi),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemIadeDekont),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemMusteriDekontu)});
            this.barSubItemYeni.Name = "barSubItemYeni";
            this.barSubItemYeni.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barSubItemYeni.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // barButtonItemSatisFaturasi
            // 
            this.barButtonItemSatisFaturasi.Caption = "Satış Faturası";
            this.barButtonItemSatisFaturasi.Id = 39;
            this.barButtonItemSatisFaturasi.Name = "barButtonItemSatisFaturasi";
            this.barButtonItemSatisFaturasi.Tag = 0;
            this.barButtonItemSatisFaturasi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemSatisFaturasi_ItemClick);
            // 
            // barButtonItemAlisFaturasi
            // 
            this.barButtonItemAlisFaturasi.Caption = "Alış Faturası";
            this.barButtonItemAlisFaturasi.Id = 40;
            this.barButtonItemAlisFaturasi.Name = "barButtonItemAlisFaturasi";
            this.barButtonItemAlisFaturasi.Tag = 1;
            this.barButtonItemAlisFaturasi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemSatisFaturasi_ItemClick);
            // 
            // barButtonItemSatistanIadeFaturasi
            // 
            this.barButtonItemSatistanIadeFaturasi.Caption = "Satıştan İade Faturası";
            this.barButtonItemSatistanIadeFaturasi.Id = 41;
            this.barButtonItemSatistanIadeFaturasi.Name = "barButtonItemSatistanIadeFaturasi";
            this.barButtonItemSatistanIadeFaturasi.Tag = 2;
            this.barButtonItemSatistanIadeFaturasi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemSatisFaturasi_ItemClick);
            // 
            // barButtonItemAlistanIadeFaturasi
            // 
            this.barButtonItemAlistanIadeFaturasi.Caption = "Alıştan İade Faturası";
            this.barButtonItemAlistanIadeFaturasi.Id = 42;
            this.barButtonItemAlistanIadeFaturasi.Name = "barButtonItemAlistanIadeFaturasi";
            this.barButtonItemAlistanIadeFaturasi.Tag = 3;
            this.barButtonItemAlistanIadeFaturasi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemSatisFaturasi_ItemClick);
            // 
            // barButtonItemIadeDekont
            // 
            this.barButtonItemIadeDekont.Caption = "İade Dekontu";
            this.barButtonItemIadeDekont.Id = 43;
            this.barButtonItemIadeDekont.Name = "barButtonItemIadeDekont";
            this.barButtonItemIadeDekont.Tag = 4;
            this.barButtonItemIadeDekont.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemSatisFaturasi_ItemClick);
            // 
            // barButtonItemMusteriDekontu
            // 
            this.barButtonItemMusteriDekontu.Caption = "Müşteri Dekontu";
            this.barButtonItemMusteriDekontu.Id = 44;
            this.barButtonItemMusteriDekontu.Name = "barButtonItemMusteriDekontu";
            this.barButtonItemMusteriDekontu.Tag = 5;
            this.barButtonItemMusteriDekontu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemSatisFaturasi_ItemClick);
            // 
            // barBtnEdit
            // 
            this.barBtnEdit.Caption = "&Düzenle";
            this.barBtnEdit.CausesValidation = true;
            this.barBtnEdit.Hint = "Mevcut seçili kayıtı düzenleme için açar.";
            this.barBtnEdit.Id = 2;
            this.barBtnEdit.ImageOptions.ImageIndex = 1;
            this.barBtnEdit.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F4);
            this.barBtnEdit.Name = "barBtnEdit";
            this.barBtnEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnEdit.ShortcutKeyDisplayString = "F4";
            this.barBtnEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarBtnEdit_ItemClick);
            // 
            // barBtnRefresh
            // 
            this.barBtnRefresh.Caption = "Y&enile";
            this.barBtnRefresh.CausesValidation = true;
            this.barBtnRefresh.Hint = "Mevcut kayıt üzerinde yaptığınız tüm işlemleri iptal ederek kaydı yeniden çağırır" +
    ".";
            this.barBtnRefresh.Id = 10;
            this.barBtnRefresh.ImageOptions.ImageIndex = 2;
            this.barBtnRefresh.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.barBtnRefresh.Name = "barBtnRefresh";
            this.barBtnRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnRefresh.ShortcutKeyDisplayString = "F5";
            this.barBtnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarBtnRefresh_ItemClick);
            // 
            // barButtonItemLanguage
            // 
            this.barButtonItemLanguage.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barButtonItemLanguage.Caption = "Dil";
            this.barButtonItemLanguage.Id = 37;
            this.barButtonItemLanguage.Name = "barButtonItemLanguage";
            this.barButtonItemLanguage.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barButtonItemLanguage.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemLanguage_ItemClick);
            // 
            // BarBtnClose
            // 
            this.BarBtnClose.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.BarBtnClose.Caption = "Kapat";
            this.BarBtnClose.CausesValidation = true;
            this.BarBtnClose.Hint = "Mevcut formu kapatmak için seçiniz.";
            this.BarBtnClose.Id = 3;
            this.BarBtnClose.ImageOptions.ImageIndex = 4;
            this.BarBtnClose.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4));
            this.BarBtnClose.Name = "BarBtnClose";
            this.BarBtnClose.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.BarBtnClose.ShortcutKeyDisplayString = "Ctrl+F4";
            this.BarBtnClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarBtnClose_ItemClick);
            // 
            // barBtnPrint
            // 
            this.barBtnPrint.Caption = "Yazdır";
            this.barBtnPrint.Id = 36;
            this.barBtnPrint.ImageOptions.ImageIndex = 3;
            this.barBtnPrint.Name = "barBtnPrint";
            this.barBtnPrint.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnPrint_ItemClick);
            // 
            // barBtnDefaultView
            // 
            this.barBtnDefaultView.Caption = "Liste Ayarlarını Temizle";
            this.barBtnDefaultView.Id = 45;
            this.barBtnDefaultView.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnDefaultView.ImageOptions.Image")));
            this.barBtnDefaultView.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnDefaultView.ImageOptions.LargeImage")));
            this.barBtnDefaultView.Name = "barBtnDefaultView";
            this.barBtnDefaultView.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnDefaultView.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnDefaultView_ItemClick);
            // 
            // barToggleSwitchTopluGuncelleme
            // 
            this.barToggleSwitchTopluGuncelleme.Caption = "Cari Hareket Güncelleme";
            this.barToggleSwitchTopluGuncelleme.Id = 47;
            this.barToggleSwitchTopluGuncelleme.Name = "barToggleSwitchTopluGuncelleme";
            this.barToggleSwitchTopluGuncelleme.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.barToggleSwitchTopluGuncelleme_CheckedChanged);
            // 
            // barButtonItemSecimiGuncelle
            // 
            this.barButtonItemSecimiGuncelle.Caption = "Seçimi Güncelle";
            this.barButtonItemSecimiGuncelle.Id = 48;
            this.barButtonItemSecimiGuncelle.ImageOptions.ImageIndex = 8;
            this.barButtonItemSecimiGuncelle.Name = "barButtonItemSecimiGuncelle";
            this.barButtonItemSecimiGuncelle.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItemSecimiGuncelle.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barButtonItemSecimiGuncelle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemSecimiGuncelle_ItemClick);
            // 
            // standaloneBarDockControl1
            // 
            this.standaloneBarDockControl1.AutoSize = true;
            this.standaloneBarDockControl1.CausesValidation = false;
            this.standaloneBarDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.standaloneBarDockControl1.Location = new System.Drawing.Point(0, 0);
            this.standaloneBarDockControl1.Manager = this.BarMenuMgn;
            this.standaloneBarDockControl1.Name = "standaloneBarDockControl1";
            this.standaloneBarDockControl1.Size = new System.Drawing.Size(885, 28);
            this.standaloneBarDockControl1.Text = "standaloneBarDockControl1";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.BarMenuMgn;
            this.barDockControlTop.Size = new System.Drawing.Size(885, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 531);
            this.barDockControlBottom.Manager = this.BarMenuMgn;
            this.barDockControlBottom.Size = new System.Drawing.Size(885, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.BarMenuMgn;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 531);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(885, 0);
            this.barDockControlRight.Manager = this.BarMenuMgn;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 531);
            // 
            // ımageCollection1
            // 
            this.ımageCollection1.ImageSize = new System.Drawing.Size(20, 20);
            this.ımageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ımageCollection1.ImageStream")));
            this.ımageCollection1.InsertGalleryImage("addfile_32x32.png", "images/actions/addfile_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/addfile_32x32.png"), 0);
            this.ımageCollection1.Images.SetKeyName(0, "addfile_32x32.png");
            this.ımageCollection1.InsertGalleryImage("editdatasource_32x32.png", "office2013/data/editdatasource_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/data/editdatasource_32x32.png"), 1);
            this.ımageCollection1.Images.SetKeyName(1, "editdatasource_32x32.png");
            this.ımageCollection1.InsertGalleryImage("refresh_32x32.png", "office2013/actions/refresh_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/refresh_32x32.png"), 2);
            this.ımageCollection1.Images.SetKeyName(2, "refresh_32x32.png");
            this.ımageCollection1.InsertGalleryImage("print_32x32.png", "office2013/print/print_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/print/print_32x32.png"), 3);
            this.ımageCollection1.Images.SetKeyName(3, "print_32x32.png");
            this.ımageCollection1.InsertGalleryImage("close_32x32.png", "office2013/actions/close_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/close_32x32.png"), 4);
            this.ımageCollection1.Images.SetKeyName(4, "close_32x32.png");
            this.ımageCollection1.InsertGalleryImage("publish_32x32.png", "office2013/miscellaneous/publish_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/miscellaneous/publish_32x32.png"), 5);
            this.ımageCollection1.Images.SetKeyName(5, "publish_32x32.png");
            this.ımageCollection1.Images.SetKeyName(6, "Tr.png");
            this.ımageCollection1.Images.SetKeyName(7, "Gb.png");
            this.ımageCollection1.Images.SetKeyName(8, "showall_32x32.png");
            // 
            // BarBtnReSize
            // 
            this.BarBtnReSize.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.BarBtnReSize.Caption = "Pencere Modu";
            this.BarBtnReSize.CausesValidation = true;
            this.BarBtnReSize.Hint = "Ekranın ana menuye bağlı olmasını veya ayrı bir ğencere şekinde görünmesi için se" +
    "çiniz.";
            this.BarBtnReSize.Id = 13;
            this.BarBtnReSize.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.BarBtnReSize.ImageOptions.ImageIndex = 12;
            this.BarBtnReSize.Name = "BarBtnReSize";
            // 
            // BarBtnCopy
            // 
            this.BarBtnCopy.Caption = "Kopya Oluştur";
            this.BarBtnCopy.Id = 29;
            this.BarBtnCopy.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.BarBtnCopy.ImageOptions.ImageIndex = 13;
            this.BarBtnCopy.Name = "BarBtnCopy";
            // 
            // barToggleSwitchItem1
            // 
            this.barToggleSwitchItem1.Caption = "barToggleSwitchItem1";
            this.barToggleSwitchItem1.Id = 46;
            this.barToggleSwitchItem1.Name = "barToggleSwitchItem1";
            // 
            // tempGridControl
            // 
            this.tempGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tempGridControl.Location = new System.Drawing.Point(0, 64);
            this.tempGridControl.MainView = this.tempGridView;
            this.tempGridControl.Name = "tempGridControl";
            this.tempGridControl.Size = new System.Drawing.Size(885, 467);
            this.tempGridControl.TabIndex = 450;
            this.tempGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tempGridView});
            // 
            // tempGridView
            // 
            this.tempGridView.GridControl = this.tempGridControl;
            this.tempGridView.Name = "tempGridView";
            this.tempGridView.OptionsBehavior.Editable = false;
            this.tempGridView.OptionsBehavior.ReadOnly = true;
            this.tempGridView.OptionsLayout.Columns.StoreAllOptions = true;
            this.tempGridView.OptionsLayout.StoreAllOptions = true;
            this.tempGridView.OptionsLayout.StoreFormatRules = true;
            this.tempGridView.OptionsSelection.ShowCheckBoxSelectorInGroupRow = DevExpress.Utils.DefaultBoolean.False;
            this.tempGridView.OptionsView.ColumnAutoWidth = false;
            this.tempGridView.OptionsView.EnableAppearanceEvenRow = true;
            this.tempGridView.OptionsView.EnableAppearanceOddRow = true;
            this.tempGridView.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.tempGridView.OptionsView.ShowAutoFilterRow = true;
            this.tempGridView.OptionsView.ShowFooter = true;
            this.tempGridView.OptionsView.ShowGroupedColumns = true;
            this.tempGridView.OptionsView.ShowGroupPanel = false;
            this.tempGridView.OptionsView.WaitAnimationOptions = DevExpress.XtraEditors.WaitAnimationOptions.Indicator;
            this.tempGridView.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.TempGridView_RowCellStyle);
            this.tempGridView.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.TempGridView_RowStyle);
            this.tempGridView.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.tempGridView_SelectionChanged);
            this.tempGridView.DoubleClick += new System.EventHandler(this.TempListGridView_DoubleClick);
            // 
            // panelControl1
            // 
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 28);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(885, 36);
            this.panelControl1.TabIndex = 456;
            // 
            // TempMainList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 531);
            this.Controls.Add(this.tempGridControl);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.standaloneBarDockControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.ShowIcon = false;
            this.Name = "TempMainList";
            this.ShowInTaskbar = false;
            this.Shown += new System.EventHandler(this.TempMainList_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.BarMenuMgn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ımageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.BarManager BarMenuMgn;
        private DevExpress.XtraBars.Bar bar1;
        protected DevExpress.XtraBars.BarButtonItem barBtnEdit;
        public DevExpress.XtraBars.BarButtonItem barBtnRefresh;
        public DevExpress.XtraBars.BarButtonItem BarBtnReSize;
        public DevExpress.XtraBars.BarButtonItem BarBtnClose;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem BarBtnCopy;
        private DevExpress.XtraBars.StandaloneBarDockControl standaloneBarDockControl1;
        private DevExpress.Utils.ImageCollection ımageCollection1;
        private DevExpress.XtraGrid.GridControl tempGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView tempGridView;
        public DevExpress.XtraBars.BarButtonItem barBtnNew;
        private DevExpress.XtraBars.BarButtonItem barBtnPrint;
        protected DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemLanguage;
        private DevExpress.XtraBars.BarSubItem barSubItemYeni;
        private DevExpress.XtraBars.BarButtonItem barButtonItemSatisFaturasi;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAlisFaturasi;
        private DevExpress.XtraBars.BarButtonItem barButtonItemSatistanIadeFaturasi;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAlistanIadeFaturasi;
        private DevExpress.XtraBars.BarButtonItem barButtonItemIadeDekont;
        private DevExpress.XtraBars.BarButtonItem barButtonItemMusteriDekontu;
        private DevExpress.XtraBars.BarButtonItem barBtnDefaultView;
        private DevExpress.XtraBars.BarToggleSwitchItem barToggleSwitchTopluGuncelleme;
        private DevExpress.XtraBars.BarToggleSwitchItem barToggleSwitchItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemSecimiGuncelle;
    }
}

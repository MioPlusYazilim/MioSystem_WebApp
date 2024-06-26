namespace Portal.Win.Forms
{
    partial class FrmDashboardMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDashboardMain));
            DevExpress.Utils.Animation.PushTransition pushTransition1 = new DevExpress.Utils.Animation.PushTransition();
            ribbonControlDashBoard = new DevExpress.XtraBars.Ribbon.RibbonControl();
            barButtonItemBuAy = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemBugun = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemFiltre = new DevExpress.XtraBars.BarButtonItem();
            barWorkspaceMenuItem1 = new DevExpress.XtraBars.BarWorkspaceMenuItem();
            workspaceManager1 = new DevExpress.Utils.WorkspaceManager(components);
            barButtonGroup1 = new DevExpress.XtraBars.BarButtonGroup();
            barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            barButtonGroup2 = new DevExpress.XtraBars.BarButtonGroup();
            barDockingMenuItem1 = new DevExpress.XtraBars.BarDockingMenuItem();
            barButtonGroup3 = new DevExpress.XtraBars.BarButtonGroup();
            barButtonItemBuHafta = new DevExpress.XtraBars.BarButtonItem();
            barLinkContainerItem1 = new DevExpress.XtraBars.BarLinkContainerItem();
            barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            barButtonItem15 = new DevExpress.XtraBars.BarButtonItem();
            barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
            barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            barMdiChildrenListItem1 = new DevExpress.XtraBars.BarMdiChildrenListItem();
            barButtonItem16 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem17 = new DevExpress.XtraBars.BarButtonItem();
            ribbonPageDashBoard = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroupDashBoard = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            barButtonItemRefresh = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)ribbonControlDashBoard).BeginInit();
            SuspendLayout();
            // 
            // ribbonControlDashBoard
            // 
            ribbonControlDashBoard.DrawGroupCaptions = DevExpress.Utils.DefaultBoolean.False;
            ribbonControlDashBoard.EmptyAreaImageOptions.ImagePadding = new Padding(34, 40, 34, 40);
            ribbonControlDashBoard.ExpandCollapseItem.Id = 0;
            ribbonControlDashBoard.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbonControlDashBoard.ExpandCollapseItem, barButtonItemBuAy, barButtonItemBugun, barButtonItemFiltre, barWorkspaceMenuItem1, barButtonGroup1, barButtonItem10, barButtonGroup2, barDockingMenuItem1, barButtonGroup3, barButtonItemBuHafta, barLinkContainerItem1, barSubItem2, barButtonItem15, barCheckItem1, barStaticItem1, barMdiChildrenListItem1, barButtonItem16, barButtonItem17, barButtonItemRefresh });
            ribbonControlDashBoard.Location = new Point(0, 0);
            ribbonControlDashBoard.Margin = new Padding(1);
            ribbonControlDashBoard.MaxItemId = 35;
            ribbonControlDashBoard.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            ribbonControlDashBoard.Name = "ribbonControlDashBoard";
            ribbonControlDashBoard.OptionsMenuMinWidth = 377;
            ribbonControlDashBoard.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPageDashBoard });
            ribbonControlDashBoard.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            ribbonControlDashBoard.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            ribbonControlDashBoard.ShowMoreCommandsButton = DevExpress.Utils.DefaultBoolean.False;
            ribbonControlDashBoard.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            ribbonControlDashBoard.ShowQatLocationSelector = false;
            ribbonControlDashBoard.ShowToolbarCustomizeItem = false;
            ribbonControlDashBoard.Size = new Size(1258, 132);
            ribbonControlDashBoard.Toolbar.ShowCustomizeItem = false;
            ribbonControlDashBoard.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // barButtonItemBuAy
            // 
            barButtonItemBuAy.Caption = "Bu Ay";
            barButtonItemBuAy.GroupIndex = 1;
            barButtonItemBuAy.Id = 3;
            barButtonItemBuAy.ImageOptions.Image = (Image)resources.GetObject("barButtonItemBuAy.ImageOptions.Image");
            barButtonItemBuAy.ImageOptions.LargeImage = (Image)resources.GetObject("barButtonItemBuAy.ImageOptions.LargeImage");
            barButtonItemBuAy.Name = "barButtonItemBuAy";
            barButtonItemBuAy.Tag = 3;
            // 
            // barButtonItemBugun
            // 
            barButtonItemBugun.Caption = "Bugün";
            barButtonItemBugun.GroupIndex = 1;
            barButtonItemBugun.Id = 5;
            barButtonItemBugun.ImageOptions.Image = (Image)resources.GetObject("barButtonItemBugun.ImageOptions.Image");
            barButtonItemBugun.ImageOptions.LargeImage = (Image)resources.GetObject("barButtonItemBugun.ImageOptions.LargeImage");
            barButtonItemBugun.Name = "barButtonItemBugun";
            barButtonItemBugun.Tag = 1;
            // 
            // barButtonItemFiltre
            // 
            barButtonItemFiltre.Caption = "Filtre";
            barButtonItemFiltre.Id = 6;
            barButtonItemFiltre.ImageOptions.Image = (Image)resources.GetObject("barButtonItemFiltre.ImageOptions.Image");
            barButtonItemFiltre.ImageOptions.LargeImage = (Image)resources.GetObject("barButtonItemFiltre.ImageOptions.LargeImage");
            barButtonItemFiltre.Name = "barButtonItemFiltre";
            barButtonItemFiltre.Tag = 4;
            // 
            // barWorkspaceMenuItem1
            // 
            barWorkspaceMenuItem1.Caption = "barWorkspaceMenuItem1";
            barWorkspaceMenuItem1.Id = 9;
            barWorkspaceMenuItem1.Name = "barWorkspaceMenuItem1";
            barWorkspaceMenuItem1.WorkspaceManager = workspaceManager1;
            // 
            // workspaceManager1
            // 
            workspaceManager1.TargetControl = this;
            workspaceManager1.TransitionType = pushTransition1;
            // 
            // barButtonGroup1
            // 
            barButtonGroup1.Caption = "barButtonGroup1";
            barButtonGroup1.Id = 10;
            barButtonGroup1.Name = "barButtonGroup1";
            // 
            // barButtonItem10
            // 
            barButtonItem10.Caption = "&New";
            barButtonItem10.Id = 11;
            barButtonItem10.ImageOptions.Image = (Image)resources.GetObject("barButtonItem10.ImageOptions.Image");
            barButtonItem10.ImageOptions.LargeImage = (Image)resources.GetObject("barButtonItem10.ImageOptions.LargeImage");
            barButtonItem10.Name = "barButtonItem10";
            // 
            // barButtonGroup2
            // 
            barButtonGroup2.Caption = "barButtonGroup2";
            barButtonGroup2.Id = 16;
            barButtonGroup2.ImageOptions.Image = (Image)resources.GetObject("barButtonGroup2.ImageOptions.Image");
            barButtonGroup2.ImageOptions.LargeImage = (Image)resources.GetObject("barButtonGroup2.ImageOptions.LargeImage");
            barButtonGroup2.Name = "barButtonGroup2";
            // 
            // barDockingMenuItem1
            // 
            barDockingMenuItem1.Caption = "barDockingMenuItem1";
            barDockingMenuItem1.Id = 17;
            barDockingMenuItem1.Name = "barDockingMenuItem1";
            // 
            // barButtonGroup3
            // 
            barButtonGroup3.Caption = "barButtonGroup3";
            barButtonGroup3.Id = 18;
            barButtonGroup3.Name = "barButtonGroup3";
            // 
            // barButtonItemBuHafta
            // 
            barButtonItemBuHafta.Caption = "Bu Hafta";
            barButtonItemBuHafta.GroupIndex = 1;
            barButtonItemBuHafta.Id = 19;
            barButtonItemBuHafta.ImageOptions.Image = (Image)resources.GetObject("barButtonItemBuHafta.ImageOptions.Image");
            barButtonItemBuHafta.ImageOptions.LargeImage = (Image)resources.GetObject("barButtonItemBuHafta.ImageOptions.LargeImage");
            barButtonItemBuHafta.Name = "barButtonItemBuHafta";
            barButtonItemBuHafta.Tag = 2;
            // 
            // barLinkContainerItem1
            // 
            barLinkContainerItem1.Caption = "barLinkContainerItem1";
            barLinkContainerItem1.Id = 20;
            barLinkContainerItem1.Name = "barLinkContainerItem1";
            // 
            // barSubItem2
            // 
            barSubItem2.Caption = "barSubItem2";
            barSubItem2.Id = 21;
            barSubItem2.ImageOptions.Image = (Image)resources.GetObject("barSubItem2.ImageOptions.Image");
            barSubItem2.ImageOptions.LargeImage = (Image)resources.GetObject("barSubItem2.ImageOptions.LargeImage");
            barSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(barButtonItem15), new DevExpress.XtraBars.LinkPersistInfo(barCheckItem1), new DevExpress.XtraBars.LinkPersistInfo(barStaticItem1) });
            barSubItem2.Name = "barSubItem2";
            // 
            // barButtonItem15
            // 
            barButtonItem15.Caption = "barButtonItem14";
            barButtonItem15.Id = 22;
            barButtonItem15.Name = "barButtonItem15";
            // 
            // barCheckItem1
            // 
            barCheckItem1.Caption = "barCheckItem1";
            barCheckItem1.Id = 23;
            barCheckItem1.Name = "barCheckItem1";
            // 
            // barStaticItem1
            // 
            barStaticItem1.Caption = "barStaticItem1";
            barStaticItem1.Id = 24;
            barStaticItem1.Name = "barStaticItem1";
            // 
            // barMdiChildrenListItem1
            // 
            barMdiChildrenListItem1.Caption = "barMdiChildrenListItem1";
            barMdiChildrenListItem1.Id = 25;
            barMdiChildrenListItem1.ImageOptions.Image = (Image)resources.GetObject("barMdiChildrenListItem1.ImageOptions.Image");
            barMdiChildrenListItem1.ImageOptions.LargeImage = (Image)resources.GetObject("barMdiChildrenListItem1.ImageOptions.LargeImage");
            barMdiChildrenListItem1.Name = "barMdiChildrenListItem1";
            // 
            // barButtonItem16
            // 
            barButtonItem16.Caption = "barButtonItem15";
            barButtonItem16.Id = 26;
            barButtonItem16.Name = "barButtonItem16";
            // 
            // barButtonItem17
            // 
            barButtonItem17.Caption = "barButtonItem16";
            barButtonItem17.Id = 27;
            barButtonItem17.Name = "barButtonItem17";
            // 
            // ribbonPageDashBoard
            // 
            ribbonPageDashBoard.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroupDashBoard });
            ribbonPageDashBoard.Name = "ribbonPageDashBoard";
            ribbonPageDashBoard.Text = "DashBoard";
            // 
            // ribbonPageGroupDashBoard
            // 
            ribbonPageGroupDashBoard.ItemLinks.Add(barButtonItemBugun);
            ribbonPageGroupDashBoard.ItemLinks.Add(barButtonItemBuHafta);
            ribbonPageGroupDashBoard.ItemLinks.Add(barButtonItemBuAy);
            ribbonPageGroupDashBoard.ItemLinks.Add(barButtonItemRefresh, true);
            ribbonPageGroupDashBoard.ItemLinks.Add(barButtonItemFiltre, true);
            ribbonPageGroupDashBoard.Name = "ribbonPageGroupDashBoard";
            ribbonPageGroupDashBoard.Text = "DashBoard";
            // 
            // barButtonItemRefresh
            // 
            barButtonItemRefresh.Caption = "Yenile";
            barButtonItemRefresh.Id = 34;
            barButtonItemRefresh.ImageOptions.Image = (Image)resources.GetObject("barButtonItemRefresh.ImageOptions.Image");
            barButtonItemRefresh.ImageOptions.LargeImage = (Image)resources.GetObject("barButtonItemRefresh.ImageOptions.LargeImage");
            barButtonItemRefresh.Name = "barButtonItemRefresh";
            // 
            // FrmDashboardMain
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 654);
            Controls.Add(ribbonControlDashBoard);
            IconOptions.ShowIcon = false;
            Margin = new Padding(4);
            Name = "FrmDashboardMain";
            ShowInTaskbar = false;
            Text = "DashBoard";
            ((System.ComponentModel.ISupportInitialize)ribbonControlDashBoard).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControlDashBoard;
        private DevExpress.XtraBars.BarButtonItem barButtonItemBuAy;
        private DevExpress.XtraBars.BarButtonItem barButtonItemBugun;
        private DevExpress.XtraBars.BarButtonItem barButtonItemFiltre;
        private DevExpress.XtraBars.BarWorkspaceMenuItem barWorkspaceMenuItem1;
        private DevExpress.Utils.WorkspaceManager workspaceManager1;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup2;
        private DevExpress.XtraBars.BarDockingMenuItem barDockingMenuItem1;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup3;
        private DevExpress.XtraBars.BarButtonItem barButtonItemBuHafta;
        private DevExpress.XtraBars.BarLinkContainerItem barLinkContainerItem1;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem15;
        private DevExpress.XtraBars.BarCheckItem barCheckItem1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarMdiChildrenListItem barMdiChildrenListItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem16;
        private DevExpress.XtraBars.BarButtonItem barButtonItem17;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageDashBoard;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupDashBoard;
        private DevExpress.XtraBars.BarButtonItem barButtonItemRefresh;
    }
}

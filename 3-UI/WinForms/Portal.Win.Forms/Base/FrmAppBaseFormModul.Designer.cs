namespace Portal.Win.Forms
{
    partial class FrmAppBaseFormModul
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
            ribbonControlBaseModul = new DevExpress.XtraBars.Ribbon.RibbonControl();
            ribbonPageBaseModul = new DevExpress.XtraBars.Ribbon.RibbonPage();
            documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(components);
            tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(components);
            noDocumentsView1 = new DevExpress.XtraBars.Docking2010.Views.NoDocuments.NoDocumentsView(components);
            ((System.ComponentModel.ISupportInitialize)ribbonControlBaseModul).BeginInit();
            ((System.ComponentModel.ISupportInitialize)documentManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tabbedView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)noDocumentsView1).BeginInit();
            SuspendLayout();
            // 
            // ribbonControlBaseModul
            // 
            ribbonControlBaseModul.DrawGroupCaptions = DevExpress.Utils.DefaultBoolean.True;
            ribbonControlBaseModul.EmptyAreaImageOptions.ImagePadding = new Padding(34, 40, 34, 40);
            ribbonControlBaseModul.ExpandCollapseItem.Id = 0;
            ribbonControlBaseModul.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbonControlBaseModul.ExpandCollapseItem });
            ribbonControlBaseModul.Location = new Point(0, 0);
            ribbonControlBaseModul.Margin = new Padding(1);
            ribbonControlBaseModul.MaxItemId = 36;
            ribbonControlBaseModul.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            ribbonControlBaseModul.Name = "ribbonControlBaseModul";
            ribbonControlBaseModul.OptionsMenuMinWidth = 377;
            ribbonControlBaseModul.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPageBaseModul });
            ribbonControlBaseModul.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            ribbonControlBaseModul.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            ribbonControlBaseModul.ShowMoreCommandsButton = DevExpress.Utils.DefaultBoolean.False;
            ribbonControlBaseModul.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            ribbonControlBaseModul.ShowQatLocationSelector = false;
            ribbonControlBaseModul.ShowToolbarCustomizeItem = false;
            ribbonControlBaseModul.Size = new Size(1032, 153);
            ribbonControlBaseModul.Toolbar.ShowCustomizeItem = false;
            ribbonControlBaseModul.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // ribbonPageBaseModul
            // 
            ribbonPageBaseModul.Name = "ribbonPageBaseModul";
            ribbonPageBaseModul.Text = "BaseModul";
            // 
            // documentManager1
            // 
            documentManager1.ContainerControl = this;
            documentManager1.MenuManager = ribbonControlBaseModul;
            documentManager1.View = tabbedView1;
            documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] { tabbedView1, noDocumentsView1 });
            // 
            // FrmAppBaseFormModul
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 654);
            Controls.Add(ribbonControlBaseModul);
            IconOptions.ShowIcon = false;
            Margin = new Padding(4);
            Name = "FrmAppBaseFormModul";
            ShowInTaskbar = false;
            Text = "BaseFormModul";
            ((System.ComponentModel.ISupportInitialize)ribbonControlBaseModul).EndInit();
            ((System.ComponentModel.ISupportInitialize)documentManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tabbedView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)noDocumentsView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControlBaseModul;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageBaseModul;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.NoDocuments.NoDocumentsView noDocumentsView1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
    }
}

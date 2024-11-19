namespace MioSystem
{
    partial class FrmMainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainForm));
            fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            MainMenuAccordionControl = new DevExpress.XtraBars.Navigation.AccordionControl();
            accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            skinPaletteDropDownButtonItem1 = new DevExpress.XtraBars.SkinPaletteDropDownButtonItem();
            skinBarSubItem1 = new DevExpress.XtraBars.SkinBarSubItem();
            skinBarSubItem2 = new DevExpress.XtraBars.SkinBarSubItem();
            barStaticItemNavigation = new DevExpress.XtraBars.BarStaticItem();
            fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(components);
            accordionControlOpenedModules = new DevExpress.XtraBars.Navigation.AccordionControl();
            ((System.ComponentModel.ISupportInitialize)MainMenuAccordionControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fluentDesignFormControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fluentFormDefaultManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accordionControlOpenedModules).BeginInit();
            SuspendLayout();
            // 
            // fluentDesignFormContainer1
            // 
            fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            fluentDesignFormContainer1.Location = new System.Drawing.Point(62, 39);
            fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            fluentDesignFormContainer1.Size = new System.Drawing.Size(641, 470);
            fluentDesignFormContainer1.TabIndex = 0;
            fluentDesignFormContainer1.ControlAdded += fluentDesignFormContainer1_ControlAdded;
            fluentDesignFormContainer1.ControlRemoved += fluentDesignFormContainer1_ControlRemoved;
            // 
            // MainMenuAccordionControl
            // 
            MainMenuAccordionControl.Dock = System.Windows.Forms.DockStyle.Left;
            MainMenuAccordionControl.ElementPositionOnExpanding = DevExpress.XtraBars.Navigation.ElementPositionOnExpanding.Fixed;
            MainMenuAccordionControl.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { accordionControlElement1 });
            MainMenuAccordionControl.Location = new System.Drawing.Point(0, 39);
            MainMenuAccordionControl.Name = "MainMenuAccordionControl";
            MainMenuAccordionControl.OptionsMinimizing.PopupFormAutoHeightMode = DevExpress.XtraBars.Navigation.AccordionPopupFormAutoHeightMode.None;
            MainMenuAccordionControl.OptionsMinimizing.State = DevExpress.XtraBars.Navigation.AccordionControlState.Minimized;
            MainMenuAccordionControl.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            MainMenuAccordionControl.ShowFilterControl = DevExpress.XtraBars.Navigation.ShowFilterControl.Always;
            MainMenuAccordionControl.Size = new System.Drawing.Size(62, 470);
            MainMenuAccordionControl.TabIndex = 1;
            MainMenuAccordionControl.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlElement1
            // 
            accordionControlElement1.ImageOptions.SvgImage = Properties.Resources.ContactPresence;
            accordionControlElement1.Name = "accordionControlElement1";
            accordionControlElement1.Text = "Element1";
            // 
            // fluentDesignFormControl1
            // 
            fluentDesignFormControl1.FluentDesignForm = this;
            fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { skinPaletteDropDownButtonItem1, skinBarSubItem1, skinBarSubItem2, barStaticItemNavigation });
            fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            fluentDesignFormControl1.Manager = fluentFormDefaultManager1;
            fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            fluentDesignFormControl1.Size = new System.Drawing.Size(703, 39);
            fluentDesignFormControl1.TabIndex = 2;
            fluentDesignFormControl1.TabStop = false;
            fluentDesignFormControl1.TitleItemLinks.Add(skinBarSubItem2);
            fluentDesignFormControl1.TitleItemLinks.Add(barStaticItemNavigation, true);
            // 
            // skinPaletteDropDownButtonItem1
            // 
            skinPaletteDropDownButtonItem1.ActAsDropDown = true;
            skinPaletteDropDownButtonItem1.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            skinPaletteDropDownButtonItem1.Id = 0;
            skinPaletteDropDownButtonItem1.Name = "skinPaletteDropDownButtonItem1";
            // 
            // skinBarSubItem1
            // 
            skinBarSubItem1.Caption = "skinBarSubItem1";
            skinBarSubItem1.Id = 1;
            skinBarSubItem1.Name = "skinBarSubItem1";
            // 
            // skinBarSubItem2
            // 
            skinBarSubItem2.Caption = "Stil";
            skinBarSubItem2.Id = 2;
            skinBarSubItem2.Name = "skinBarSubItem2";
            skinBarSubItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barStaticItemNavigation
            // 
            barStaticItemNavigation.Caption = "???";
            barStaticItemNavigation.Id = 3;
            barStaticItemNavigation.Name = "barStaticItemNavigation";
            // 
            // fluentFormDefaultManager1
            // 
            fluentFormDefaultManager1.Form = this;
            fluentFormDefaultManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { skinPaletteDropDownButtonItem1, skinBarSubItem1, skinBarSubItem2, barStaticItemNavigation });
            fluentFormDefaultManager1.MaxItemId = 4;
            // 
            // accordionControlOpenedModules
            // 
            accordionControlOpenedModules.Dock = System.Windows.Forms.DockStyle.Right;
            accordionControlOpenedModules.ElementPositionOnExpanding = DevExpress.XtraBars.Navigation.ElementPositionOnExpanding.Fixed;
            accordionControlOpenedModules.Location = new System.Drawing.Point(643, 39);
            accordionControlOpenedModules.Name = "accordionControlOpenedModules";
            accordionControlOpenedModules.OptionsHamburgerMenu.DisplayMode = DevExpress.XtraBars.Navigation.AccordionControlDisplayMode.Minimal;
            accordionControlOpenedModules.OptionsMinimizing.State = DevExpress.XtraBars.Navigation.AccordionControlState.Minimized;
            accordionControlOpenedModules.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            accordionControlOpenedModules.ShowFilterControl = DevExpress.XtraBars.Navigation.ShowFilterControl.Always;
            accordionControlOpenedModules.Size = new System.Drawing.Size(60, 470);
            accordionControlOpenedModules.TabIndex = 3;
            accordionControlOpenedModules.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // FrmMainForm
            // 
            Appearance.Options.UseFont = true;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(703, 509);
            ControlContainer = fluentDesignFormContainer1;
            Controls.Add(accordionControlOpenedModules);
            Controls.Add(fluentDesignFormContainer1);
            Controls.Add(MainMenuAccordionControl);
            Controls.Add(fluentDesignFormControl1);
            FluentDesignFormControl = fluentDesignFormControl1;
            IconOptions.Image = (System.Drawing.Image)resources.GetObject("FrmMainForm.IconOptions.Image");
            Name = "FrmMainForm";
            NavigationControl = accordionControlOpenedModules;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "MioSystem";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += FrmMainForm_Load;
            ((System.ComponentModel.ISupportInitialize)MainMenuAccordionControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)fluentDesignFormControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fluentFormDefaultManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)accordionControlOpenedModules).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.Navigation.AccordionControl MainMenuAccordionControl;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.SkinPaletteDropDownButtonItem skinPaletteDropDownButtonItem1;
        private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem1;
        private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem2;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControlOpenedModules;
        private DevExpress.XtraBars.BarStaticItem barStaticItemNavigation;
    }
}


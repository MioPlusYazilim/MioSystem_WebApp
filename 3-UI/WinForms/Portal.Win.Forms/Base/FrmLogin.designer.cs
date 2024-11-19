namespace Portal.Win.Forms
{
    partial class FrmLogin
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            tePassword = new DevExpress.XtraEditors.TextEdit();
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            imCBLanguage = new DevExpress.XtraEditors.ImageComboBoxEdit();
            ImgFlags = new DevExpress.Utils.ImageCollection(components);
            pictureEditSettings = new DevExpress.XtraEditors.PictureEdit();
            chkHatirla = new DevExpress.XtraEditors.CheckEdit();
            versionLabelControl = new DevExpress.XtraEditors.LabelControl();
            pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            btnCancel = new DevExpress.XtraEditors.SimpleButton();
            btnOk = new DevExpress.XtraEditors.SimpleButton();
            teUserName = new DevExpress.XtraEditors.TextEdit();
            layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            itemForCancelButton = new DevExpress.XtraLayout.LayoutControlItem();
            itemForOKButton = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            itemForUserName = new DevExpress.XtraLayout.LayoutControlItem();
            itemForUserPass = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            emptySpaceItem8 = new DevExpress.XtraLayout.EmptySpaceItem();
            itemForSettings = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem9 = new DevExpress.XtraLayout.EmptySpaceItem();
            itemForCopyRight = new DevExpress.XtraLayout.EmptySpaceItem();
            itemForLanguage = new DevExpress.XtraLayout.LayoutControlItem();
            itemForRememberMe = new DevExpress.XtraLayout.LayoutControlItem();
            defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(components);
            dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(components);
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)tePassword.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imCBLanguage.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ImgFlags).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureEditSettings.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chkHatirla.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureEdit2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)teUserName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemForCancelButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemForOKButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemForUserName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemForUserPass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemForSettings).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemForCopyRight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemForLanguage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemForRememberMe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dxValidationProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tePassword
            // 
            tePassword.EnterMoveNextControl = true;
            tePassword.Location = new Point(145, 144);
            tePassword.Margin = new Padding(5, 4, 5, 4);
            tePassword.Name = "tePassword";
            tePassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            tePassword.Properties.UseSystemPasswordChar = true;
            tePassword.Size = new Size(252, 22);
            tePassword.StyleController = layoutControl1;
            tePassword.TabIndex = 1;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Kullanıcı Şifre Belirtmelisiniz";
            dxValidationProvider1.SetValidationRule(tePassword, conditionValidationRule2);
            tePassword.KeyPress += tePassword_KeyPress;
            // 
            // layoutControl1
            // 
            layoutControl1.BackColor = Color.Transparent;
            layoutControl1.Controls.Add(imCBLanguage);
            layoutControl1.Controls.Add(pictureEditSettings);
            layoutControl1.Controls.Add(chkHatirla);
            layoutControl1.Controls.Add(versionLabelControl);
            layoutControl1.Controls.Add(pictureEdit2);
            layoutControl1.Controls.Add(btnCancel);
            layoutControl1.Controls.Add(btnOk);
            layoutControl1.Controls.Add(tePassword);
            layoutControl1.Controls.Add(teUserName);
            layoutControl1.Dock = DockStyle.Fill;
            layoutControl1.Location = new Point(2, 2);
            layoutControl1.Margin = new Padding(5, 4, 5, 4);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new Rectangle(931, 133, 466, 387);
            layoutControl1.Root = layoutControlGroup1;
            layoutControl1.Size = new Size(451, 279);
            layoutControl1.TabIndex = 386;
            layoutControl1.Text = "layoutControl1";
            // 
            // imCBLanguage
            // 
            imCBLanguage.EditValue = "Türkçe";
            imCBLanguage.Location = new Point(145, 170);
            imCBLanguage.Margin = new Padding(5, 4, 5, 4);
            imCBLanguage.Name = "imCBLanguage";
            imCBLanguage.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            imCBLanguage.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] { new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Türkçe", "tr-TR", 0), new DevExpress.XtraEditors.Controls.ImageComboBoxItem("English", "en-EN", 1) });
            imCBLanguage.Properties.SmallImages = ImgFlags;
            imCBLanguage.Size = new Size(121, 22);
            imCBLanguage.StyleController = layoutControl1;
            imCBLanguage.TabIndex = 387;
            imCBLanguage.SelectedIndexChanged += imCBLanguage_SelectedIndexChanged;
            // 
            // ImgFlags
            // 
            ImgFlags.ImageStream = (DevExpress.Utils.ImageCollectionStreamer)resources.GetObject("ImgFlags.ImageStream");
            ImgFlags.Images.SetKeyName(0, "Turkey.png");
            ImgFlags.Images.SetKeyName(1, "gb.png");
            // 
            // pictureEditSettings
            // 
            pictureEditSettings.EditValue = resources.GetObject("pictureEditSettings.EditValue");
            pictureEditSettings.Location = new Point(14, 210);
            pictureEditSettings.Margin = new Padding(5, 4, 5, 4);
            pictureEditSettings.Name = "pictureEditSettings";
            pictureEditSettings.Properties.Appearance.BackColor = Color.Transparent;
            pictureEditSettings.Properties.Appearance.Options.UseBackColor = true;
            pictureEditSettings.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            pictureEditSettings.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            pictureEditSettings.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            pictureEditSettings.Size = new Size(32, 33);
            pictureEditSettings.StyleController = layoutControl1;
            pictureEditSettings.TabIndex = 386;
            pictureEditSettings.Click += pictureEditSettings_Click;
            // 
            // chkHatirla
            // 
            chkHatirla.EnterMoveNextControl = true;
            chkHatirla.Location = new Point(371, 172);
            chkHatirla.Margin = new Padding(5, 4, 5, 4);
            chkHatirla.Name = "chkHatirla";
            chkHatirla.Properties.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Italic);
            chkHatirla.Properties.Appearance.ForeColor = Color.Silver;
            chkHatirla.Properties.Appearance.Options.UseFont = true;
            chkHatirla.Properties.Appearance.Options.UseForeColor = true;
            chkHatirla.Properties.Caption = "";
            chkHatirla.Size = new Size(27, 24);
            chkHatirla.StyleController = layoutControl1;
            chkHatirla.TabIndex = 4;
            chkHatirla.CheckedChanged += chkHatirla_CheckedChanged;
            // 
            // versionLabelControl
            // 
            versionLabelControl.Appearance.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic);
            versionLabelControl.Appearance.Options.UseFont = true;
            versionLabelControl.Appearance.Options.UseTextOptions = true;
            versionLabelControl.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            versionLabelControl.Location = new Point(288, 14);
            versionLabelControl.Margin = new Padding(5, 4, 5, 4);
            versionLabelControl.Name = "versionLabelControl";
            versionLabelControl.Size = new Size(149, 80);
            versionLabelControl.StyleController = layoutControl1;
            versionLabelControl.TabIndex = 384;
            versionLabelControl.Text = "STANDART";
            // 
            // pictureEdit2
            // 
            pictureEdit2.EditValue = resources.GetObject("pictureEdit2.EditValue");
            pictureEdit2.Location = new Point(14, 14);
            pictureEdit2.Margin = new Padding(5, 4, 5, 4);
            pictureEdit2.Name = "pictureEdit2";
            pictureEdit2.Properties.Appearance.BackColor = Color.Transparent;
            pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            pictureEdit2.Size = new Size(254, 80);
            pictureEdit2.StyleController = layoutControl1;
            pictureEdit2.TabIndex = 385;
            // 
            // btnCancel
            // 
            btnCancel.BackgroundImage = (Image)resources.GetObject("btnCancel.BackgroundImage");
            btnCancel.ImageOptions.Image = (Image)resources.GetObject("btnCancel.ImageOptions.Image");
            btnCancel.Location = new Point(314, 210);
            btnCancel.Margin = new Padding(5, 4, 5, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(101, 33);
            btnCancel.StyleController = layoutControl1;
            btnCancel.TabIndex = 6;
            btnCancel.Text = "&Vazgeç";
            btnCancel.Click += simpleButton1_Click;
            btnCancel.Paint += btnOk_Paint;
            // 
            // btnOk
            // 
            btnOk.BackgroundImage = (Image)resources.GetObject("btnOk.BackgroundImage");
            btnOk.ImageOptions.Image = (Image)resources.GetObject("btnOk.ImageOptions.Image");
            btnOk.Location = new Point(209, 210);
            btnOk.Margin = new Padding(5, 4, 5, 4);
            btnOk.Name = "btnOk";
            btnOk.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            btnOk.Size = new Size(101, 33);
            btnOk.StyleController = layoutControl1;
            btnOk.TabIndex = 5;
            btnOk.Text = "&Tamam";
            btnOk.Click += simpleButton2_Click;
            btnOk.Paint += btnOk_Paint;
            // 
            // teUserName
            // 
            teUserName.EnterMoveNextControl = true;
            teUserName.Location = new Point(145, 118);
            teUserName.Margin = new Padding(5, 4, 5, 4);
            teUserName.Name = "teUserName";
            teUserName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            teUserName.Size = new Size(252, 22);
            teUserName.StyleController = layoutControl1;
            teUserName.TabIndex = 0;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Kullanıcı Adı Belirtmelisiniz";
            dxValidationProvider1.SetValidationRule(teUserName, conditionValidationRule1);
            // 
            // layoutControlGroup1
            // 
            layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            layoutControlGroup1.GroupBordersVisible = false;
            layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { itemForCancelButton, itemForOKButton, layoutControlItem4, layoutControlItem5, emptySpaceItem1, emptySpaceItem3, emptySpaceItem4, emptySpaceItem2, itemForUserName, itemForUserPass, emptySpaceItem5, emptySpaceItem8, itemForSettings, emptySpaceItem9, itemForCopyRight, itemForLanguage, itemForRememberMe });
            layoutControlGroup1.Name = "Root";
            layoutControlGroup1.Size = new Size(451, 279);
            layoutControlGroup1.TextVisible = false;
            // 
            // itemForCancelButton
            // 
            itemForCancelButton.Control = btnCancel;
            itemForCancelButton.Location = new Point(300, 196);
            itemForCancelButton.MaxSize = new Size(105, 37);
            itemForCancelButton.MinSize = new Size(105, 37);
            itemForCancelButton.Name = "itemForCancelButton";
            itemForCancelButton.Size = new Size(105, 37);
            itemForCancelButton.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            itemForCancelButton.TextSize = new Size(0, 0);
            itemForCancelButton.TextVisible = false;
            // 
            // itemForOKButton
            // 
            itemForOKButton.Control = btnOk;
            itemForOKButton.Location = new Point(195, 196);
            itemForOKButton.MaxSize = new Size(105, 37);
            itemForOKButton.MinSize = new Size(105, 37);
            itemForOKButton.Name = "itemForOKButton";
            itemForOKButton.Size = new Size(105, 37);
            itemForOKButton.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            itemForOKButton.TextSize = new Size(0, 0);
            itemForOKButton.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.Control = pictureEdit2;
            layoutControlItem4.Location = new Point(0, 0);
            layoutControlItem4.MaxSize = new Size(258, 84);
            layoutControlItem4.MinSize = new Size(258, 84);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Size = new Size(258, 84);
            layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutControlItem4.TextSize = new Size(0, 0);
            layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            layoutControlItem5.Control = versionLabelControl;
            layoutControlItem5.Location = new Point(274, 0);
            layoutControlItem5.MinSize = new Size(79, 23);
            layoutControlItem5.Name = "layoutControlItem5";
            layoutControlItem5.Size = new Size(153, 84);
            layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutControlItem5.TextSize = new Size(0, 0);
            layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.AllowHotTrack = false;
            emptySpaceItem1.Location = new Point(258, 0);
            emptySpaceItem1.MaxSize = new Size(16, 84);
            emptySpaceItem1.MinSize = new Size(16, 84);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new Size(16, 84);
            emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            emptySpaceItem1.TextSize = new Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            emptySpaceItem3.AllowHotTrack = false;
            emptySpaceItem3.Location = new Point(387, 84);
            emptySpaceItem3.MaxSize = new Size(40, 0);
            emptySpaceItem3.MinSize = new Size(40, 12);
            emptySpaceItem3.Name = "emptySpaceItem3";
            emptySpaceItem3.Size = new Size(40, 100);
            emptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            emptySpaceItem3.TextSize = new Size(0, 0);
            // 
            // emptySpaceItem4
            // 
            emptySpaceItem4.AllowHotTrack = false;
            emptySpaceItem4.Location = new Point(0, 84);
            emptySpaceItem4.MaxSize = new Size(40, 0);
            emptySpaceItem4.MinSize = new Size(40, 12);
            emptySpaceItem4.Name = "emptySpaceItem4";
            emptySpaceItem4.Size = new Size(40, 100);
            emptySpaceItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            emptySpaceItem4.TextSize = new Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            emptySpaceItem2.AllowHotTrack = false;
            emptySpaceItem2.Location = new Point(40, 84);
            emptySpaceItem2.MaxSize = new Size(0, 20);
            emptySpaceItem2.MinSize = new Size(6, 20);
            emptySpaceItem2.Name = "emptySpaceItem2";
            emptySpaceItem2.Size = new Size(347, 20);
            emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            emptySpaceItem2.TextSize = new Size(0, 0);
            // 
            // itemForUserName
            // 
            itemForUserName.Control = teUserName;
            itemForUserName.Location = new Point(40, 104);
            itemForUserName.Name = "itemForUserName";
            itemForUserName.Size = new Size(347, 26);
            itemForUserName.Text = "Kullanıcı Adı";
            itemForUserName.TextSize = new Size(77, 16);
            // 
            // itemForUserPass
            // 
            itemForUserPass.Control = tePassword;
            itemForUserPass.Location = new Point(40, 130);
            itemForUserPass.Name = "itemForUserPass";
            itemForUserPass.Size = new Size(347, 26);
            itemForUserPass.Text = "Kullanıcı Şifre";
            itemForUserPass.TextSize = new Size(77, 16);
            // 
            // emptySpaceItem5
            // 
            emptySpaceItem5.AllowHotTrack = false;
            emptySpaceItem5.Location = new Point(405, 196);
            emptySpaceItem5.MaxSize = new Size(22, 0);
            emptySpaceItem5.MinSize = new Size(22, 12);
            emptySpaceItem5.Name = "emptySpaceItem5";
            emptySpaceItem5.Size = new Size(22, 37);
            emptySpaceItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            emptySpaceItem5.TextSize = new Size(0, 0);
            // 
            // emptySpaceItem8
            // 
            emptySpaceItem8.AllowHotTrack = false;
            emptySpaceItem8.Location = new Point(0, 184);
            emptySpaceItem8.MaxSize = new Size(0, 12);
            emptySpaceItem8.MinSize = new Size(12, 12);
            emptySpaceItem8.Name = "emptySpaceItem8";
            emptySpaceItem8.Size = new Size(427, 12);
            emptySpaceItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            emptySpaceItem8.TextSize = new Size(0, 0);
            // 
            // itemForSettings
            // 
            itemForSettings.Control = pictureEditSettings;
            itemForSettings.Location = new Point(0, 196);
            itemForSettings.Name = "itemForSettings";
            itemForSettings.Size = new Size(36, 37);
            itemForSettings.TextSize = new Size(0, 0);
            itemForSettings.TextVisible = false;
            // 
            // emptySpaceItem9
            // 
            emptySpaceItem9.AllowHotTrack = false;
            emptySpaceItem9.Location = new Point(36, 196);
            emptySpaceItem9.Name = "emptySpaceItem9";
            emptySpaceItem9.Size = new Size(159, 37);
            emptySpaceItem9.TextSize = new Size(0, 0);
            // 
            // itemForCopyRight
            // 
            itemForCopyRight.AllowHotTrack = false;
            itemForCopyRight.AppearanceItemCaption.Options.UseTextOptions = true;
            itemForCopyRight.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            itemForCopyRight.Location = new Point(0, 233);
            itemForCopyRight.Name = "itemForCopyRight";
            itemForCopyRight.Size = new Size(427, 22);
            itemForCopyRight.Text = "Copyright © 2007-2018";
            itemForCopyRight.TextSize = new Size(77, 0);
            itemForCopyRight.TextVisible = true;
            // 
            // itemForLanguage
            // 
            itemForLanguage.Control = imCBLanguage;
            itemForLanguage.Location = new Point(40, 156);
            itemForLanguage.Name = "itemForLanguage";
            itemForLanguage.Size = new Size(216, 28);
            itemForLanguage.Text = "Çalışma Dili";
            itemForLanguage.TextSize = new Size(77, 16);
            // 
            // itemForRememberMe
            // 
            itemForRememberMe.Control = chkHatirla;
            itemForRememberMe.Location = new Point(256, 156);
            itemForRememberMe.MaxSize = new Size(131, 28);
            itemForRememberMe.MinSize = new Size(131, 28);
            itemForRememberMe.Name = "itemForRememberMe";
            itemForRememberMe.Padding = new DevExpress.XtraLayout.Utils.Padding(12, 1, 4, 4);
            itemForRememberMe.Size = new Size(131, 28);
            itemForRememberMe.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            itemForRememberMe.Text = "Beni Hatırla";
            itemForRememberMe.TextSize = new Size(77, 16);
            // 
            // dxValidationProvider1
            // 
            dxValidationProvider1.ValidationFailed += dxValidationProvider1_ValidationFailed;
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(layoutControl1);
            panelControl1.Dock = DockStyle.Fill;
            panelControl1.Location = new Point(0, 0);
            panelControl1.Margin = new Padding(5, 4, 5, 4);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(455, 283);
            panelControl1.TabIndex = 387;
            // 
            // FrmLogin
            // 
            Appearance.BackColor = Color.White;
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 283);
            Controls.Add(panelControl1);
            FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            IconOptions.Icon = (Icon)resources.GetObject("FrmLogin.IconOptions.Icon");
            KeyPreview = true;
            Margin = new Padding(5, 4, 5, 4);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MioSystem";
            KeyPress += Splash_KeyPress;
            ((System.ComponentModel.ISupportInitialize)tePassword.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imCBLanguage.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)ImgFlags).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureEditSettings.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)chkHatirla.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureEdit2.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)teUserName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemForCancelButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemForOKButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemForUserName).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemForUserPass).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem5).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem8).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemForSettings).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem9).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemForCopyRight).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemForLanguage).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemForRememberMe).EndInit();
            ((System.ComponentModel.ISupportInitialize)dxValidationProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DevExpress.XtraEditors.TextEdit tePassword;
        private DevExpress.XtraEditors.TextEdit teUserName;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraEditors.LabelControl versionLabelControl;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.CheckEdit chkHatirla;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem itemForCancelButton;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem itemForOKButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.LayoutControlItem itemForUserName;
        private DevExpress.XtraLayout.LayoutControlItem itemForUserPass;
        private DevExpress.XtraLayout.LayoutControlItem itemForRememberMe;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraLayout.EmptySpaceItem itemForCopyRight;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem8;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEditSettings;
        private DevExpress.XtraLayout.LayoutControlItem itemForSettings;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem9;
        private DevExpress.XtraEditors.ImageComboBoxEdit imCBLanguage;
        private DevExpress.XtraLayout.LayoutControlItem itemForLanguage;
        private DevExpress.Utils.ImageCollection ImgFlags;
    }
}
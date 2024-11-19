using DevExpress.Data.Linq;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.Utils.Svg;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Popup;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Editors;
using DevExpress.XtraGrid.Views.Grid;
using MioSystem.Utils;
using Portal.Helpers;
using System.Data;
using System.Reflection;

namespace MioSystem.DxUtils
{
    public class DxFunctions : IDisposable
    {
        DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(Application.OpenForms[0], typeof(WaitForm1), true, true);
        public void ShowWaitForm(string Message)
        {
            try
            {
                if (splashScreenManager.IsSplashFormVisible == false)
                    splashScreenManager.ShowWaitForm();
                splashScreenManager.SetWaitFormCaption("Lütfen Bekleyin");
                splashScreenManager.SetWaitFormDescription(Message);
                Application.DoEvents();
            }
            catch (Exception)
            {
            }
        }
        public void ShowWaitForm(int MessageID)
        {
            try
            {
                if (splashScreenManager.IsSplashFormVisible == false)
                    splashScreenManager.ShowWaitForm();
                splashScreenManager.SetWaitFormCaption("Lütfen Bekleyin");
                splashScreenManager.SetWaitFormDescription("mesaj bilgisi");
                Application.DoEvents();
            }
            catch (Exception)
            {
            }
        }

        public void CloseWaitForm()
        {
            try
            {
                splashScreenManager.CloseWaitForm();
            }
            catch (Exception)
            {
            }
        }
        private void DxFunctions_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F10:
                    if (((ButtonEdit)sender).Properties.Buttons.Count > 0)
                        ((ButtonEdit)sender).PerformClick(((ButtonEdit)sender).Properties.Buttons[0]);
                    break;
                case Keys.F11:
                    if (((ButtonEdit)sender).Properties.Buttons.Count > 1)
                        ((ButtonEdit)sender).PerformClick(((ButtonEdit)sender).Properties.Buttons[1]);
                    break;
                case Keys.F12:
                    if (((ButtonEdit)sender).Properties.Buttons.Count > 2)
                        ((ButtonEdit)sender).PerformClick(((ButtonEdit)sender).Properties.Buttons[2]);
                    break;
            }
        }

        public void EnterMoveNextForAll(System.Windows.Forms.Control MyContainer, bool SetEditorDisableColor)
        {
            try
            {
                var commonSkin = CommonSkins.GetSkin(UserLookAndFeel.Default);
                SvgPalette svgPalette = commonSkin.SvgPalettes[Skin.DefaultSkinPaletteName] as SvgPalette;
                Color MyColor = svgPalette == null ? Color.FromArgb(255,205,230,247) : svgPalette["Accent Paint Light"].Value;

                foreach (Control ctrl in MyContainer.Controls)
                {
                    if (ctrl.GetType() == typeof(DevExpress.XtraEditors.TextEdit))
                    {
                        ((DevExpress.XtraEditors.TextEdit)ctrl).EnterMoveNextControl = true;
                        if (SetEditorDisableColor)
                        {
                            ((DevExpress.XtraEditors.TextEdit)ctrl).Properties.AppearanceDisabled.ForeColor = ((DevExpress.XtraEditors.TextEdit)ctrl).Properties.Appearance.ForeColor;
                            ((DevExpress.XtraEditors.TextEdit)ctrl).Properties.AppearanceDisabled.BackColor = ((DevExpress.XtraEditors.TextEdit)ctrl).Properties.Appearance.BackColor;
                            ((DevExpress.XtraEditors.TextEdit)ctrl).Properties.AppearanceDisabled.BorderColor = ((DevExpress.XtraEditors.TextEdit)ctrl).Properties.Appearance.BorderColor;
                            ((DevExpress.XtraEditors.TextEdit)ctrl).Properties.AppearanceReadOnly.ForeColor = ((DevExpress.XtraEditors.TextEdit)ctrl).Properties.Appearance.ForeColor;
                            ((DevExpress.XtraEditors.TextEdit)ctrl).Properties.AppearanceReadOnly.BackColor = ((DevExpress.XtraEditors.TextEdit)ctrl).Properties.Appearance.BackColor;
                            ((DevExpress.XtraEditors.TextEdit)ctrl).Properties.AppearanceReadOnly.BorderColor = ((DevExpress.XtraEditors.TextEdit)ctrl).Properties.Appearance.BorderColor;
                        }
                            ((DevExpress.XtraEditors.TextEdit)ctrl).Properties.AppearanceFocused.BackColor = MyColor;
                    }
                    else if (ctrl.GetType() == typeof(DevExpress.XtraEditors.SearchLookUpEdit))
                    {
                        ((DevExpress.XtraEditors.SearchLookUpEdit)ctrl).EnterMoveNextControl = true;
                        if (SetEditorDisableColor)
                        {
                            ((DevExpress.XtraEditors.SearchLookUpEdit)ctrl).Properties.AppearanceDisabled.ForeColor = ((DevExpress.XtraEditors.SearchLookUpEdit)ctrl).Properties.Appearance.ForeColor;
                            ((DevExpress.XtraEditors.SearchLookUpEdit)ctrl).Properties.AppearanceDisabled.BackColor = ((DevExpress.XtraEditors.SearchLookUpEdit)ctrl).Properties.Appearance.BackColor;
                            ((DevExpress.XtraEditors.SearchLookUpEdit)ctrl).Properties.AppearanceDisabled.BorderColor = ((DevExpress.XtraEditors.SearchLookUpEdit)ctrl).Properties.Appearance.BorderColor;

                            ((DevExpress.XtraEditors.SearchLookUpEdit)ctrl).Properties.AppearanceReadOnly.ForeColor = ((DevExpress.XtraEditors.SearchLookUpEdit)ctrl).Properties.Appearance.ForeColor;
                            ((DevExpress.XtraEditors.SearchLookUpEdit)ctrl).Properties.AppearanceReadOnly.BackColor = ((DevExpress.XtraEditors.SearchLookUpEdit)ctrl).Properties.Appearance.BackColor;
                            ((DevExpress.XtraEditors.SearchLookUpEdit)ctrl).Properties.AppearanceReadOnly.BorderColor = ((DevExpress.XtraEditors.SearchLookUpEdit)ctrl).Properties.Appearance.BorderColor;
                        }
                            ((DevExpress.XtraEditors.SearchLookUpEdit)ctrl).Properties.AppearanceFocused.BackColor = MyColor;
                    }
                    else if (ctrl.GetType() == typeof(DevExpress.XtraEditors.SpinEdit))
                    {
                        ((DevExpress.XtraEditors.SpinEdit)ctrl).EnterMoveNextControl = true;
                        if (SetEditorDisableColor)
                        {
                            ((DevExpress.XtraEditors.SpinEdit)ctrl).Properties.AppearanceDisabled.ForeColor = ((DevExpress.XtraEditors.SpinEdit)ctrl).Properties.Appearance.ForeColor;
                            ((DevExpress.XtraEditors.SpinEdit)ctrl).Properties.AppearanceDisabled.BackColor = ((DevExpress.XtraEditors.SpinEdit)ctrl).Properties.Appearance.BackColor;
                            ((DevExpress.XtraEditors.SpinEdit)ctrl).Properties.AppearanceDisabled.BorderColor = ((DevExpress.XtraEditors.SpinEdit)ctrl).Properties.Appearance.BorderColor;
                            ((DevExpress.XtraEditors.SpinEdit)ctrl).Properties.AppearanceReadOnly.ForeColor = ((DevExpress.XtraEditors.SpinEdit)ctrl).Properties.Appearance.ForeColor;
                            ((DevExpress.XtraEditors.SpinEdit)ctrl).Properties.AppearanceReadOnly.BackColor = ((DevExpress.XtraEditors.SpinEdit)ctrl).Properties.Appearance.BackColor;
                            ((DevExpress.XtraEditors.SpinEdit)ctrl).Properties.AppearanceReadOnly.BorderColor = ((DevExpress.XtraEditors.SpinEdit)ctrl).Properties.Appearance.BorderColor;
                        }
                            ((DevExpress.XtraEditors.SpinEdit)ctrl).Properties.AppearanceFocused.BackColor = MyColor;
                    }
                    else if (ctrl.GetType() == typeof(DevExpress.XtraEditors.CheckEdit))
                    {
                        ((DevExpress.XtraEditors.CheckEdit)ctrl).EnterMoveNextControl = true;
                        if (SetEditorDisableColor)
                        {
                            ((DevExpress.XtraEditors.CheckEdit)ctrl).Properties.AppearanceDisabled.ForeColor = ((DevExpress.XtraEditors.CheckEdit)ctrl).Properties.Appearance.ForeColor;
                            ((DevExpress.XtraEditors.CheckEdit)ctrl).Properties.AppearanceDisabled.BackColor = ((DevExpress.XtraEditors.CheckEdit)ctrl).Properties.Appearance.BackColor;
                            ((DevExpress.XtraEditors.CheckEdit)ctrl).Properties.AppearanceDisabled.BorderColor = ((DevExpress.XtraEditors.CheckEdit)ctrl).Properties.Appearance.BorderColor;
                            ((DevExpress.XtraEditors.CheckEdit)ctrl).Properties.AppearanceReadOnly.ForeColor = ((DevExpress.XtraEditors.CheckEdit)ctrl).Properties.Appearance.ForeColor;
                            ((DevExpress.XtraEditors.CheckEdit)ctrl).Properties.AppearanceReadOnly.BackColor = ((DevExpress.XtraEditors.CheckEdit)ctrl).Properties.Appearance.BackColor;
                            ((DevExpress.XtraEditors.CheckEdit)ctrl).Properties.AppearanceReadOnly.BorderColor = ((DevExpress.XtraEditors.CheckEdit)ctrl).Properties.Appearance.BorderColor;
                        }
                            ((DevExpress.XtraEditors.CheckEdit)ctrl).Properties.AppearanceFocused.BackColor = MyColor;

                    }
                    else if (ctrl.GetType() == typeof(DevExpress.XtraEditors.ComboBoxEdit))
                    {
                        ((DevExpress.XtraEditors.ComboBoxEdit)ctrl).EnterMoveNextControl = true;
                        if (SetEditorDisableColor)
                        {
                            ((DevExpress.XtraEditors.ComboBoxEdit)ctrl).Properties.AppearanceDisabled.ForeColor = ((DevExpress.XtraEditors.ComboBoxEdit)ctrl).Properties.Appearance.ForeColor;
                            ((DevExpress.XtraEditors.ComboBoxEdit)ctrl).Properties.AppearanceDisabled.BackColor = ((DevExpress.XtraEditors.ComboBoxEdit)ctrl).Properties.Appearance.BackColor;
                            ((DevExpress.XtraEditors.ComboBoxEdit)ctrl).Properties.AppearanceDisabled.BorderColor = ((DevExpress.XtraEditors.ComboBoxEdit)ctrl).Properties.Appearance.BorderColor;
                            ((DevExpress.XtraEditors.ComboBoxEdit)ctrl).Properties.AppearanceReadOnly.ForeColor = ((DevExpress.XtraEditors.ComboBoxEdit)ctrl).Properties.Appearance.ForeColor;
                            ((DevExpress.XtraEditors.ComboBoxEdit)ctrl).Properties.AppearanceReadOnly.BackColor = ((DevExpress.XtraEditors.ComboBoxEdit)ctrl).Properties.Appearance.BackColor;
                            ((DevExpress.XtraEditors.ComboBoxEdit)ctrl).Properties.AppearanceReadOnly.BorderColor = ((DevExpress.XtraEditors.ComboBoxEdit)ctrl).Properties.Appearance.BorderColor;
                        }
                            ((DevExpress.XtraEditors.ComboBoxEdit)ctrl).Properties.AppearanceFocused.BackColor = MyColor;
                    }
                    else if (ctrl.GetType() == typeof(DevExpress.XtraEditors.ImageComboBoxEdit))
                    {
                        ((DevExpress.XtraEditors.ImageComboBoxEdit)ctrl).EnterMoveNextControl = true;
                        if (SetEditorDisableColor)
                        {
                            ((DevExpress.XtraEditors.ImageComboBoxEdit)ctrl).Properties.AppearanceDisabled.ForeColor = ((DevExpress.XtraEditors.ImageComboBoxEdit)ctrl).Properties.Appearance.ForeColor;
                            ((DevExpress.XtraEditors.ImageComboBoxEdit)ctrl).Properties.AppearanceDisabled.BackColor = ((DevExpress.XtraEditors.ImageComboBoxEdit)ctrl).Properties.Appearance.BackColor;
                            ((DevExpress.XtraEditors.ImageComboBoxEdit)ctrl).Properties.AppearanceDisabled.BorderColor = ((DevExpress.XtraEditors.ImageComboBoxEdit)ctrl).Properties.Appearance.BorderColor;
                            ((DevExpress.XtraEditors.ImageComboBoxEdit)ctrl).Properties.AppearanceReadOnly.ForeColor = ((DevExpress.XtraEditors.ImageComboBoxEdit)ctrl).Properties.Appearance.ForeColor;
                            ((DevExpress.XtraEditors.ImageComboBoxEdit)ctrl).Properties.AppearanceReadOnly.BackColor = ((DevExpress.XtraEditors.ImageComboBoxEdit)ctrl).Properties.Appearance.BackColor;
                            ((DevExpress.XtraEditors.ImageComboBoxEdit)ctrl).Properties.AppearanceReadOnly.BorderColor = ((DevExpress.XtraEditors.ImageComboBoxEdit)ctrl).Properties.Appearance.BorderColor;
                        }
                            ((DevExpress.XtraEditors.ImageComboBoxEdit)ctrl).Properties.AppearanceFocused.BackColor = MyColor;
                    }
                    else if (ctrl.GetType() == typeof(DevExpress.XtraEditors.LookUpEdit))
                    {
                        ((DevExpress.XtraEditors.LookUpEdit)ctrl).EnterMoveNextControl = true;
                        if (SetEditorDisableColor)
                        {
                            ((DevExpress.XtraEditors.LookUpEdit)ctrl).Properties.AppearanceDisabled.ForeColor = ((DevExpress.XtraEditors.LookUpEdit)ctrl).Properties.Appearance.ForeColor;
                            ((DevExpress.XtraEditors.LookUpEdit)ctrl).Properties.AppearanceDisabled.BackColor = ((DevExpress.XtraEditors.LookUpEdit)ctrl).Properties.Appearance.BackColor;
                            ((DevExpress.XtraEditors.LookUpEdit)ctrl).Properties.AppearanceDisabled.BorderColor = ((DevExpress.XtraEditors.LookUpEdit)ctrl).Properties.Appearance.BorderColor;
                            ((DevExpress.XtraEditors.LookUpEdit)ctrl).Properties.AppearanceReadOnly.ForeColor = ((DevExpress.XtraEditors.LookUpEdit)ctrl).Properties.Appearance.ForeColor;
                            ((DevExpress.XtraEditors.LookUpEdit)ctrl).Properties.AppearanceReadOnly.BackColor = ((DevExpress.XtraEditors.LookUpEdit)ctrl).Properties.Appearance.BackColor;
                            ((DevExpress.XtraEditors.LookUpEdit)ctrl).Properties.AppearanceReadOnly.BorderColor = ((DevExpress.XtraEditors.LookUpEdit)ctrl).Properties.Appearance.BorderColor;
                        }
                            ((DevExpress.XtraEditors.LookUpEdit)ctrl).Properties.AppearanceFocused.BackColor = MyColor;
                    }
                    else if (ctrl.GetType() == typeof(DevExpress.XtraEditors.MemoEdit))
                    {
                        ((DevExpress.XtraEditors.MemoEdit)ctrl).EnterMoveNextControl = true;
                        if (SetEditorDisableColor)
                        {
                            ((DevExpress.XtraEditors.MemoEdit)ctrl).Properties.AppearanceDisabled.ForeColor = ((DevExpress.XtraEditors.MemoEdit)ctrl).Properties.Appearance.ForeColor;
                            ((DevExpress.XtraEditors.MemoEdit)ctrl).Properties.AppearanceDisabled.BackColor = ((DevExpress.XtraEditors.MemoEdit)ctrl).Properties.Appearance.BackColor;
                            ((DevExpress.XtraEditors.MemoEdit)ctrl).Properties.AppearanceDisabled.BorderColor = ((DevExpress.XtraEditors.MemoEdit)ctrl).Properties.Appearance.BorderColor;
                            ((DevExpress.XtraEditors.MemoEdit)ctrl).Properties.AppearanceReadOnly.ForeColor = ((DevExpress.XtraEditors.MemoEdit)ctrl).Properties.Appearance.ForeColor;
                            ((DevExpress.XtraEditors.MemoEdit)ctrl).Properties.AppearanceReadOnly.BackColor = ((DevExpress.XtraEditors.MemoEdit)ctrl).Properties.Appearance.BackColor;
                            ((DevExpress.XtraEditors.MemoEdit)ctrl).Properties.AppearanceReadOnly.BorderColor = ((DevExpress.XtraEditors.MemoEdit)ctrl).Properties.Appearance.BorderColor;
                        }
                            ((DevExpress.XtraEditors.MemoEdit)ctrl).Properties.AppearanceFocused.BackColor = MyColor;
                    }
                    else if (ctrl.GetType() == typeof(DevExpress.XtraEditors.ButtonEdit))
                    {
                        ((DevExpress.XtraEditors.ButtonEdit)ctrl).EnterMoveNextControl = true;
                        if (SetEditorDisableColor)
                        {
                            ((DevExpress.XtraEditors.ButtonEdit)ctrl).Properties.AppearanceDisabled.ForeColor = ((DevExpress.XtraEditors.ButtonEdit)ctrl).Properties.Appearance.ForeColor;
                            ((DevExpress.XtraEditors.ButtonEdit)ctrl).Properties.AppearanceDisabled.BackColor = ((DevExpress.XtraEditors.ButtonEdit)ctrl).Properties.Appearance.BackColor;
                            ((DevExpress.XtraEditors.ButtonEdit)ctrl).Properties.AppearanceDisabled.BorderColor = ((DevExpress.XtraEditors.ButtonEdit)ctrl).Properties.Appearance.BorderColor;
                            ((DevExpress.XtraEditors.ButtonEdit)ctrl).Properties.AppearanceReadOnly.ForeColor = ((DevExpress.XtraEditors.ButtonEdit)ctrl).Properties.Appearance.ForeColor;
                            ((DevExpress.XtraEditors.ButtonEdit)ctrl).Properties.AppearanceReadOnly.BackColor = ((DevExpress.XtraEditors.ButtonEdit)ctrl).Properties.Appearance.BackColor;
                            ((DevExpress.XtraEditors.ButtonEdit)ctrl).Properties.AppearanceReadOnly.BorderColor = ((DevExpress.XtraEditors.ButtonEdit)ctrl).Properties.Appearance.BorderColor;
                        }
                            ((DevExpress.XtraEditors.ButtonEdit)ctrl).Properties.AppearanceFocused.BackColor = MyColor;
                    }
                    else if (ctrl.GetType() == typeof(DevExpress.XtraEditors.DateEdit))
                    {
                        ((DevExpress.XtraEditors.DateEdit)ctrl).Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
                        ((DevExpress.XtraEditors.DateEdit)ctrl).Properties.Mask.UseMaskAsDisplayFormat = true;
                        ((DevExpress.XtraEditors.DateEdit)ctrl).EnterMoveNextControl = true;
                        if (SetEditorDisableColor)
                        {
                            ((DevExpress.XtraEditors.DateEdit)ctrl).Properties.AppearanceDisabled.ForeColor = ((DevExpress.XtraEditors.DateEdit)ctrl).Properties.Appearance.ForeColor;
                            ((DevExpress.XtraEditors.DateEdit)ctrl).Properties.AppearanceDisabled.BackColor = ((DevExpress.XtraEditors.DateEdit)ctrl).Properties.Appearance.BackColor;
                            ((DevExpress.XtraEditors.DateEdit)ctrl).Properties.AppearanceDisabled.BorderColor = ((DevExpress.XtraEditors.DateEdit)ctrl).Properties.Appearance.BorderColor;
                            ((DevExpress.XtraEditors.DateEdit)ctrl).Properties.AppearanceReadOnly.ForeColor = ((DevExpress.XtraEditors.DateEdit)ctrl).Properties.Appearance.ForeColor;
                            ((DevExpress.XtraEditors.DateEdit)ctrl).Properties.AppearanceReadOnly.BackColor = ((DevExpress.XtraEditors.DateEdit)ctrl).Properties.Appearance.BackColor;
                            ((DevExpress.XtraEditors.DateEdit)ctrl).Properties.AppearanceReadOnly.BorderColor = ((DevExpress.XtraEditors.DateEdit)ctrl).Properties.Appearance.BorderColor;
                        }
                            ((DevExpress.XtraEditors.DateEdit)ctrl).Properties.AppearanceFocused.BackColor = MyColor;
                    }
                    else if (ctrl.GetType() == typeof(DevExpress.XtraEditors.TimeEdit))
                    {
                        ((DevExpress.XtraEditors.TimeEdit)ctrl).Properties.Mask.EditMask = "t";
                        ((DevExpress.XtraEditors.TimeEdit)ctrl).Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
                        ((DevExpress.XtraEditors.TimeEdit)ctrl).Properties.Mask.UseMaskAsDisplayFormat = true;
                        ((DevExpress.XtraEditors.TimeEdit)ctrl).EnterMoveNextControl = true;
                        if (SetEditorDisableColor)
                        {
                            ((DevExpress.XtraEditors.TimeEdit)ctrl).Properties.AppearanceDisabled.ForeColor = ((DevExpress.XtraEditors.TimeEdit)ctrl).Properties.Appearance.ForeColor;
                            ((DevExpress.XtraEditors.TimeEdit)ctrl).Properties.AppearanceDisabled.BackColor = ((DevExpress.XtraEditors.TimeEdit)ctrl).Properties.Appearance.BackColor;
                            ((DevExpress.XtraEditors.TimeEdit)ctrl).Properties.AppearanceDisabled.BorderColor = ((DevExpress.XtraEditors.TimeEdit)ctrl).Properties.Appearance.BorderColor;
                            ((DevExpress.XtraEditors.TimeEdit)ctrl).Properties.AppearanceReadOnly.ForeColor = ((DevExpress.XtraEditors.TimeEdit)ctrl).Properties.Appearance.ForeColor;
                            ((DevExpress.XtraEditors.TimeEdit)ctrl).Properties.AppearanceReadOnly.BackColor = ((DevExpress.XtraEditors.TimeEdit)ctrl).Properties.Appearance.BackColor;
                            ((DevExpress.XtraEditors.TimeEdit)ctrl).Properties.AppearanceReadOnly.BorderColor = ((DevExpress.XtraEditors.TimeEdit)ctrl).Properties.Appearance.BorderColor;
                        }
                            ((DevExpress.XtraEditors.TimeEdit)ctrl).Properties.AppearanceFocused.BackColor = MyColor;
                    }
                    else if (ctrl.GetType() == typeof(DevExpress.XtraEditors.TimeSpanEdit))
                    {
                        ((DevExpress.XtraEditors.TimeSpanEdit)ctrl).Properties.Mask.EditMask = "t";
                        ((DevExpress.XtraEditors.TimeSpanEdit)ctrl).Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
                        ((DevExpress.XtraEditors.TimeSpanEdit)ctrl).Properties.Mask.UseMaskAsDisplayFormat = true;
                        ((DevExpress.XtraEditors.TimeSpanEdit)ctrl).EnterMoveNextControl = true;
                        if (SetEditorDisableColor)
                        {
                            ((DevExpress.XtraEditors.TimeSpanEdit)ctrl).Properties.AppearanceDisabled.ForeColor = ((DevExpress.XtraEditors.TimeSpanEdit)ctrl).Properties.Appearance.ForeColor;
                            ((DevExpress.XtraEditors.TimeSpanEdit)ctrl).Properties.AppearanceDisabled.BackColor = ((DevExpress.XtraEditors.TimeSpanEdit)ctrl).Properties.Appearance.BackColor;
                            ((DevExpress.XtraEditors.TimeSpanEdit)ctrl).Properties.AppearanceDisabled.BorderColor = ((DevExpress.XtraEditors.TimeSpanEdit)ctrl).Properties.Appearance.BorderColor;
                            ((DevExpress.XtraEditors.TimeSpanEdit)ctrl).Properties.AppearanceReadOnly.ForeColor = ((DevExpress.XtraEditors.TimeSpanEdit)ctrl).Properties.Appearance.ForeColor;
                            ((DevExpress.XtraEditors.TimeSpanEdit)ctrl).Properties.AppearanceReadOnly.BackColor = ((DevExpress.XtraEditors.TimeSpanEdit)ctrl).Properties.Appearance.BackColor;
                            ((DevExpress.XtraEditors.TimeSpanEdit)ctrl).Properties.AppearanceReadOnly.BorderColor = ((DevExpress.XtraEditors.TimeSpanEdit)ctrl).Properties.Appearance.BorderColor;
                        }
                            ((DevExpress.XtraEditors.TimeSpanEdit)ctrl).Properties.AppearanceFocused.BackColor = MyColor;
                    }
                    else if (ctrl.GetType() == typeof(DevExpress.XtraEditors.PictureEdit))
                    {
                        ((DevExpress.XtraEditors.PictureEdit)ctrl).EnterMoveNextControl = true;
                        ((DevExpress.XtraEditors.PictureEdit)ctrl).Properties.AppearanceFocused.BackColor = MyColor;
                    }
                    else if (ctrl.GetType() == typeof(DevExpress.XtraEditors.CheckedComboBoxEdit))
                    {
                        ((DevExpress.XtraEditors.CheckedComboBoxEdit)ctrl).EnterMoveNextControl = true;
                        if (SetEditorDisableColor)
                        {
                            ((DevExpress.XtraEditors.CheckedComboBoxEdit)ctrl).Properties.AppearanceDisabled.ForeColor = ((DevExpress.XtraEditors.CheckedComboBoxEdit)ctrl).Properties.Appearance.ForeColor;
                            ((DevExpress.XtraEditors.CheckedComboBoxEdit)ctrl).Properties.AppearanceDisabled.BackColor = ((DevExpress.XtraEditors.CheckedComboBoxEdit)ctrl).Properties.Appearance.BackColor;
                            ((DevExpress.XtraEditors.CheckedComboBoxEdit)ctrl).Properties.AppearanceDisabled.BorderColor = ((DevExpress.XtraEditors.CheckedComboBoxEdit)ctrl).Properties.Appearance.BorderColor;
                            ((DevExpress.XtraEditors.CheckedComboBoxEdit)ctrl).Properties.AppearanceReadOnly.ForeColor = ((DevExpress.XtraEditors.CheckedComboBoxEdit)ctrl).Properties.Appearance.ForeColor;
                            ((DevExpress.XtraEditors.CheckedComboBoxEdit)ctrl).Properties.AppearanceReadOnly.BackColor = ((DevExpress.XtraEditors.CheckedComboBoxEdit)ctrl).Properties.Appearance.BackColor;
                            ((DevExpress.XtraEditors.CheckedComboBoxEdit)ctrl).Properties.AppearanceReadOnly.BorderColor = ((DevExpress.XtraEditors.CheckedComboBoxEdit)ctrl).Properties.Appearance.BorderColor;
                        }
                            ((DevExpress.XtraEditors.CheckedComboBoxEdit)ctrl).Properties.AppearanceFocused.BackColor = MyColor;
                    }
                    else if (ctrl.GetType() == typeof(TextBox))
                    {
                        ((TextBox)ctrl).KeyPress += new Functions().EnterNoveNextControl;
                    }
                    else if (ctrl.GetType() == typeof(CheckBox))
                    {
                        ((CheckBox)ctrl).KeyPress += new Functions().EnterNoveNextControl;
                    }
                    else if (ctrl.GetType() == typeof(DateTimePicker))
                    {
                        ((DateTimePicker)ctrl).KeyPress += new Functions().EnterNoveNextControl;
                    }
                    if (ctrl.Controls.Count > 0)
                        EnterMoveNextForAll(ctrl, SetEditorDisableColor);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public DialogResult FlyBoxOnay(Form Owner, string MBCaption, string MBDescription)
        {
            DialogResult returnResult = DialogResult.None;

            FlyoutAction action = new FlyoutAction()
            {
                Caption = MBCaption,
                Description = MBDescription
            };

            FlyoutCommand command1 = new FlyoutCommand()
            {
                Text = "Evet",
                Result = System.Windows.Forms.DialogResult.Yes,
            };

            FlyoutCommand command2 = new FlyoutCommand()
            {
                Text = "Hayır",
                Result = System.Windows.Forms.DialogResult.No
            };

            action.Commands.Add(command1);
            action.Commands.Add(command2);

            FlyoutProperties properties = new FlyoutProperties();
            //properties.ButtonSize = new System.Drawing.Size(100, 40);
            properties.Style = FlyoutStyle.MessageBox;

            returnResult = DevExpress.XtraBars.Docking2010.Customization.FlyoutDialog.Show(Owner, action, properties);

            return returnResult;
        }
        public DialogResult FlyBoxBilgi(Form Owner, string MBCaption, string MBDescription)
        {
            DialogResult returnResult = DialogResult.None;

            FlyoutAction action = new FlyoutAction()
            {
                Caption = MBCaption,
                Description = MBDescription,
            };

            FlyoutCommand command1 = new FlyoutCommand()
            {
                Text = "Tamam",
                Result = System.Windows.Forms.DialogResult.OK
            };


            action.Commands.Add(command1);

            FlyoutProperties properties = new FlyoutProperties();
            //properties.ButtonSize = new System.Drawing.Size(100, 40);
            properties.Style = FlyoutStyle.MessageBox;

            returnResult = DevExpress.XtraBars.Docking2010.Customization.FlyoutDialog.Show(Owner, action, properties);

            return returnResult;
        }
        public DialogResult FlyBoxHata(Form Owner, string MBCaption, string MBDescription)
        {
            DialogResult returnResult = DialogResult.None;

            FlyoutAction action = new FlyoutAction()
            {
                Caption = MBCaption,
                Description = MBDescription,
            };

            FlyoutCommand command1 = new FlyoutCommand()
            {
                Text = "Tamam",
                Result = System.Windows.Forms.DialogResult.OK
            };


            action.Commands.Add(command1);

            FlyoutProperties properties = new FlyoutProperties();
            //properties.ButtonSize = new System.Drawing.Size(100, 40);
            properties.Style = FlyoutStyle.MessageBox;

            returnResult = DevExpress.XtraBars.Docking2010.Customization.FlyoutDialog.Show(Owner, action, properties);

            return returnResult;
        }
        public static void SetEditDataClone(object target, object source)
        {
            if (target.GetType() == typeof(DevExpress.XtraEditors.LookUpEdit) && source.GetType() == typeof(DevExpress.XtraEditors.LookUpEdit))
            {
                DevExpress.XtraEditors.LookUpEdit Mytrg = (DevExpress.XtraEditors.LookUpEdit)target;
                DevExpress.XtraEditors.LookUpEdit MySrc = (DevExpress.XtraEditors.LookUpEdit)source;

                DataTable CloneTb = (DataTable)MySrc.Properties.DataSource;
                Mytrg.Properties.DataSource = CloneTb;
                Mytrg.KeyDown += MyLookUpCombo_KeyDown;
                Mytrg.CloseUp += MyLookUpCombo_CloseUp;

                for (int i = 0; i <= MySrc.Properties.Columns.Count - 1; i++)
                    Mytrg.Properties.Columns.Add(new LookUpColumnInfo(MySrc.Properties.Columns[i].FieldName, MySrc.Properties.Columns[i].Caption));

                Mytrg.Properties.ValueMember = MySrc.Properties.ValueMember;
                Mytrg.Properties.DisplayMember = MySrc.Properties.DisplayMember;
                Mytrg.Properties.BestFitMode = BestFitMode.BestFitResizePopup;

            }
            else if (target.GetType() == typeof(DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit) && source.GetType() == typeof(DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit))
            {
                DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit Mytrg = (DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit)target;
                DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit MySrc = (DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit)source;

                DataTable CloneTb = (DataTable)MySrc.DataSource;
                Mytrg.DataSource = CloneTb;
                Mytrg.KeyDown += MyLookUpCombo_KeyDown;
                Mytrg.CloseUp += MyLookUpCombo_CloseUp;

                for (int i = 0; i <= MySrc.Columns.Count - 1; i++)
                    Mytrg.Columns.Add(new LookUpColumnInfo(MySrc.Columns[i].FieldName, MySrc.Columns[i].Caption));

                Mytrg.ValueMember = MySrc.ValueMember;
                Mytrg.DisplayMember = MySrc.DisplayMember;
                Mytrg.BestFitMode = BestFitMode.BestFitResizePopup;

            }
            else if (target.GetType() == typeof(DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit) && source.GetType() == typeof(DevExpress.XtraEditors.LookUpEdit))
            {
                DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit Mytrg = (DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit)target;
                DevExpress.XtraEditors.LookUpEdit MySrc = (DevExpress.XtraEditors.LookUpEdit)source;

                DataTable CloneTb = (DataTable)MySrc.Properties.DataSource;
                Mytrg.DataSource = CloneTb;
                Mytrg.KeyDown += MyLookUpCombo_KeyDown;
                Mytrg.CloseUp += MyLookUpCombo_CloseUp;

                for (int i = 0; i <= MySrc.Properties.Columns.Count - 1; i++)
                    Mytrg.Columns.Add(new LookUpColumnInfo(MySrc.Properties.Columns[i].FieldName, MySrc.Properties.Columns[i].Caption));

                Mytrg.ValueMember = MySrc.Properties.ValueMember;
                Mytrg.DisplayMember = MySrc.Properties.DisplayMember;
                Mytrg.BestFitMode = BestFitMode.BestFitResizePopup;

            }
            else if (target.GetType() == typeof(DevExpress.XtraEditors.LookUpEdit) && source.GetType() == typeof(DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit))
            {
                DevExpress.XtraEditors.LookUpEdit Mytrg = (DevExpress.XtraEditors.LookUpEdit)target;
                DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit MySrc = (DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit)source;


                DataTable CloneTb = (DataTable)MySrc.DataSource;
                Mytrg.Properties.DataSource = CloneTb;
                Mytrg.Properties.KeyDown += MyLookUpCombo_KeyDown;
                Mytrg.Properties.CloseUp += MyLookUpCombo_CloseUp;

                for (int i = 0; i <= MySrc.Columns.Count - 1; i++)
                    Mytrg.Properties.Columns.Add(new LookUpColumnInfo(MySrc.Columns[i].FieldName, MySrc.Columns[i].Caption));

                Mytrg.Properties.ValueMember = MySrc.ValueMember;
                Mytrg.Properties.DisplayMember = MySrc.DisplayMember;
                Mytrg.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
            }
        }
        public void SetEditDataSource(object MyObj, object Source, string KeyField, string DisplayField, object FilterFields)
        {

            string[] DisplayFields = (DisplayField).Split(',').Where(x => x != string.Empty).Distinct().ToArray();
            string[,] FieldNames = new string[DisplayFields.Length, 2];
            for (int i = 0; i < DisplayFields.Length; i++)
            {
                if (DisplayFields[i].Split('|').Length == 1)
                {
                    FieldNames[i, 0] = DisplayFields[i].Split('|')[0];
                    FieldNames[i, 1] = DisplayFields[i].Split('|')[0];
                }
                else
                {
                    FieldNames[i, 0] = DisplayFields[i].Split('|')[0];
                    FieldNames[i, 1] = DisplayFields[i].Split('|')[1];
                }
            }
            if (Source != null)
                SetDxEditDataSource(MyObj, Source, KeyField, FieldNames, FilterFields, false);
        }
        public void SetEditDataSource(object MyObj, object Source, string KeyField, string DisplayField, object FilterFields, bool ShowCheckBox)
        {

            string[] DisplayFields = (DisplayField).Split(',').Where(x => x != string.Empty).Distinct().ToArray();
            string[,] FieldNames = new string[DisplayFields.Length, 2];
            for (int i = 0; i < DisplayFields.Length; i++)
            {
                if (DisplayFields[i].Split('|').Length == 1)
                {
                    FieldNames[i, 0] = DisplayFields[i].Split('|')[0];
                    FieldNames[i, 1] = DisplayFields[i].Split('|')[0];
                }
                else
                {
                    FieldNames[i, 0] = DisplayFields[i].Split('|')[0];
                    FieldNames[i, 1] = DisplayFields[i].Split('|')[1];
                }
            }
            if (Source != null)
                SetDxEditDataSource(MyObj, Source, KeyField, FieldNames, FilterFields, ShowCheckBox);
        }
        private void SetDxEditDataSource(object MyObj, object Source, string KeyField, string[,] FieldNames, object FilterFields, bool ShowCheckBox)
        {
            try
            {
                string DisplayMember= FieldNames[0, 1];
                //LinqServerModeSource linqSource = new LinqServerModeSource();
                ////linqSource.QueryableSource = Source;
                //linqSource.KeyExpression = KeyField;

                if (MyObj.GetType() == typeof(LookUpEdit))
                {
                    LookUpEdit MyLookUp = (LookUpEdit)MyObj;
                    MyLookUp.Properties.BeginUpdate();
                    MyLookUp.KeyDown += LookUpCombo_KeyDown;
                    MyLookUp.CloseUp += LookUpCombo_CloseUp;

                    MyLookUp.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
                    MyLookUp.Properties.SearchMode = SearchMode.AutoFilter;
                    MyLookUp.Properties.AllowMouseWheel = false;
                    MyLookUp.Properties.ShowHeader = true;

                    //MyLookUp.Properties.AutoSearchColumnIndex = MyLookUp.Properties.Columns.IndexOf(MyLookUp.Properties.Columns.GetVisibleColumn(0));
                    //MyLookUp.Properties.SearchMode = SearchMode.AutoComplete;

                    MyLookUp.Properties.DataSource = Source;
                    MyLookUp.Properties.ValueMember = KeyField;
                    MyLookUp.Properties.DisplayMember = DisplayMember;
                    MyLookUp.Properties.Columns.Clear();

                    LookUpColumnInfo keyCol = new LookUpColumnInfo() { FieldName = KeyField, Visible = false };
                    MyLookUp.Properties.Columns.Add(keyCol);

                    for (int i = 0; i < FieldNames.GetLength(0); i++)
                    {
                        LookUpColumnInfo col = new LookUpColumnInfo() { FieldName = FieldNames[i, 1], Caption = FieldNames[i, 0], Visible = true };
                        MyLookUp.Properties.Columns.Add(col);
                    }
                    MyLookUp.Properties.AutoSearchColumnIndex = MyLookUp.Properties.Columns.IndexOf(MyLookUp.Properties.Columns[FieldNames[0, 1]]);
                    MyLookUp.Properties.EndUpdate();
                }
                else if (MyObj.GetType() == typeof(RepositoryItemLookUpEdit))
                {
                    RepositoryItemLookUpEdit MyLookUp = (RepositoryItemLookUpEdit)MyObj;
                    MyLookUp.BeginUpdate();
                    MyLookUp.KeyDown += LookUpCombo_KeyDown;
                    MyLookUp.CloseUp += LookUpCombo_CloseUp;
                    MyLookUp.SearchMode = SearchMode.AutoFilter;
                    MyLookUp.BestFitMode = BestFitMode.BestFitResizePopup;
                    MyLookUp.ShowHeader = false;

                    MyLookUp.DataSource = Source;
                    MyLookUp.ValueMember = KeyField;
                    MyLookUp.DisplayMember = DisplayMember;

                    MyLookUp.Columns.Clear();
                    LookUpColumnInfo keyCol = new LookUpColumnInfo() { FieldName = KeyField, Visible = false };
                    MyLookUp.Columns.Add(keyCol);

                    for (int i = 0; i < FieldNames.GetLength(0); i++)
                    {
                        LookUpColumnInfo col = new LookUpColumnInfo() { FieldName = FieldNames[i, 1], Caption = FieldNames[i, 0], Visible = true };
                        MyLookUp.Columns.Add(col);
                    }
                    MyLookUp.EndUpdate();
                }
                else if (MyObj.GetType() == typeof(SearchLookUpEdit))
                {
                    SearchLookUpEdit MyLookUp = (SearchLookUpEdit)MyObj;
                    MyLookUp.Properties.BeginUpdate();
                    MyLookUp.Properties.View.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
                    MyLookUp.Properties.View.OptionsMenu.EnableColumnMenu = false;
                    MyLookUp.Properties.View.OptionsMenu.EnableFooterMenu = false;
                    MyLookUp.Properties.View.OptionsMenu.EnableGroupPanelMenu = false;

                    MyLookUp.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Default;
                    MyLookUp.Properties.ImmediatePopup = true;
                    MyLookUp.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;

                    
                    MyLookUp.Properties.ValueMember = KeyField;
                    MyLookUp.Properties.DisplayMember = DisplayMember;
                    MyLookUp.Properties.DataSource = Source;

                    if (ShowCheckBox)
                    {
                        MyLookUp.Properties.ShowFooter = false;
                        MyLookUp.Properties.ShowClearButton = false;
                        MyLookUp.Properties.View.OptionsSelection.CheckBoxSelectorColumnWidth = 30;
                        MyLookUp.Properties.View.OptionsSelection.MultiSelect = true;
                        MyLookUp.Properties.View.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
                        MyLookUp.Properties.View.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.True;
                        MyLookUp.Properties.View.OptionsSelection.ShowCheckBoxSelectorInGroupRow = DevExpress.Utils.DefaultBoolean.True;
                        MyLookUp.Properties.CloseUp += Properties_CloseUp;
                        MyLookUp.Properties.CustomDisplayText += Properties_CustomDisplayText;
                    }

                    for (int i = 0; i < FieldNames.GetLength(0); i++)
                    {
                        MyLookUp.Properties.View.Columns.AddVisible(FieldNames[i, 1], FieldNames[i, 0]);
                    }

                    if (MyLookUp.Properties.View.VisibleColumns.Count > 1)
                    {
                        MyLookUp.Properties.View.OptionsView.ColumnAutoWidth = false;
                        MyLookUp.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
                    }
                    if (FilterFields != null && ((string)FilterFields).Length > 0)
                    {
                        string[] FltFlds = ((string)FilterFields).Split(',');
                        foreach (string fltfld in FltFlds)
                        {
                            MyLookUp.Properties.View.Columns.Add(new GridColumn() { FieldName = fltfld, Caption = fltfld, Visible = false });
                        }
                    }
                    MyLookUp.Properties.EndUpdate();
                }
                else if (MyObj.GetType() == typeof(RepositoryItemSearchLookUpEdit))
                {
                    RepositoryItemSearchLookUpEdit MyLookUp = (RepositoryItemSearchLookUpEdit)MyObj;
                    MyLookUp.BeginUpdate();
                    MyLookUp.View.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
                    MyLookUp.View.OptionsMenu.EnableColumnMenu = false;
                    MyLookUp.View.OptionsMenu.EnableFooterMenu = false;
                    MyLookUp.View.OptionsMenu.EnableGroupPanelMenu = false;
                    MyLookUp.View.OptionsMenu.EnableColumnMenu = false;

                    MyLookUp.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
                    MyLookUp.ImmediatePopup = true;
                    MyLookUp.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;

                    MyLookUp.DataSource = Source;
                    MyLookUp.ValueMember = KeyField;
                    MyLookUp.DisplayMember = DisplayMember;
                    MyLookUp.View.Columns.Clear();

                    for (int i = 0; i < FieldNames.GetLength(0); i++)
                    {
                        MyLookUp.View.Columns.AddVisible(FieldNames[i, 1], FieldNames[i, 0]);
                    }

                    if (MyLookUp.View.VisibleColumns.Count > 1)
                    {
                        MyLookUp.View.OptionsView.ColumnAutoWidth = false;
                        MyLookUp.BestFitMode = BestFitMode.BestFitResizePopup;
                    }
                    if (FilterFields != null && ((string)FilterFields).Length > 0)
                    {
                        string[] FltFlds = ((string)FilterFields).Split(',');
                        foreach (string fltfld in FltFlds)
                        {
                            MyLookUp.View.Columns.Add(new GridColumn() { FieldName = fltfld, Caption = fltfld, Visible = false });
                        }
                    }
                    MyLookUp.EndUpdate();
                }
                else if (MyObj.GetType() == typeof(CheckedComboBoxEdit))
                {
                    ((CheckedComboBoxEdit)MyObj).Properties.DataSource = Source;
                    ((CheckedComboBoxEdit)MyObj).Properties.ValueMember = KeyField;
                    ((CheckedComboBoxEdit)MyObj).Properties.DisplayMember = DisplayMember;
                    ((CheckedComboBoxEdit)MyObj).Properties.SeparatorChar = ';';
                    ((CheckedComboBoxEdit)MyObj).Properties.IncrementalSearch = true;
                }
                else if (MyObj.GetType() == typeof(RepositoryItemCheckedComboBoxEdit))
                {
                    ((RepositoryItemCheckedComboBoxEdit)MyObj).DataSource = Source;
                    ((RepositoryItemCheckedComboBoxEdit)MyObj).ValueMember = KeyField;
                    ((RepositoryItemCheckedComboBoxEdit)MyObj).DisplayMember = DisplayMember;
                    ((RepositoryItemCheckedComboBoxEdit)MyObj).SeparatorChar = ';';
                    ((RepositoryItemCheckedComboBoxEdit)MyObj).IncrementalSearch = true;
                }
                else if (MyObj.GetType() == typeof(CheckedListBoxControl))
                {
                    ((CheckedListBoxControl)MyObj).DataSource = Source;
                    ((CheckedListBoxControl)MyObj).ValueMember = KeyField;
                    ((CheckedListBoxControl)MyObj).DisplayMember = DisplayMember;
                    ActivateDataSource(((CheckedListBoxControl)MyObj));
                }
                else if (MyObj.GetType() == typeof(ListBoxControl))
                {
                    ((ListBoxControl)MyObj).DataSource = Source;
                    ((ListBoxControl)MyObj).ValueMember = KeyField;
                    ((ListBoxControl)MyObj).DisplayMember = DisplayMember;
                }
                //else if (MyObj.GetType() == typeof(ImageComboBoxEdit))
                //{
                //    ((ImageComboBoxEdit)MyObj).Properties.Items.Clear();
                //    foreach (var dr in Source)
                //    {
                //        ((ImageComboBoxEdit)MyObj).Properties.Items.Add(new ImageComboBoxItem(GetPropValue(dr, FieldNames[0, 1]).ToString(), Convert.ToInt32(GetPropValue(dr, KeyField)), -1));
                //    }
                //}
                //else if (MyObj.GetType() == typeof(RepositoryItemImageComboBox))
                //{
                //    ((RepositoryItemImageComboBox)MyObj).Items.Clear();
                //    foreach (var dr in Source)
                //    {
                //        ((RepositoryItemImageComboBox)MyObj).Items.Add(new ImageComboBoxItem(GetPropValue(dr, FieldNames[0, 1]).ToString(), Convert.ToInt32(GetPropValue(dr, KeyField)), -1));
                //    }
                //}
            }
            catch (Exception ex)
            {

            }
        }

        public void SetEditDataSourceIQ(object MyObj, IQueryable<object> Source, string KeyField, string DisplayField, object FilterFields)
        {

            string[] DisplayFields = (DisplayField).Split(',').Where(x => x != string.Empty).Distinct().ToArray();
            string[,] FieldNames = new string[DisplayFields.Length, 2];
            for (int i = 0; i < DisplayFields.Length; i++)
            {
                if (DisplayFields[i].Split('|').Length == 1)
                {
                    FieldNames[i, 0] = DisplayFields[i].Split('|')[0];
                    FieldNames[i, 1] = DisplayFields[i].Split('|')[0];
                }
                else
                {
                    FieldNames[i, 0] = DisplayFields[i].Split('|')[0];
                    FieldNames[i, 1] = DisplayFields[i].Split('|')[1];
                }
            }
            if (Source != null)
                SetDxEditDataSourceID(MyObj, Source, KeyField, FieldNames, FilterFields, false);
        }

        private void SetDxEditDataSourceID(object MyObj, IQueryable<object> Source, string KeyField, string[,] FieldNames, object FilterFields, bool ShowCheckBox)
        {
            try
            {
                LinqServerModeSource linqSource = new LinqServerModeSource();
                linqSource.QueryableSource = Source;
                linqSource.KeyExpression = KeyField;

                if (MyObj.GetType() == typeof(LookUpEdit))
                {
                    LookUpEdit MyLookUp = (LookUpEdit)MyObj;
                    MyLookUp.Properties.BeginUpdate();
                    MyLookUp.KeyDown += LookUpCombo_KeyDown;
                    MyLookUp.CloseUp += LookUpCombo_CloseUp;
                    MyLookUp.Properties.SearchMode = SearchMode.AutoComplete;
                    MyLookUp.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
                    MyLookUp.Properties.ShowHeader = true;

                    MyLookUp.Properties.DataSource = linqSource;
                    MyLookUp.Properties.ValueMember = KeyField;
                    MyLookUp.Properties.DisplayMember = FieldNames[0, 1];
                    MyLookUp.Properties.Columns.Clear();

                    LookUpColumnInfo keyCol = new LookUpColumnInfo() { FieldName = KeyField, Visible = false };
                    MyLookUp.Properties.Columns.Add(keyCol);

                    for (int i = 0; i < FieldNames.GetLength(0); i++)
                    {
                        LookUpColumnInfo col = new LookUpColumnInfo() { FieldName = FieldNames[i, 1], Caption = FieldNames[i, 0], Visible = true };
                        MyLookUp.Properties.Columns.Add(col);
                    }
                    MyLookUp.Properties.AutoSearchColumnIndex = MyLookUp.Properties.Columns.IndexOf(MyLookUp.Properties.Columns[FieldNames[0, 1]]);
                    MyLookUp.Properties.EndUpdate();
                }
                else if (MyObj.GetType() == typeof(RepositoryItemLookUpEdit))
                {
                    RepositoryItemLookUpEdit MyLookUp = (RepositoryItemLookUpEdit)MyObj;
                    MyLookUp.BeginUpdate();
                    MyLookUp.KeyDown += LookUpCombo_KeyDown;
                    MyLookUp.CloseUp += LookUpCombo_CloseUp;
                    MyLookUp.SearchMode = SearchMode.AutoComplete;
                    MyLookUp.BestFitMode = BestFitMode.BestFitResizePopup;
                    MyLookUp.ShowHeader = false;

                    MyLookUp.DataSource = linqSource;
                    MyLookUp.ValueMember = KeyField;
                    MyLookUp.DisplayMember = FieldNames[0, 1];

                    MyLookUp.Columns.Clear();
                    LookUpColumnInfo keyCol = new LookUpColumnInfo() { FieldName = KeyField, Visible = false };
                    MyLookUp.Columns.Add(keyCol);

                    for (int i = 0; i < FieldNames.GetLength(0); i++)
                    {
                        LookUpColumnInfo col = new LookUpColumnInfo() { FieldName = FieldNames[i, 1], Caption = FieldNames[i, 0], Visible = true };
                        MyLookUp.Columns.Add(col);
                    }
                    MyLookUp.EndUpdate();
                }
                else if (MyObj.GetType() == typeof(SearchLookUpEdit))
                {
                    SearchLookUpEdit MyLookUp = (SearchLookUpEdit)MyObj;
                    MyLookUp.Properties.BeginUpdate();
                    MyLookUp.Properties.View.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
                    MyLookUp.Properties.View.OptionsMenu.EnableColumnMenu = false;
                    MyLookUp.Properties.View.OptionsMenu.EnableFooterMenu = false;
                    MyLookUp.Properties.View.OptionsMenu.EnableGroupPanelMenu = false;
                    MyLookUp.Properties.View.OptionsMenu.EnableColumnMenu = false;

                    MyLookUp.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
                    MyLookUp.Properties.ImmediatePopup = true;
                    MyLookUp.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;

                    MyLookUp.Properties.DataSource = linqSource;
                    MyLookUp.Properties.ValueMember = KeyField;
                    MyLookUp.Properties.DisplayMember = FieldNames[0, 1];

                    MyLookUp.Properties.View.Columns.Clear();
                    if (ShowCheckBox)
                    {
                        MyLookUp.Properties.ShowFooter = false;
                        MyLookUp.Properties.ShowClearButton = false;
                        MyLookUp.Properties.View.OptionsSelection.CheckBoxSelectorColumnWidth = 30;
                        MyLookUp.Properties.View.OptionsSelection.MultiSelect = true;
                        MyLookUp.Properties.View.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
                        MyLookUp.Properties.View.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.True;
                        MyLookUp.Properties.View.OptionsSelection.ShowCheckBoxSelectorInGroupRow = DevExpress.Utils.DefaultBoolean.True;
                        MyLookUp.Properties.CloseUp += Properties_CloseUp;
                        MyLookUp.Properties.CustomDisplayText += Properties_CustomDisplayText;
                    }
                    for (int i = 0; i < FieldNames.GetLength(0); i++)
                    {
                        MyLookUp.Properties.View.Columns.AddVisible(FieldNames[i, 1], FieldNames[i, 0]);
                    }

                    if (MyLookUp.Properties.View.VisibleColumns.Count > 1)
                    {
                        MyLookUp.Properties.View.OptionsView.ColumnAutoWidth = false;
                        MyLookUp.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
                    }
                    if (FilterFields != null && ((string)FilterFields).Length > 0)
                    {
                        string[] FltFlds = ((string)FilterFields).Split(',');
                        foreach (string fltfld in FltFlds)
                        {
                            MyLookUp.Properties.View.Columns.Add(new GridColumn() { FieldName = fltfld, Caption = fltfld, Visible = false });
                        }
                    }
                    MyLookUp.Properties.EndUpdate();
                }
                else if (MyObj.GetType() == typeof(RepositoryItemSearchLookUpEdit))
                {
                    RepositoryItemSearchLookUpEdit MyLookUp = (RepositoryItemSearchLookUpEdit)MyObj;
                    MyLookUp.BeginUpdate();
                    MyLookUp.View.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
                    MyLookUp.View.OptionsMenu.EnableColumnMenu = false;
                    MyLookUp.View.OptionsMenu.EnableFooterMenu = false;
                    MyLookUp.View.OptionsMenu.EnableGroupPanelMenu = false;
                    MyLookUp.View.OptionsMenu.EnableColumnMenu = false;

                    MyLookUp.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
                    MyLookUp.ImmediatePopup = true;
                    MyLookUp.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;

                    MyLookUp.DataSource = linqSource;
                    MyLookUp.ValueMember = KeyField;
                    MyLookUp.DisplayMember = FieldNames[0, 1];
                    MyLookUp.View.Columns.Clear();

                    for (int i = 0; i < FieldNames.GetLength(0); i++)
                    {
                        MyLookUp.View.Columns.AddVisible(FieldNames[i, 1], FieldNames[i, 0]);
                    }

                    if (MyLookUp.View.VisibleColumns.Count > 1)
                    {
                        MyLookUp.View.OptionsView.ColumnAutoWidth = false;
                        MyLookUp.BestFitMode = BestFitMode.BestFitResizePopup;
                    }
                    if (FilterFields != null && ((string)FilterFields).Length > 0)
                    {
                        string[] FltFlds = ((string)FilterFields).Split(',');
                        foreach (string fltfld in FltFlds)
                        {
                            MyLookUp.View.Columns.Add(new GridColumn() { FieldName = fltfld, Caption = fltfld, Visible = false });
                        }
                    }
                    MyLookUp.EndUpdate();
                }
                else if (MyObj.GetType() == typeof(CheckedComboBoxEdit))
                {
                    ((CheckedComboBoxEdit)MyObj).Properties.DataSource = Source.ToList();
                    ((CheckedComboBoxEdit)MyObj).Properties.ValueMember = KeyField;
                    ((CheckedComboBoxEdit)MyObj).Properties.DisplayMember = FieldNames[0, 1];
                    ((CheckedComboBoxEdit)MyObj).Properties.SeparatorChar = ';';
                    ((CheckedComboBoxEdit)MyObj).Properties.IncrementalSearch = true;
                }
                else if (MyObj.GetType() == typeof(RepositoryItemCheckedComboBoxEdit))
                {
                    ((RepositoryItemCheckedComboBoxEdit)MyObj).DataSource = Source.ToList();
                    ((RepositoryItemCheckedComboBoxEdit)MyObj).ValueMember = KeyField;
                    ((RepositoryItemCheckedComboBoxEdit)MyObj).DisplayMember = FieldNames[0, 1];
                    ((RepositoryItemCheckedComboBoxEdit)MyObj).SeparatorChar = ';';
                    ((RepositoryItemCheckedComboBoxEdit)MyObj).IncrementalSearch = true;
                }
                else if (MyObj.GetType() == typeof(CheckedListBoxControl))
                {
                    ((CheckedListBoxControl)MyObj).DataSource = Source.ToList();
                    ((CheckedListBoxControl)MyObj).ValueMember = KeyField;
                    ((CheckedListBoxControl)MyObj).DisplayMember = FieldNames[0, 1];
                    ActivateDataSource(((CheckedListBoxControl)MyObj));
                }
                else if (MyObj.GetType() == typeof(ListBoxControl))
                {
                    ((ListBoxControl)MyObj).DataSource = Source.ToList();
                    ((ListBoxControl)MyObj).ValueMember = KeyField;
                    ((ListBoxControl)MyObj).DisplayMember = FieldNames[0, 1];
                }
                else if (MyObj.GetType() == typeof(ImageComboBoxEdit))
                {
                    ((ImageComboBoxEdit)MyObj).Properties.Items.Clear();
                    foreach (var dr in Source.ToList())
                    {
                        ((ImageComboBoxEdit)MyObj).Properties.Items.Add(new ImageComboBoxItem(GetPropValue(dr, FieldNames[0, 1]).ToString(), Convert.ToInt32(GetPropValue(dr, KeyField)), -1));
                    }
                }
                else if (MyObj.GetType() == typeof(RepositoryItemImageComboBox))
                {
                    ((RepositoryItemImageComboBox)MyObj).Items.Clear();
                    foreach (var dr in Source.ToList())
                    {
                        ((RepositoryItemImageComboBox)MyObj).Items.Add(new ImageComboBoxItem(GetPropValue(dr, FieldNames[0, 1]).ToString(), Convert.ToInt32(GetPropValue(dr, KeyField)), -1));
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void Properties_CustomDisplayText(object sender, CustomDisplayTextEventArgs e)
        {
            string result = string.Empty;
            SearchLookUpEdit edit = (SearchLookUpEdit)sender;
            int counter = edit.Properties.View.SelectedRowsCount > 3 ? 3 : edit.Properties.View.SelectedRowsCount;
            for (int i = 0; i < counter; i++)
            {
                if (edit.Properties.View.GetSelectedRows()[i] >= 0)
                    result += edit.Properties.View.GetRowCellValue(edit.Properties.View.GetSelectedRows()[i], edit.Properties.View.Columns[0]) + ";";
            }
            e.DisplayText = result;
        }

        private void Properties_CloseUp(object sender, CloseUpEventArgs e)
        {
            SearchLookUpEdit edit = (SearchLookUpEdit)sender;
            //int counter = edit.Properties.View.SelectedRowsCount > 3 ? 3 : edit.Properties.View.SelectedRowsCount;
            //for (int i = 0; i < counter; i++)
            //{
            //    if (edit.Properties.View.GetSelectedRows()[i] >= 0)
            //        result += edit.Properties.View.GetRowCellValue(edit.Properties.View.GetSelectedRows()[i], edit.Properties.View.Columns[0]) + ";";
            //}
            //edit.Text = result;
        }

        private void ActivateDataSource(CheckedListBoxControl listBox)
        {
            MethodInfo info = typeof(BaseListBoxControl).GetMethod("ActivateDataSource", BindingFlags.NonPublic | BindingFlags.Instance);
            info.Invoke(listBox, null);
        }
        public object GetPropValue(object src, string propName)
        {
            return src.GetType().GetProperty(propName).GetValue(src, null);
        }
        private void LookUpCombo_KeyDown(object sender, KeyEventArgs e)
        {
            if (sender.GetType() == typeof(DevExpress.XtraEditors.LookUpEdit))
            {
                DevExpress.XtraEditors.LookUpEdit MyLookUp = (DevExpress.XtraEditors.LookUpEdit)sender;
                if (e.KeyCode == Keys.Escape)
                    MyLookUp.ClosePopup();
            }
        }
        public void LookUpCombo_CloseUp(object sender, CloseUpEventArgs e)
        {
            if (e.CloseMode == PopupCloseMode.Cancel)
            {
                e.Value = null;
                e.AcceptValue = true;
            }
        }
        private void MyLookUp_Popup(object sender, EventArgs e)
        {
            PopupSearchLookUpEditForm form = (sender as DevExpress.Utils.Win.IPopupControl).PopupWindow as PopupSearchLookUpEditForm;
            form.KeyPreview = true;
            form.KeyDown -= OnFormKeyDown;
            form.KeyDown += OnFormKeyDown;
        }
        private void OnFormKeyDown(object sender, KeyEventArgs e)
        {
            PopupSearchLookUpEditForm form = sender as PopupSearchLookUpEditForm;
            SearchEditLookUpPopup popup = form.ActiveControl as SearchEditLookUpPopup;
            GridControl grid = popup.lciGrid.Control as GridControl;
            GridView view = grid.FocusedView as GridView;
            if (e.KeyCode == Keys.Enter)
            {
                if (view.DataRowCount > 0)
                {
                    object val = view.GetRowCellValue(0, form.OwnerEdit.Properties.ValueMember);
                    form.OwnerEdit.ClosePopup();
                    form.OwnerEdit.EditValue = val;
                }
            }
        }
        public string GetCheckListStringValue(object Obj)
        {
            string Myval = "";
            if (Obj.GetType() == typeof(DevExpress.XtraEditors.CheckedListBoxControl))
            {
                CheckedListBoxControl MyControl = (DevExpress.XtraEditors.CheckedListBoxControl)Obj;
                foreach (int i in MyControl.CheckedIndices)
                {
                    Myval = Myval + MyControl.GetItemValue(i).ToString() + ";";
                }
            }
            else if (Obj.GetType() == typeof(DevExpress.XtraEditors.CheckedComboBoxEdit))
            {
                CheckedComboBoxEdit MyControl = (DevExpress.XtraEditors.CheckedComboBoxEdit)Obj;
                Myval = MyControl.EditValue.ToString();

            }
            else if (Obj.GetType() == typeof(SearchLookUpEdit))
            {
                SearchLookUpEdit edit = (SearchLookUpEdit)Obj;
                for (int i = 0; i < edit.Properties.View.SelectedRowsCount; i++)
                {
                    if (edit.Properties.View.GetSelectedRows()[i] >= 0)
                        Myval += edit.Properties.View.GetRowCellValue(edit.Properties.View.GetSelectedRows()[i], edit.Properties.ValueMember) + ";";
                }
            }
            else if (Obj.GetType() == typeof(RepositoryItemSearchLookUpEdit))
            { }
            return Myval.Length > 0 ? Myval[Myval.Length - 1] == ';' ? Myval.Substring(0, Myval.Length - 1) : Myval : Myval;
        }
        public void SetCheckEditValues(object Obj, string value)
        {
            if (value != null)
            {
                char[] delimiterChars = { ' ', ',', '.', ':', '\t', ';' };
                string[] words = value.Split(delimiterChars);

                if (Obj.GetType() == typeof(DevExpress.XtraEditors.CheckedListBoxControl))
                {
                    CheckedListBoxControl MyControl = (DevExpress.XtraEditors.CheckedListBoxControl)Obj;
                    for (int i = 0; i < MyControl.ItemCount; i++)
                    {
                        foreach (string s in words)
                        {
                            if (MyControl.GetItemValue(i).ToString() == s)
                                MyControl.SetItemChecked(i, true);
                        }
                    }
                }
                else if (Obj.GetType() == typeof(DevExpress.XtraEditors.CheckedComboBoxEdit))
                {
                    CheckedComboBoxEdit MyControl = (DevExpress.XtraEditors.CheckedComboBoxEdit)Obj;
                    MyControl.EditValue = value;
                }

            }
        }
        public int SetImageComboBoxValue(object Obj, Int32 val)
        {
            int j = -1;
            if (Obj.GetType() == typeof(DevExpress.XtraEditors.ImageComboBoxEdit))
                for (int i = 0; i < ((DevExpress.XtraEditors.ImageComboBoxEdit)Obj).Properties.Items.Count; i++)
                    if (Convert.ToInt32(((DevExpress.XtraEditors.ImageComboBoxEdit)Obj).Properties.Items[i].Value) == val)
                        j = i;
            return j;
        }

        public void simpleBtn_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                if (sender.GetType() != typeof(SimpleButton))
                    return;

                SimpleButton sb = (SimpleButton)sender;
                DevExpress.Skins.Skin currentSkin;
                currentSkin = DevExpress.Skins.CommonSkins.GetSkin(sb.LookAndFeel);
                Color foreColor = currentSkin.Colors.GetColor(DevExpress.Skins.CommonColors.WindowText);

                Graphics g = e.Graphics;
                Rectangle borderRectangle = new Rectangle(
                    e.ClipRectangle.Location,
                    new Size(
                        e.ClipRectangle.Width - 1,
                        e.ClipRectangle.Height - 1));

                g.DrawRectangle(new Pen(foreColor, 3), borderRectangle);
            }
            catch
            {

            }
        }

        public void SetGrid(GridView view, bool SetModified)
        {
            try
            {
                bool bulundu = false;
                view.BeginDataUpdate();
                if (view.Columns.Count == 0)
                    view.PopulateColumns();

                RepositoryItemSpinEdit riSpinEdit = new RepositoryItemSpinEdit();
                riSpinEdit.Mask.EditMask = "n2";
                riSpinEdit.Mask.UseMaskAsDisplayFormat = true;


                for (int i = 0; i <= view.Columns.Count - 1; i++)
                {
                    if (view.Columns[i].FieldName == "Modified")
                        bulundu = true;
                    if (view.Columns[i].FieldName.EndsWith("id"))
                        view.Columns[i].Visible = false;
                    if (view.Columns[i].FieldName.EndsWith("ID"))
                        view.Columns[i].Visible = false;
                    if (view.Columns[i].FieldName.EndsWith("IDs"))
                        view.Columns[i].Visible = false;
                    if (view.Columns[i].FieldName.EndsWith("List"))
                        view.Columns[i].Visible = false;
                    if (view.Columns[i].FieldName == ("CreatedBy"))
                        view.Columns[i].Visible = false;
                    if (view.Columns[i].FieldName.EndsWith("ModifiedBy"))
                        view.Columns[i].Visible = false;
                    else if ((view.Columns[i].ColumnType == typeof(double)|| view.Columns[i].ColumnType == typeof(decimal)) && 
                             (view.Columns[i].FieldName.Contains("Toplam")|| view.Columns[i].FieldName.Contains("Tutar")))
                    {
                        view.Columns[i].OptionsColumn.FixedWidth = true;
                        view.Columns[i].ColumnEdit = riSpinEdit;
                        view.Columns[i].Width = 110;
                    }
                    else if (view.Columns[i].ColumnType == typeof(DateTime))
                    {
                        view.Columns[i].OptionsColumn.FixedWidth = true;
                        view.Columns[i].Width = 70;
                    }
                    else if (view.Columns[i].ColumnType == typeof(Boolean))
                    {
                        view.Columns[i].OptionsColumn.FixedWidth = true;
                        view.Columns[i].Width = 70;
                    }
                    else if (view.Columns[i].FieldName == "Oluşturan")
                    {
                        view.Columns[i].OptionsColumn.FixedWidth = true;
                        view.Columns[i].Width = 100;
                    }
                    else if (view.Columns[i].FieldName == "Değiştiren")
                    {
                        view.Columns[i].OptionsColumn.FixedWidth = true;
                        view.Columns[i].Width = 100;
                    }
                    else if (view.Columns[i].FieldName == "RenkKodu")
                    {
                        view.Columns[i].Visible = false;
                        //    RepositoryItemColorEdit riColorEdit = new RepositoryItemColorEdit();
                        //    view.Columns[i].OptionsColumn.FixedWidth = true;
                        //    view.Columns[i].ColumnEdit = riColorEdit;
                        //    view.Columns[i].Width = 150;
                    }
                }

                if (!bulundu && SetModified)
                {
                    GridColumn unbColumn = view.Columns.AddField("Modified");
                    unbColumn.VisibleIndex = view.Columns.Count;
                    unbColumn.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
                    unbColumn.OptionsColumn.AllowEdit = false;
                    //view.CellValueChanging += View_CellValueChanging;
                    //view.CustomUnboundColumnData += View_CustomUnboundColumnData;
                }

                //for (int j = 0; j < view.DataRowCount; j++)
                //    view.SetRowCellValue(j, "Modified", false);

                view.BestFitColumns();
                view.EndDataUpdate();
            }
            catch (Exception ex)
            {

            }
        }
        public void SetcustomColumns(GridView view, object[] args)
        {
            try
            {
                if (args == null) return;
                view.Columns.Clear();
                for (int i = 0; args.Length > i; i++)
                {
                    DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn()
                    {
                        Caption = ((CustomDataObject)args[i]).Name,
                        FieldName = Convert.ToString(((CustomDataObject)args[i]).Value),

                    };
                    view.Columns.Add(column);
                    column.VisibleIndex = i;
                }
                view.BestFitColumns();
                view.OptionsView.ColumnAutoWidth = false;
            }
            catch (Exception ex)
            {

            }
        }
        private DevExpress.XtraEditors.Controls.PictureMenu GetMenu(DevExpress.XtraEditors.PictureEdit edit)
        {
            PropertyInfo pi = typeof(DevExpress.XtraEditors.PictureEdit).GetProperty("Menu", BindingFlags.NonPublic | BindingFlags.Instance);
            if (pi != null)
                return pi.GetValue(edit, null) as DevExpress.XtraEditors.Controls.PictureMenu;
            return null;
        }

        public void InvokeMenuMethod(DevExpress.XtraEditors.PictureEdit edit, String name)
        {
            PictureMenu menu = GetMenu(edit);
            MethodInfo mi = typeof(DevExpress.XtraEditors.Controls.PictureMenu).GetMethod(name, BindingFlags.NonPublic | BindingFlags.Instance);
            if (mi != null && menu != null)
                mi.Invoke(menu, new object[] { menu, new EventArgs() });
        }

        public void ViewTempDeletedRowStyle(object sender, RowStyleEventArgs e)
        {
            try
            {
                GridView View = sender as GridView;
                if (e.RowHandle >= 0)
                {
                    if (Convert.ToBoolean(View.GetRowCellValue(e.RowHandle, View.Columns["Deleted"])))
                        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Strikeout);
                    else
                        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Regular);
                }
            }
            catch (Exception ex)
            {
            }
           
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        //**************************************************************************
        private static void MyLookUpCombo_KeyDown(object sender, KeyEventArgs e)
        {
            if (sender.GetType() == typeof(DevExpress.XtraEditors.LookUpEdit))
            {
                DevExpress.XtraEditors.LookUpEdit MyLookUp = (DevExpress.XtraEditors.LookUpEdit)sender;
                if (e.KeyCode == Keys.Escape)
                    MyLookUp.ClosePopup();
            }
        }

        public static void MyLookUpCombo_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            if (e.CloseMode == PopupCloseMode.Cancel)
            {
                e.Value = null;
                e.AcceptValue = true;
            }
        }

        public static void GridColumProperties(GridView TempGridView)
        {
            TempGridView.PopulateColumns();
            string[] HideColName = new string[11] { "ID", "CompanyID", "KisiID", "PersonelID", "OfficeID", "UlkeID", "SehirID", "UserID","HatTipiID", "CariID", "RenkKodu" };
            foreach (GridColumn col in TempGridView.Columns)
            {
                if (col.ColumnType == Type.GetType("System.DateTime"))
                    col.OptionsFilter.FilterPopupMode = FilterPopupMode.Date;
                else
                    col.OptionsFilter.FilterPopupMode = FilterPopupMode.CheckedList;
                if (col.FieldName == "CariAd")
                    col.Width = 280;
                if (col.FieldName == "OtelAdi")
                    col.Width = 280;
                if (col.FieldName == "YolcuAdi")
                    col.Width = 200;
                if (col.FieldName == "AdSoyad")
                    col.Width = 200;
                if (col.FieldName == "HizmetAlan")
                    col.Width = 200;
                if (col.FieldName == "IslemNo")
                    col.Width = 90;
                if (col.FieldName == "EvrakNo")
                    col.Width = 200;
                foreach (string j in HideColName)
                {
                    if (col.FieldName == j)
                        col.Visible = false;
                }
            }
        }
    }
}

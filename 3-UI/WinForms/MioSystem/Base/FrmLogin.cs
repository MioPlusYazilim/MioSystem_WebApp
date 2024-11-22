using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.XtraEditors.ViewInfo;
using MioSystem.DxUtils;
using Portal.Data.Services;
using Portal.Helpers;
using Portal.Model;
using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;
using DevExpress.XtraEditors;

namespace MioSystem
{
    public partial class FrmLogin : XtraForm
    {
        public string version = string.Empty;
        public bool CheckUser = false;
        public Login loginUser = Login.GetLoginUser();
        private void chkHatirla_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHatirla.Checked == false)
                tePassword.EditValue = "";
        }
        public FrmLogin()
        {
            InitializeComponent();
            imCBLanguage.SelectedIndex = 0;
            versionLabelControl.Text = version;

            SetLoginInfo();
            SetFormLanguage(loginUser.displayLanguage);
        }
        void SetLoginInfo()
        {
            //List<SelectItem> databases = GetDatabaseNames(LoginUser.ConnStr);
            //DxFunctions.SetEditDataSource(cbDataBase, databases, "Kod", "Ad", null);

            //cbDataBase.ItemIndex = 0;
        }
        private void ValidateUser()
        {
            DxFunctions dxFunctions = new DxFunctions();
            try
            {
                dxFunctions.ShowWaitForm("...");

                dxValidationProvider1.Validate();
                if (dxValidationProvider1.GetInvalidControls().Count == 0)
                {
                    var result = new AuthenticateService().Login(teUserName.Text, tePassword.Text);

                    if (result.isSuccess)
                    {
                        SetLoginUserInfo((Login)result.returnValue);
                        DialogResult = DialogResult.OK;
                        dxFunctions.CloseWaitForm();
                        Close();

                    }
                    else
                    {
                        dxFunctions.CloseWaitForm();
                        // MessageManager.MessageBoxHata("Dikkat", result.errorMessage, "");
                    }
                }
            }
            catch (Exception ex)
            {
                dxFunctions.CloseWaitForm();
            }
        }

        void SetLoginUserInfo(Login response)
        {
            loginUser.employeeID = response.employeeID;
            loginUser.fullName = response.fullName;
            loginUser.email = response.email;
            loginUser.companyID = response.companyID;
            loginUser.companyName = response.companyName;
            loginUser.companyCode = response.companyCode;
            loginUser.token = response.token;
            loginUser.refreshToken = response.refreshToken;
            loginUser.authories = response.authories;
            loginUser.mainMenu = response.mainMenu;
            loginUser.settingsMenu = response.settingsMenu;
            loginUser.winTheme = response.winTheme ?? "Basic";
            loginUser.displayLanguage = response.displayLanguage;
            loginUser.clientKey = response.clientKey;

            string[] skininfo = loginUser.winTheme.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            if (skininfo.Length > 1)
                UserLookAndFeel.Default.SetSkinStyle(skininfo[0], skininfo[1]);
            else UserLookAndFeel.Default.SetSkinStyle(skininfo[0]);
        }
        private void tePassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                ValidateUser();
            }
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                Close();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ValidateUser();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void dxValidationProvider1_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            try
            {
                DevExpress.XtraEditors.BaseEdit edit = (DevExpress.XtraEditors.BaseEdit)e.InvalidControl;
                if (edit == null)
                    return;

                BaseEditViewInfo viewInfo = (BaseEditViewInfo)edit.GetViewInfo();
                if (viewInfo == null)
                    return;

                edit.ToolTipController ??= new ToolTipControllerDefault();

                ToolTipControlInfo info = new ToolTipControlInfo(e.InvalidControl, e.ErrorText);
                info.ToolTipPosition = edit.PointToScreen(viewInfo.ErrorIconBounds.Location);

                edit.ToolTipController.InitialDelay = 0;
                edit.ToolTipController.ShowHint(info);
            }
            catch (Exception ex)
            {
            }

        }

        private void pictureEditSettings_Click(object sender, EventArgs e)
        {
            SetLoginInfo();
        }

        private void imCBLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (imCBLanguage.SelectedIndex > -1)
                loginUser.displayLanguage = imCBLanguage.EditValue.ToString() ?? "tr-TR";
            SetFormLanguage(loginUser.displayLanguage);
        }
        void SetFormLanguage(string language)
        {
            switch (language)
            {
                case "tr-TR":
                    itemForUserName.Text = "Kullanıcı Adı";
                    itemForUserPass.Text = "Kullanıcı Şifre";
                    itemForLanguage.Text = "Çalışma Dili";
                    itemForRememberMe.Text = "Beni Hatırla";
                    btnOk.Text = "&Tamam";
                    btnCancel.Text = "&Vazgeç";
                    break;
                case "en-EN":
                    itemForUserName.Text = "User Name";
                    itemForUserPass.Text = "Password";
                    itemForLanguage.Text = "Language";
                    itemForRememberMe.Text = "Remember me";
                    btnOk.Text = "&Ok";
                    btnCancel.Text = "&Cancel";
                    break;
            }
        }
        List<SelectItem> GetDatabaseNames(string connstr)
        {
            List<SelectItem> databases = new List<SelectItem>();
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "SELECT [name] FROM sys.databases where HAS_DBACCESS(name) > 0  and [name] like 'MioSystem%'  order by [name]";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            databases.Add(new SelectItem() { code = reader["name"].ToString(), name = reader["name"].ToString() });
                        }
                    }
                }
            }
            return databases;
        }

    }
}

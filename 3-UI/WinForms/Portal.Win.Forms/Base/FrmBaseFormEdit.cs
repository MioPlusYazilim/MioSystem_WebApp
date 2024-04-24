using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraReports.UI;
using Portal.Helpers;
using Portal.Model;
using Portal.Win.DxUtils;
using Portal.Win.Forms.Base;
using Portal.Win.Utils;
using System.Reflection;

namespace Portal.Win.Forms
{
    public partial class FrmBaseFormEdit : FrmBaseForm
    {
        public bool PopupMode = false;
        public bool menugoster = true;
        public bool BtnAraGoster = false;
        public string BtnAraCaption = string.Empty;

        public SaveResult saveResult;
        public BaseModel FormEntity;

        public int MenuID;
        public int FormID = 0;
        public int ParentID = 0;

        public NavigationRole yetki;

        public bool FormDoluyor = false;
        public bool CanClose = true;
        public bool FormSaved = false;
        string FormCaption = string.Empty;

        string modified = string.Empty;
        public string fCaption = string.Empty;




        public bool btnKapat = false;
        public bool btnReSize = false;



        DXValidationProvider FormValidator = new DXValidationProvider();
        public object[] _cols = null;
        public int FormType;

        public DxFunctions dxFunctions;

        MioUtils mutils = new MioUtils();
        public FrmBaseFormEdit()
        {
            InitializeComponent();
            dxFunctions = new DxFunctions();
        }
        public FrmBaseFormEdit(object[] args)
        {
            dxFunctions = new DxFunctions();
            this.MenuID = new ObjectConvert().ToInt32(args, "MenuID");
            this.FormID = new ObjectConvert().ToInt32(args, "FormID");
            this.ParentID = new ObjectConvert().ToInt32(args, "ParentID");
            this.FormCaption = new ObjectConvert().ToString(args, "FormCaption");
            this.PopupMode = new ObjectConvert().ToBoolean(args, "PopupMode");
            this.yetki = (NavigationRole)new ObjectConvert().ToObject(args, "NavigationAuthory");
            FormType = yetki != null ? yetki.formType : 0;
            FormValidator.ValidationMode = ValidationMode.Manual;
            InitializeComponent();
            if (loginUser.displayLanguage == "en-EN")
            {
                BarBtnNew.Caption = "New";
                BarBtnCopy.Caption = "Copy";
                BarBtnDelete.Caption = "Delete";
                BarBtnFind.Caption = "Find";
                BarBtnClose.Caption = "Close";
                BarBtnSave.Caption = "Save";
                barBtnPrint.Caption = "Print";
                BarBtnExtra.Caption = "Additional Operations";
            }
        }

        public virtual object GetList()
        {
            return null;
        }
        public void SetFormResources()
        {
        }
        private void TempEdit_Shown(object sender, EventArgs e)
        {
            barMainMenu.Visible = menugoster;
            SetFindButton();
            SetFormData();
            SetFormCaption();
            if (yetki != null)
                AddPrintButtons(yetki.menuTag);
            SetCustomButtons();
        }
        public void SetFindButton()
        {
            BarBtnFind.Caption = BtnAraCaption;
            BarBtnFind.Visibility = BtnAraGoster ? BarItemVisibility.Always : BarItemVisibility.Never;
        }
        public virtual void SetFormData()
        {

        }
        public void SetSaveButton(bool state)
        {
            BarBtnSave.Enabled = state;
        }
        public void SetDeleteButton(bool state)
        {
            BarBtnDelete.Enabled = state;
        }
        public virtual void AddPrintButtons(int MenuTag)
        {

        }

        private void BtnPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void PrintingSystem_EndPrint(object sender, EventArgs e)
        {
            ReportPrintTool pt = (ReportPrintTool)sender;
            pt.ClosePreview();
        }


        public virtual void FormEntity_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            modified = "*";
            SetFormCaption();
        }

        public virtual void SetCustomButtons()
        {

        }
        public void KontrolKuralEkle(string KontrolAdi, string KontrolAciklama, ConditionOperator islem, object value1, object value2)
        {
            try
            {
                ConditionValidationRule Kural = new ConditionValidationRule();
                Kural.ErrorText = KontrolAciklama;
                Kural.ConditionOperator = islem;
                Kural.Value1 = value1;
                Kural.Value2 = value2;

                Control Cnt = this.Controls.Find(KontrolAdi, true).FirstOrDefault();
                if (Cnt != null)
                {
                    this.FormValidator.SetValidationRule(Cnt, Kural);
                }
            }
            catch (Exception ex)
            {

            }
        }
        public void KontrolKuralKaldir(string KontrolAdi)
        {
            try
            {
                Control Cnt = this.Controls.Find(KontrolAdi, true).FirstOrDefault();
                if (Cnt != null)
                {
                    this.FormValidator.SetValidationRule(Cnt, null);
                }
            }
            catch (Exception ex)
            {

            }
        }
        public void ButonEkleBarMenu(BarButtonItem btn)
        {
            btn.AllowGlyphSkinning = DefaultBoolean.False;
            BarMenuMgn.Items.Add(btn);
            barMainMenu.ItemLinks.Add(btn);
        }
        public void ButonEkleYazdir(BarButtonItem btn)
        {
            btn.AllowGlyphSkinning = DefaultBoolean.False;
            BarMenuMgn.Items.Add(btn);
            barBtnPrint.ItemLinks.Add(btn);
        }

        public void ButonEkleEkislemler(BarButtonItem btn)
        {
            btn.AllowGlyphSkinning = DefaultBoolean.False;
            BarMenuMgn.Items.Add(btn);
            BarBtnExtra.ItemLinks.Add(btn);
        }

        public void ButonEkleEkislemler(string SubItemName, BarButtonItem btn)
        {
            try
            {
                btn.AllowGlyphSkinning = DefaultBoolean.False;
                BarItem item = BarMenuMgn.Items[SubItemName];
                ((BarSubItem)item).ItemLinks.Add(btn);
            }
            catch (Exception ex)
            {
            }

        }
        public void ButonEkleEkislemler(BarSubItem btn)
        {
            btn.AllowGlyphSkinning = DefaultBoolean.False;
            BarMenuMgn.Items.Add(btn);
            BarBtnExtra.ItemLinks.Add(btn);
        }
        public virtual void SetFormEntity()
        {

            try
            {
                FormbindingSource.DataSource = FormEntity;
                FormEntity.PropertyChanged += FormEntity_PropertyChanged;
            }
            catch (Exception ex)
            {
            }
        }

        public void SetFormCaption()
        {
            try
            {
                this.Text = FormCaption + (fCaption != null ? (fCaption.Length > 1 ? " [" + fCaption + "]" : "") : "");
            }
            catch (Exception ex)
            {
                this.Text = FormCaption;
            }
        }

        public virtual void FormYeni()
        {
            if (yetki.allowNew)
            {
                FormID = 0;
                SetFormEntity();
                fCaption = string.Empty;
                SetFormCaption();
                FormSaved = false;
            }
        }

        public virtual bool FormKaydet()
        {
            SaveResult result = new();
            try
            {
                if (FormEntity.deleted == false)
                    FormValidator.Validate();
                if (FormValidator.GetInvalidControls().Count == 0)
                {
                    dxFunctions.ShowWaitForm("Kayıt yapılıyor");
                    FormbindingSource.EndEdit();

                    result = EntityKaydet();
                    dxFunctions.CloseWaitForm();
                    if (result.isSuccess)
                        MessageManager.MessageBoxBilgi("Başarılı", "Kayıt işlemi başarıyla tamamlandı", result.errorMessage);
                    else
                        MessageManager.MessageBoxBilgi("Başarısız", "Kayıt işlemi başarısız", result.errorMessage);
                }
            }
            catch (Exception ex)
            {
                dxFunctions.CloseWaitForm();
                MessageManager.MessageBoxHata("Dikkat", "Kayıt işlemi yürütülürken hatalarlar oluştu.", "Hata : " + ex.Message);
            }
            return result.isSuccess;
        }
        public virtual SaveResult EntityKaydet()
        {
            return new SaveResult();
        }
        public virtual void FormSil()
        {
            CanClose = false;
            if (yetki.allowDelete)
            {
                if (FormID > 0)
                    if (MessageManager.MessageBoxOnay("Silme Onayı", "Kaydın silinmesini istediginizden emin misiniz ?", "") == DialogResult.Yes)
                    {
                        FormEntity.deleted = true;
                        FormKaydet();
                    }
            }
            else
                MessageManager.MessageBoxBilgi("Dikkat", "Kayıt Silme yetkiniz bulunamadı", "");
        }
        public virtual void FormAra()
        {
        }
        public virtual void FormIptal()
        {
        }
        public virtual void FormKopya()
        {
            FormID = 0;
            modified = "*";
            FormCaption = "(Kopya)";
            SetFormCaption();
            MessageManager.MessageBoxBilgi("Dikkat", "Kopya Oluşturuldu", "");
        }
        private void FormValidator_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            DevExpress.XtraEditors.BaseEdit edit = e.InvalidControl as DevExpress.XtraEditors.BaseEdit;
            if (edit == null)
                return;

            BaseEditViewInfo viewInfo = edit.GetViewInfo() as BaseEditViewInfo;
            if (viewInfo == null)
                return;

            if (edit.ToolTipController == null)
                edit.ToolTipController = new ToolTipControllerDefault();

            ToolTipControlInfo info = new ToolTipControlInfo(e.InvalidControl, e.ErrorText);
            info.ToolTipPosition = edit.PointToScreen(viewInfo.ErrorIconBounds.Location);

            edit.ToolTipController.InitialDelay = 0;
            edit.ToolTipController.ShowHint(info);
        }

        public void CloseForm()
        {
            FieldInfo fi = typeof(DXValidationProvider).GetField("errorProvider", BindingFlags.NonPublic | BindingFlags.Instance);
            DXErrorProvider errorProvier = fi.GetValue(FormValidator) as DXErrorProvider;

            foreach (Control c in FormValidator.GetInvalidControls())
            {
                errorProvier.SetError(c, null);
            }
            this.Close();
            //new MioUtils(activeUser).CloseForm(this);
        }
        private void BarBtnSelectCard_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormAra();
        }

        private void barBtnPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            BarSubItemLink link = e.Item.Links[0] as BarSubItemLink;
            link.OpenMenu();
        }

        private void BarBtnExtra_ItemClick(object sender, ItemClickEventArgs e)
        {
            BarSubItemLink link = e.Item.Links[0] as BarSubItemLink;
            link.OpenMenu();
        }

        private void BarBtnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormYeni();
        }

        private void BarBtnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormKaydet();
        }

        private void BarBtnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormSil();
        }

        private void BarBtnFind_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormAra();
        }

        private void BarBtnClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            CloseForm();
        }

        private void BarBtnCopy_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormKopya();
        }

        private void barButtonItemLanguage_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void BarBtnInfo_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void BarBtnHistory_ItemClick(object sender, ItemClickEventArgs e)
        {


        }
    }
}

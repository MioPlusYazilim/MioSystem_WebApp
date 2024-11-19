using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors.DXErrorProvider;
using MioSystem.DxUtils;
using MioSystem.Utils;
using Portal.Helpers;
using Portal.Model;
using Portal.Win.Forms.Base;

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

        public NavigationAuthory yetki;

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
            this.yetki = (NavigationAuthory)new ObjectConvert().ToObject(args, "NavigationAuthory");
            FormType = yetki != null ? yetki.formType : 0;
            FormValidator.ValidationMode = ValidationMode.Manual;
            InitializeComponent();
            SetButtonsEnabledState();
            if (loginUser.displayLanguage == "en-EN")
            {
                barButtonItemSave.Caption = "Save";
                barButtonItemSaveAndClose.Caption = "Save&&Close";
                barButtonItemCopy.Caption = "Copy";
                barButtonItemDelete.Caption = "Delete";
                barButtonItemClose.Caption = "Close";
                barButtonItemPrint.Caption = "Print";
                barButtonItemProperties.Caption = "Additional Operations";
            }
        }
        void SetButtonsEnabledState()
        {
            barButtonItemSave.Enabled = yetki.allowEdit;
            barButtonItemSaveAndClose.Enabled = yetki.allowEdit;
            barButtonItemCopy.Enabled = yetki.allowNew;
            barButtonItemDelete.Enabled = yetki.allowDelete;
            barButtonItemPrint.Enabled=yetki.allowPrint;
        }

        public void SetFormResources()
        {
        }
        private void TempEdit_Shown(object sender, EventArgs e)
        {
            //barMainMenu.Visible = menugoster;
            SetFormData();
            SetFormCaption();
            if (yetki != null)
                AddPrintButtons(yetki.authoryID);
            SetCustomButtons();
        }
        public virtual void SetFormData()
        {

        }
        public virtual void AddPrintButtons(int MenuTag)
        {

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

        public void ButonEkleYazdir(BarButtonItem btn)
        {
            btn.AllowGlyphSkinning = DefaultBoolean.False;
            ribbonControl1.Items.Add(btn);
            barButtonItemPrint.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(btn) });
        }

        public void ButonEkleEkislemler(BarButtonItem btn)
        {
            btn.AllowGlyphSkinning = DefaultBoolean.False;
            ribbonControl1.Items.Add(btn);
            barButtonItemProperties.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(btn) });
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
        public virtual bool FormSil()
        {
            var result = false;
            if (yetki.allowDelete)
            {
                if (FormID > 0 && MessageManager.MessageBoxOnay("Silme Onayı", "Kaydın silinmesini istediginizden emin misiniz ?", "") == DialogResult.Yes)
                {
                    FormEntity.deleted = true;
                    if (FormKaydet())
                        result = true;
                }
            }
            else
            {
                MessageManager.MessageBoxBilgi("Dikkat", "Kayıt Silme yetkiniz bulunamadı", "");
            }
            return result;
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

        private void barButtonItemClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (this.DialogResult != DialogResult.OK)
            {
                this.DialogResult = DialogResult.Cancel;
            }
            this.Close();
        }

        private void barButtonItemSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (FormKaydet())
                this.DialogResult = DialogResult.OK;
        }

        private void barButtonItemSaveAndClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (FormKaydet())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void barButtonItemCopy_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormKopya();
        }

        private void barButtonItemDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (FormSil())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}

using DevExpress.XtraGrid.Views.Grid;
using MioSystem.Utils;
using Portal.Data.Services;
using Portal.Helpers;
using Portal.Model;

namespace Portal.Win.Forms
{
    public partial class FrmEmployee : FrmBaseFormEdit
    {
        EmployeeService employeeService;
        public FrmEmployee(object[] args)
            : base(args)
        {
            employeeService = new EmployeeService();
            InitializeComponent();
           
            dxFunctions.EnterMoveNextForAll(this, true);
            SetFormEntity();
            Zorunlualanlar();

            //dxFunctions.SetEditDataSource(GorevLookUpEdit, new GorevlerQueries().GorevlerList().ToList(), "ID", "Kod,Ad", null);
            //dxFunctions.SetEditDataSource(cbModuller, MainDataLayer.modulList.ToList(), "ID", "Kod",  null);
            //dxFunctions.SetEditDataSource(riLookUpEditModulID, MainDataLayer.modulList.ToList(), "ID", "Kod", null);
            //dxFunctions.SetEditDataSource(cbCariKod, MainDataLayer.cariHesapList.ToList(), "ID", "Ad,Kod", "Ad,Kod");
            //dxFunctions.SetEditDataSource(cbDepartman, MainDataLayer.departmanlarList.ToList(), "ID", "Kod,Ad", "Kod,Ad");
        }

        void Zorunlualanlar()
        {
            //try
            //{
            //    KontrolKuralEkle("AdTextEdit", "Personel Adını Giriniz.", DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank, null, null);
            //    KontrolKuralEkle("SoyadTextEdit", "Personel SoyAdını giriniz", DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank, null, null);
            //    KontrolKuralEkle("GorevLookUpEdit", "Göre Tanımını Giriniz", DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank, null, null);
            //    KontrolKuralEkle("cbOffice", "Geçerli Ofis Bilgisini Seçiniz.", DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank, null, null);
            //    KontrolKuralEkle("cbModuller", "Geçerli Modül Bilgisi Giriniz.", DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank, null, null);
            //}
            //catch (Exception ex)
            //{
            //    MessageManager.MessageBoxHata("Hata", "Zorunlu alan kontrol hatası", ex.Message);
            //}
        }

        public override SaveResult EntityKaydet()
        {
            dxFunctions.ShowWaitForm("Form Kaydediliyor...");
            SaveResult result = employeeService.AddOrUpdateEmployee((Employee_Dto)FormEntity);
            dxFunctions.CloseWaitForm();
            if (result.isSuccess)
            {
                FormID = ((Employee_Dto)result.returnValue).id;
            }
            else
            {
                MessageManager.MessageBoxHata("Dikkat", result.errorMessage, "");
            }
            return result;
        }
        public override void SetFormEntity()
        {

            FormEntity = FormID > 0 ? employeeService.GetEmployee(FormID) : new Employee_Dto();
            
            base.SetFormEntity();
            BindingSource phkbs = new BindingSource();
            phkbs.DataSource = ((Employee_Dto)FormEntity).employeeSystemCodes;
            GridPersonelHavaYolu.DataSource = phkbs;

        }

        private void sbresimsec_Click(object sender, EventArgs e)
        {
            //new DxUtils.DxFunctions.InvokeMenuMethod(ResimPictureEdit, "OnClickedLoad");
        }

        private void sbResilSil_Click(object sender, EventArgs e)
        {
            ResimPictureEdit.Image = null;
        }

        private void repositoryItemHyperLinkEditHavayoluDelete_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            EmployeeSystemCode_Dto fRow = (EmployeeSystemCode_Dto)ViewPersonelHavaYolu.GetFocusedRow();
            if (MessageManager.MessageBoxOnay("Dikkat","Kayıt Silinecek","Onaylıyor musunuz?")==DialogResult.Yes)
            {
                if (fRow.id == 0)
                {
                    
                    ((Employee_Dto)FormEntity).employeeSystemCodes.Remove(fRow);
                    ViewPersonelHavaYolu.PostEditor();
                    GridPersonelHavaYolu.RefreshDataSource();
                }
                else
                    fRow.deleted = true;
            }
        }

        private void ViewPersonelHavaYolu_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {

                if (Convert.ToBoolean(View.GetRowCellValue(e.RowHandle, View.Columns["deleted"])))
                {
                    e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Strikeout);
                }
            }
        }
    }
}

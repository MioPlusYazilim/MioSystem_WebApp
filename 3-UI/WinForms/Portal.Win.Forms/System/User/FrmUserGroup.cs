using MioPortal.Model;
using System.Data;

namespace MioPortal.Win.Forms
{
    public partial class FrmUserGroup : BaseForm
    {
        public FrmUserGroup(object[] args)
            : base(args)
        {
            InitializeComponent();
            YetkilerGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(colParentMenuName, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(colMenuName, DevExpress.Data.ColumnSortOrder.Ascending)});
        }

        public override bool EntityKaydet()
        {
            SaveResult result = myworker.SaveChanges();
            if (result.isSuccess)
            {
                FormID = ((RolGrup)FormEntity).ID;
            }
            return result.isSuccess;
        }
        public override void SetFormEntity()
        {
            FormDoluyor = true;
            if (FormID > 0)
                RemoveNonExist(FormID);

            if (FormEntity != null)
                db.Entry((RolGrup)FormEntity).State = System.Data.Entity.EntityState.Detached;

            FormEntity = FormID > 0 ? FormRepo.GetById(FormID) : new RolGrup();

            if (FormID > 0)
                FormRepo.Update((RolGrup)FormEntity);
            else
                FormRepo.Add((RolGrup)FormEntity);

            LoadYetkilist();

            BindingSource bs = new BindingSource();
            bs.DataSource = ((RolGrup)FormEntity).rolGrupYetki;
            YetkilerGridControl.DataSource = bs;
            FormDoluyor = false;
            YetkilerGridView.ExpandAllGroups();

            base.SetFormEntity();
        }
        public override void GetList()
        {
            object[] colFields ={new General.Utils.DataWithName("ID","ID"),
                                new General.Utils.DataWithName("Rol Adı","RolAdi"),
                                new General.Utils.DataWithName("Oluşturma","CreatedOn")};
            _cols = colFields;
            LoadList(new UserQueries().UserRoleGoupList());
        }

        void RemoveNonExist(int RolGrupID)
        {

            List<RolGrupYetki> listToRemove = new List<RolGrupYetki>();
            List<MioMenu> MainYetkiList = new MainDataContext().MioMenu.Where(x => x.MenuLevel == 2 && x.Active == true && x.MenuTag > 0).ToList();

            foreach (var item in new MainDataContext().Set<RolGrupYetki>().Where(x => x.RolGrupID == RolGrupID).ToList())
            {
                if (MainYetkiList.FirstOrDefault(x => x.ID == item.MenuID) == null)
                    listToRemove.Add(item);
            }

            if (listToRemove.Count == 0) return;
            using (MainDataContext dataContext = new MainDataContext())
            {
                List<RolGrupYetki> yetkis = new List<RolGrupYetki>();
                foreach (var item in listToRemove)
                {
                    yetkis.Add(dataContext.Set<RolGrupYetki>().FirstOrDefault(x => x.ID == item.ID));
                }


                dataContext.Set<RolGrupYetki>().RemoveRange(yetkis);
                using (UnitOfWork uow = new UnitOfWork(dataContext))
                    uow.SaveChanges();
            }
        }
        void LoadYetkilist()
        {
            List<MioMenu> MainYetkiList = new MainDataContext().MioMenu.Where(x => x.MenuLevel == 2 && x.Active == true && x.MenuTag > 0).ToList();

            if (((RolGrup)FormEntity).rolGrupYetki.Count > 0)
            {
                foreach (var item in ((RolGrup)FormEntity).rolGrupYetki)
                {
                    MioMenu menuView = MainYetkiList.FirstOrDefault(x => x.ID == item.MenuID);
                    if (menuView != null)
                    {
                        item.MenuTag = Convert.ToInt32(menuView.MenuTag);
                        //item.ParentMenuAdi = menuView.PMenuName;
                        if (menuView.Parent != null)
                            item.ParentMenuAdi = menuView.Parent.MenuName;
                        item.MenuAdi = menuView.FormType == 8 ? menuView.EditFormCaption : menuView.FormCaption;
                    }
                }
            }

            foreach (var uitem in MainYetkiList)
            {
               // if (string.IsNullOrEmpty(uitem.MenuName)) continue;

                if (((RolGrup)FormEntity).rolGrupYetki.FirstOrDefault(x => x.MenuID == uitem.ID) == null)
                {
                    RolGrupYetki rgyetki = new RolGrupYetki();
                    // rgyetki.MenuID = uitem.ID;
                    rgyetki.MenuID = uitem.ID;
                    rgyetki.MenuTag = Convert.ToInt32(uitem.MenuTag);
                    //rgyetki.ParentMenuAdi = uitem.Parent.PMenuName;
                    rgyetki.ParentMenuAdi = uitem.Parent.MenuName;
                    rgyetki.MenuAdi = uitem.FormType == 8 ? uitem.EditFormCaption : uitem.FormCaption;
                    rgyetki.Gorme = false;
                    rgyetki.Yeni = false;
                    rgyetki.Silme = false;
                    rgyetki.Degistirme = false;
                    rgyetki.Yazdirma = false;
                    ((RolGrup)FormEntity).rolGrupYetki.Add(rgyetki);
                }
            }
        }
        void SetReports(RolGrupYetki rowview)
        {
            dxFunctions.SetEditDataSource(ReportsCheckedListBoxControl, new UserReportQueries().ReportFilesViewListMenu(rowview.MenuTag), "ID", "ReportName", null);
            new DxFunctions().SetCheckEditValues(ReportsCheckedListBoxControl, rowview.ReportID);
            ReportsCheckedListBoxControl.Enabled = rowview.Yazdirma;
        }
        private void YetkilerGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            RolGrupYetki rowview = (RolGrupYetki)YetkilerGridView.GetFocusedRow();
            if (rowview != null)
                SetReports(rowview);
        }

        private void ReportsCheckedListBoxControl_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            ((RolGrupYetki)YetkilerGridView.GetFocusedRow()).ReportID = new DxFunctions().GetCheckListStringValue(ReportsCheckedListBoxControl);
        }

        private void repositoryItemCheckEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (FormDoluyor) return;
            YetkilerGridView.PostEditor();
            YetkilerGridView.UpdateCurrentRow();
            RolGrupYetki rowview = (RolGrupYetki)YetkilerGridView.GetFocusedRow();
            ReportsCheckedListBoxControl.Enabled = ((RolGrupYetki)YetkilerGridView.GetFocusedRow()).Yazdirma;
        }

        private void tümYetkileriVerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in ((RolGrup)FormEntity).rolGrupYetki)
                {
                    item.Gorme = true;
                    item.Yeni = true;
                    item.Silme = true;
                    item.Degistirme = true;
                    item.Yazdirma = true;
                    item.ReportID = string.Empty;
                    foreach (var rptitem in new UserReportQueries().ReporFilesList(item.MenuID, 0))
                    {
                        item.ReportID += item.ReportID.Length > 0 ? ";" + rptitem.ID.ToString() : rptitem.ID.ToString();
                    }
                }
                Messages.MessageBoxBilgi("Dikkat", "Tüm yetkiler başarıyla tanımlandı", "");
            }
            catch (Exception ex)
            {
                Messages.MessageBoxHata("Dikkat", "yetki tanımlama sırasında hatalar oluştu", "Hata :" + ex.Message);
            }
            
        }

        private void tümYetkileriKaldırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in ((RolGrup)FormEntity).rolGrupYetki)
                {
                    item.Gorme = false;
                    item.Yeni = false;
                    item.Silme = false;
                    item.Degistirme = false;
                    item.Yazdirma = false;
                    item.ReportID = string.Empty;
                }
                Messages.MessageBoxBilgi("Dikkat", "Tüm yetkiler başarıyla kaldırıldı", "");
            }
            catch (Exception ex)
            {
                Messages.MessageBoxHata("Dikkat", "yetki tanımlama sırasında hatalar oluştu", "Hata :" + ex.Message);
            }
            
        }

        private void YetkilerGridView_CustomColumnSort(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnSortEventArgs e)
        {

        }
    }
}

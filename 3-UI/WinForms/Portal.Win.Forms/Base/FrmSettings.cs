using DevExpress.CodeParser;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraPrinting;
using Portal.Data.Services;
using Portal.Data.Services.GlobalContextService;
using Portal.Helpers;
using Portal.Model;
using Portal.Win.DxUtils;
using Portal.Win.Forms.Base;
using Portal.Win.Utils;
using System.Data;
using System.Reflection;

namespace Portal.Win.Forms
{
    public partial class FrmSettings : FrmAppBaseForm
    {
        string HeaderlabelText = string.Empty;
        DxFunctions dxFunctions;
        LoginResponse loginResponse;
        NavigationRole menuClicked;

        public FrmSettings()
        {
            InitializeComponent();
            dxFunctions = new DxFunctions();
            loginResponse = LoginResponse.GetLoginResponse();
        }

        private void MainFormYeni_Load(object sender, EventArgs e)
        {
            this.Text = loginResponse.companyCode + " Sistem Ayarları";
            MainMenuaccordionControl.Elements.Clear();
            this.ForceRefresh();
        }

        private void barButtonItemSettings_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetMenu(Convert.ToInt32(e.Item.Tag));
            this.Text = e.Item.Caption;
            HeaderlabelControl.Text = "";
            tempGridControl.DataSource = null;
            tempGridView.Columns.Clear();
        }

        public void SetMenu(int modulID)
        {

            MainMenuaccordionControl.Elements.Clear();
            AccordionControlElement ParentGroup;
            AccordionControlElement ChildItem;
            var navigationItems = loginResponse.settingsMenuNavigations.FirstOrDefault(x => x.modulID == modulID);
            if (navigationItems == null) 
                return;
            foreach (var item in navigationItems.items)
            {
                ParentGroup = MainMenuaccordionControl.GetElements().Where(x => x.Style == ElementStyle.Group && Convert.ToInt32(x.Tag) == item.id).FirstOrDefault();
                if (ParentGroup == null)
                {
                    ParentGroup = new AccordionControlElement();
                    ParentGroup.Text = item.menuName;
                    ParentGroup.Tag = item.id;
                    MainMenuaccordionControl.Elements.Add(ParentGroup);
                }
                foreach (var child in item.items)
                {
                    ChildItem = new AccordionControlElement();
                    ChildItem.Text = child.menuName;
                    ChildItem.Tag = child.menuTag;
                    ChildItem.Style = ElementStyle.Item;
                    ChildItem.Click += new EventHandler(accordionControlElement_Click);
                    ParentGroup.Elements.Add(ChildItem);
                }
            }
        }

        private void accordionControlElement_Click(object sender, EventArgs e)
        {
            try
            {
                int MenuID = Convert.ToInt32(((AccordionControlElement)sender).Tag);
                menuClicked = loginResponse.navigationAuthories.FirstOrDefault(x => x.menuTag == MenuID);
                if (menuClicked == null) return;
                RefreshGridDataSource();
            }
            catch (Exception ex)
            {
                MessageManager.MessageBoxHata("Dikkat", new GlobalContextService().GetSystemMessageValue("FormProcessError").ToString(), ex.Message);
            }
        }


        private void tempGridView_DoubleClick(object sender, EventArgs e)
        {

            dxFunctions.ShowWaitForm("");
            try
            {
                GridView view = sender as GridView;
                GridHitInfo hitInfo = view.CalcHitInfo((e as MouseEventArgs).Location);
                if (hitInfo.InRowCell)
                {
                    int rowHandle = view.FocusedRowHandle;
                    if (view.IsDataRow(rowHandle))
                    {
                        int FormID = Convert.ToInt32(view.GetRowCellValue(view.FocusedRowHandle, "id"));
                        OpenEditForm(FormID);
                    }
                }
            }
            catch (Exception ex)
            {
            }
            dxFunctions.CloseWaitForm();
        }


        void OpenEditForm(int FormID)
        {
            if (menuClicked == null)
                return;

            object[] args = { new CustomDataObject("FormID", FormID),
                              new CustomDataObject("MenuID", menuClicked.menuTag),
                              new CustomDataObject("FormType", menuClicked.formType),
                              new CustomDataObject("NavigationAuthory",menuClicked)};

            if (menuClicked.menuTag > 0)
            {
                Type tForm = new CheckForm().GetFormTypeFromDll(menuClicked.editFormName);
                if (tForm != null)
                {
                    FrmAppBaseFormEdit baseForm = new CheckForm().OpenForm<FrmAppBaseFormEdit>(args);
                    if (baseForm.ShowDialog() == DialogResult.OK)
                    {
                        RefreshGridDataSource();
                    }

                }
            }
        }

        public void RefreshGridDataSource()
        {
            if (menuClicked == null)
                return;

            tempGridView.Columns.Clear();
            tempGridControl.DataSource = null;

            BindingSource source = new BindingSource();
            string[] listparams = (menuClicked.listMethodName ?? "").Split('.');

            var assembly = AppDomain.CurrentDomain.GetAssemblies().FirstOrDefault(a => a.FullName.StartsWith("Portal.Data.Services"));
            if (assembly == null) return;

            Type service = assembly.GetType("Portal.Data.Services." + listparams[0]);
            if (service == null) return;

            MethodInfo method = service.GetMethod(listparams[1]);
            if (method == null) return;

            source.DataSource = method.Invoke(Activator.CreateInstance(service), null);

            tempGridControl.DataSource = source;
            dxFunctions.SetGrid(tempGridView, false);
            tempGridControl.RefreshDataSource();
        }


        private void BarBtnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (panelControlFormContainer.Controls.Count == 0) return;
            //((FrmBaseFormEdit)panelControlFormContainer.Controls[0]).FormYeni();
            //xtraTabControlForms.SelectedTabPage = xtraTabPageEditForm;
            //setBarButtons(true, ((FrmBaseFormEdit)panelControlFormContainer.Controls[0]).yetki);
        }

        private void BarBtnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (panelControlFormContainer.Controls.Count == 0) return;
            //var baseForm = (FrmBaseFormEdit)panelControlFormContainer.Controls[0];
            //baseForm.FormSil();
            //baseForm.GetList();
            //RefreshGridDataSource(baseForm);
            //xtraTabControlForms.SelectedTabPage = xtraTabPageList;
        }




        private void barButtonItemRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (panelControlFormContainer.Controls.Count > 0)
            //{
            //    FrmBaseFormEdit baseForm = (FrmBaseFormEdit)panelControlFormContainer.Controls[0];
            //    baseForm.GetList();
            //    RefreshGridDataSource(baseForm);
            //}
        }
        private void BarBtnCopy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (panelControlFormContainer.Controls.Count == 0) return;
            //((FrmBaseFormEdit)panelControlFormContainer.Controls[0]).FormKopya();
            //HeaderlabelControl.Text = HeaderlabelText + " (KOPYA)";
        }

        private void barButtonItemPrintList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (PrintingSystem ps = new PrintingSystem())
            {
                using (PrintableComponentLink link = new PrintableComponentLink(ps))
                {
                    link.Component = tempGridControl;
                    link.CreateDocument();
                    ps.PreviewFormEx.WindowState = FormWindowState.Maximized;
                    ps.PreviewFormEx.ShowDialog();
                }
            }
        }

        private void barButtonItemClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        
    }
}

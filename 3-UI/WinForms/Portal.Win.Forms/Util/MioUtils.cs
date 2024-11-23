using DevExpress.Data.Linq;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using Portal.Model;
using Portal.Helpers;

namespace Portal.Win.Forms
{
    public class MioUtils :IDisposable
    {
        public MioUtils()
        {
        }

        public void SetGridDataSource(GridControl MyGrid, IQueryable Src)
        {
            LinqServerModeSource linqSrc = new LinqServerModeSource();
            linqSrc.QueryableSource = Src;
            MyGrid.DataSource = linqSrc;
        }

        public void ActivateMyForm(object[] args)
        {
            bool FromMainList = new ObjectConvert().ToBoolean(args, "FromMainList");
            if (FromMainList)
                ActivateFromMainlist(args);
            else
                ActivateFormFromMenu(args);
        }

        void ActivateFormFromMenu(object[] args)
        {
            try
            {
                int FormID = new ObjectConvert().ToInt32(args, "FormID");
                int FormType = new ObjectConvert().ToInt32(args, "FormType");
                NavigationAuthory_Model MyYetki = (NavigationAuthory_Model)new ObjectConvert().ToObject(args, "NavigationAuthory");
                string EditFormName = MyYetki.editFormName;
                string ListFormName = MyYetki.listFormName;

                CheckForm checkForm = new CheckForm();
                bool FormExist = false;
                foreach (Form OpenForm in Application.OpenForms)
                {
                    if (OpenForm is XtraForm)
                    {
                        switch (FormType)
                        {
                            case 2:
                                if ((OpenForm.GetType() == checkForm.GetFormTypeFromDll(EditFormName)) && ((FrmBaseFormEdit)OpenForm).FormID == FormID && ((FrmBaseFormEdit)OpenForm).yetki.menuCardType == MyYetki.menuCardType)
                                {
                                    OpenForm.BringToFront();
                                    FormExist = true;
                                }
                                break;
                            //case 3:
                            //    if ((OpenForm.GetType() == checkForm.GetFormTypeFromDll(ListFormName)) && ((TempList)OpenForm).FormID == FormID && ((TempList)OpenForm).yetki.menuCardType == MyYetki.menuCardType)
                            //    {
                            //        OpenForm.BringToFront();
                            //        FormExist = true;
                            //    }
                            //    break;
                            //case 5:
                            //    if ((OpenForm.GetType() == checkForm.GetFormTypeFromDll(EditFormName)) && ((TempReportDoc)OpenForm).FormID == FormID && ((TempReportDoc)OpenForm).yetki.menuCardType == MyYetki.menuCardType)
                            //    {
                            //        OpenForm.BringToFront();
                            //        FormExist = true;
                            //    }
                            //    break;
                            //case 6:
                            //    if ((OpenForm.GetType() == checkForm.GetFormTypeFromDll(EditFormName)) && ((TempReportTable)OpenForm).FormID == FormID && ((TempReportTable)OpenForm).yetki.menuCardType == MyYetki.menuCardType)
                            //    {
                            //        OpenForm.BringToFront();
                            //        FormExist = true;
                            //    }
                            //    break;
                            //case 7:
                            //    if ((OpenForm.GetType() == checkForm.GetFormTypeFromDll(EditFormName)) && ((TempFreeForm)OpenForm).FormID == FormID && ((TempFreeForm)OpenForm).yetki.menuCardType == MyYetki.menuCardType)
                            //    {
                            //        OpenForm.BringToFront();
                            //        FormExist = true;
                            //    }
                            //    break;
                            //case 8:
                            //    if ((OpenForm.GetType() == checkForm.GetFormTypeFromDll(ListFormName)) && ((frm)OpenForm).FormID == MyYetki.menuCardType && ((FrmAppBaseFormModul)OpenForm).yetki.menuCardType == MyYetki.menuCardType)
                            //    {
                            //        OpenForm.BringToFront();
                            //        FormExist = true;
                            //    }
                            //    break;
                            //case 9:
                            //    if ((OpenForm.GetType() == checkForm.GetFormTypeFromDll(EditFormName)) && ((TempReportPivot)OpenForm).FormID == FormID && ((TempReportPivot)OpenForm).yetki.menuCardType == MyYetki.menuCardType)
                            //    {
                            //        OpenForm.BringToFront();
                            //        FormExist = true;
                            //    }
                            //    break;
                        }
                    }
                    if (FormExist)
                        break;
                }
                if (!FormExist)
                {
                    XtraForm myform = null;
                    switch (FormType)
                    {
                        case 2://BaseForm Form
                            myform = new CheckForm().OpenForm<FrmBaseFormEdit>(args);
                            ((FrmBaseFormEdit)myform).SetFormResources();
                            break;
                        //case 3: //ListForm(Main)
                        //    myform = new CheckForm().OpenForm<TempList>(args);
                        //    ((TempList)myform).SetFormResources();
                        //    break;
                        //case 5: //ReportForm
                        //    myform = new CheckForm().OpenForm<TempReportDoc>(args);
                        //    ((TempReportDoc)myform).SetFormResources();
                        //    break;
                        //case 6: //ReportOzel
                        //    myform = new CheckForm().OpenForm<TempReportTable>(args);
                        //    ((TempReportTable)myform).SetFormResources();
                        //    break;
                        //case 7: //FreeForm
                        //    myform = new CheckForm().OpenForm<TempFreeForm>(args);
                        //    ((TempFreeForm)myform).SetFormResources();
                        //    break;
                        //case 8: //TempMaiList
                        //    myform = new CheckForm().OpenForm<FrmAppBaseFormModul>(args);
                        //    ((FrmAppBaseFormModul)myform).SetFormResources();
                        //    break;
                        //case 9: //ReportPivot
                        //    myform = new CheckForm().OpenForm<TempReportPivot>(args);
                        //    ((TempReportPivot)myform).SetFormResources();
                        //    break;
                    }

                    myform.MdiParent = Application.OpenForms[0];
                    myform.Show();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        void ActivateFromMainlist(object[] args)
        {
            try
            {
                int FormID = new ObjectConvert().ToInt32(args, "FormID");
                int FormType = new ObjectConvert().ToInt32(args, "FormType");
                NavigationAuthory_Model MyYetki = (NavigationAuthory_Model)new ObjectConvert().ToObject(args, "NavigationAuthory");
                string EditFormName = MyYetki.editFormName;
                string ListFormName = MyYetki.listFormName;
                string FormCaption = MyYetki.editFormCaption;
                using (CheckForm checkForm = new CheckForm())
                {
                    bool FormExist = false;
                    foreach (Form OpenForm in Application.OpenForms)
                    {
                        if (OpenForm is XtraForm)
                        {
                            switch (FormType)
                            {
                                case 2:
                                case 8:
                                    if ((OpenForm.GetType() == checkForm.GetFormTypeFromDll(EditFormName)) && ((FrmBaseFormEdit)OpenForm).FormID == FormID && ((FrmBaseFormEdit)OpenForm).yetki.menuCardType == MyYetki.menuCardType)
                                    {
                                        OpenForm.BringToFront();
                                        FormExist = true;
                                    }
                                    break;
                                //case 7:
                                //    if ((OpenForm.GetType() == checkForm.GetFormTypeFromDll(EditFormName)) && ((TempFreeForm)OpenForm).FormID == FormID && ((TempFreeForm)OpenForm).yetki.menuCardType == MyYetki.menuCardType)
                                //    {
                                //        OpenForm.BringToFront();
                                //        FormExist = true;
                                //    }
                                //    break;
                            }
                        }
                        if (FormExist)
                            break;
                    }
                    if (!FormExist)
                    {
                        XtraForm myform = null;
                        switch (MyYetki.formType)
                        {
                            case 2://BaseForm Form
                            case 8:
                                myform = new CheckForm().OpenForm<FrmBaseFormEdit>(args);
                                ((FrmBaseFormEdit)myform).SetFormResources();
                                break;
                            //case 7: //FreeForm
                            //    myform = new CheckForm().OpenForm<TempFreeForm>(args);
                            //    ((TempFreeForm)myform).SetFormResources();
                            //    break;
                        }
                        myform.MdiParent = Application.OpenForms[0];
                        myform.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}

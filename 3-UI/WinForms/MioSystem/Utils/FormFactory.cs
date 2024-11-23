using DevExpress.DataAccess.Native.Sql.QueryBuilder;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using MioSystem.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MioSystem.Utils
{
    public static class FormFactory
    {
        public static Type GetFormType(string AssebmlyName, string FormName)
        {
            Type tForm = null;
            foreach (Assembly currentassembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                tForm = currentassembly.GetType(AssebmlyName + FormName);
                if (tForm != null)
                {
                    break;
                }
            }
            return tForm;
        }

        public static void CreateOrActivateListForm(DocumentManager documentManager, BaseFormSettings formSettings, int FormTypeID)
        {
            if (!CheckForm(documentManager, formSettings, false))
            {
                string TypeName = FormTypeID < 3 ? "FrmMainList" : FormTypeID == 3 ? "FrmDocReport" : FormTypeID == 3 ? "FrmTableReport" : FormTypeID == 3 ? "FrmPivotReport" : "";
                var control = (FrmBaseUserControl)Activator.CreateInstance(GetFormType("MioSystem.Base.", TypeName), formSettings);
                control.Name = formSettings.FormPermissions.editFormName + DateTime.Now.Ticks.ToString();
                control.AppDocumentManager = documentManager;
                documentManager.View.AddDocument(control);
            }
        }
        
        public static void CreateOrActivateEditForm(DocumentManager documentManager, BaseFormSettings formSettings)
        {
            if (!CheckForm(documentManager, formSettings,true))
            {
                var control = (FrmBaseEditForm)Activator.CreateInstance(GetFormType("MioSystem.UI.", formSettings.FormPermissions.editFormName), new BaseFormSettings()
                {
                    FormAuthoryID = formSettings.FormAuthoryID,
                    FormID = formSettings.FormID,
                    FormModulID = formSettings.FormModulID,
                    
                });
                control.Name = formSettings.FormPermissions.editFormName + DateTime.Now.Ticks.ToString();
                control.AppDocumentManager = documentManager;
                documentManager.View.AddDocument(control);
            }
        }
        public static FrmBaseEditForm CreateEditForm(BaseFormSettings formSettings, int _formID)
        {
            var control = (FrmBaseEditForm)Activator.CreateInstance(GetFormType("MioSystem.UI.", formSettings.FormPermissions.editFormName), new BaseFormSettings()
            {
                FormAuthoryID = formSettings.FormAuthoryID,
                FormID = _formID,
                FormModulID = formSettings.FormModulID
            });
            return control;
        }

        public static bool CheckForm(DocumentManager documentManager, BaseFormSettings formSettings, bool IsEditForm)
        {
            FrmBaseUserControl control = null;
            foreach (var doc in documentManager.View.Documents)
            {
                Type ftype = doc.Control.GetType();
                if (IsEditForm)
                {
                    if (ftype.BaseType == typeof(FrmBaseEditForm))
                    {
                        control = (FrmBaseUserControl)doc.Control;
                        if (control != null && control.formSettings.FormAuthoryID == formSettings.FormAuthoryID && control.formSettings.FormID == formSettings.FormID && control.formSettings.FormModulID == formSettings.FormModulID)
                        {
                            documentManager.View.ActivateDocument(control);
                            return true;
                        }
                    }

                }
                else
                {
                    if (ftype == typeof(FrmMainList) || ftype == typeof(FrmTableReport) || ftype == typeof(FrmPivotReport) || ftype == typeof(FrmDocReport))
                    {
                        control = (FrmBaseUserControl)doc.Control;
                        if (control != null && control.formSettings.FormAuthoryID == formSettings.FormAuthoryID && control.formSettings.FormID == formSettings.FormID && control.formSettings.FormModulID == formSettings.FormModulID)
                        {
                            documentManager.View.ActivateDocument(control);
                            return true;
                        }
                    }
                }
            }
            
            return false;
        }
        public static void SetFormCaption(DocumentManager documentManager, string _controlName , string _caption)
        {
            foreach (var doc in documentManager.View.Documents)
            {
                if (doc.Control.Name == _controlName)
                {
                    doc.Caption = _caption;
                    break;
                }
            }
        }
    }
}

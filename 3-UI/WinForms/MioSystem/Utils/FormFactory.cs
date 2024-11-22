using DevExpress.DataAccess.Native.Sql.QueryBuilder;
using DevExpress.XtraBars.Docking2010;
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
        public static Type GetFormType(string FormName)
        {
            Type tForm = null;
            foreach (Assembly currentassembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                tForm = currentassembly.GetType("MioSystem.UI." + FormName);
                if (tForm != null)
                {
                    break;
                }
            }
            return tForm;
        }
        public static void CreateEditForm(DocumentManager documentManager, BaseFormSettings formSettings,int _formID)
        {
            if (!CheckForm(documentManager, formSettings, _formID))
            {
                var control = (FrmBaseEditForm)Activator.CreateInstance(GetFormType(formSettings.FormPermissions.editFormName), new BaseFormSettings()
                {
                    FormAuthoryID = formSettings.FormAuthoryID,
                    FormID = _formID,
                    FormModulID = formSettings.FormModulID,
                });
                control.AppDocumentManager = documentManager;
                documentManager.View.AddDocument(control);
                documentManager.View.ActivateDocument(control);
                control.InitCaption("");
            }
        }
        public static FrmBaseEditForm CreateEditForm(BaseFormSettings formSettings, int _formID)
        {
            var control = (FrmBaseEditForm)Activator.CreateInstance(GetFormType(formSettings.FormPermissions.editFormName), new BaseFormSettings()
            {
                FormAuthoryID = formSettings.FormAuthoryID,
                FormID = _formID,
                FormModulID = formSettings.FormModulID
            });
            return control;
        }

        public static bool CheckForm(DocumentManager documentManager,BaseFormSettings formSettings,int _formID)
        {
            foreach (var doc in documentManager.View.Documents)
            {
                var control = (FrmBaseUserControl)doc.Control;
                if (control.formSettings.FormAuthoryID == formSettings.FormAuthoryID && control.formSettings.FormID ==_formID && control.formSettings.FormModulID == formSettings.FormModulID)
                {
                    documentManager.View.ActivateDocument(control);
                    return true;
                }
            }
            return false;
        }
    }
}

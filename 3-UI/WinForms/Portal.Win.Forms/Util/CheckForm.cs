using DevExpress.XtraEditors;
using MioSystem.Utils;
using Portal.Data.Services.GlobalContextService;
using Portal.Helpers;
using Portal.Model;
using System.Reflection;

namespace Portal.Win.Forms
{
    public class CheckForm:IDisposable
    {
        public Type GetFormTypeFromDll(string FormName)
        {
            Type tForm = null;
            foreach (Assembly currentassembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                tForm = currentassembly.GetType("Portal.Win.Forms." + FormName);
                if (tForm != null)
                {
                    break;
                }
            }
            return tForm;
        }
        public XtraForm IsFormOpenEx(string FormName, int FormID)
        {
            foreach (Form OpenForm in Application.OpenForms)
            {
                if (OpenForm is XtraForm)
                {
                    if ((OpenForm.GetType() == GetFormTypeFromDll(FormName)) && Convert.ToInt32(OpenForm.Tag) == FormID)
                        return (XtraForm)OpenForm;
                }
            }
            return null;
        }
        public Form IsFormOpen(string FormName, int FormID)
        {
            foreach (Form OpenForm in Application.OpenForms)
            {

                if ((OpenForm.GetType() == GetFormTypeFromDll(FormName)) && OpenForm.Tag.ToString() == Convert.ToString(FormID))
                    return OpenForm;
            }
            return null;
        }

        public T OpenForm<T>(object[] args)
        {
            try
            {
                NavigationAuthory_Model yetki = (NavigationAuthory_Model)new ObjectConvert().ToObject(args, "NavigationAuthory");
                return (T)Activator.CreateInstance(GetFormTypeFromDll(yetki.editFormName), (object)args);
            }
            catch (Exception ex)
            {
                MessageManager.MessageBoxHata("Dikkat", new GlobalContextService().GetSystemMessageValue(3).ToString(), ex.Message);
                return default;
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        //public BaseForm OpenBaseForm(object[] args)
        //{
        //    try
        //    {
        //        NavigationAuthory yetki = (NavigationAuthory)new ObjectConvert().ToObject(args, "NavigationAuthory");
        //        return (BaseForm)Activator.CreateInstance(GetFormTypeFromDll(yetki.editFormName), (object)args);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageManager.MessageBoxHata("Dikkat", "Form açılırken hatalar oluştu", ex.Message);
        //        return null;
        //    }
        //}

        //public TempEdit OpenTempForm(object[] args)
        //{
        //    try
        //    {
        //        MenuYetki yetki = (NavigationAuthory)new ObjectConvert().ToObject(args, "MenuYetki");
        //        return (TempEdit)Activator.CreateInstance(GetFormTypeFromDll(yetki.EditFormName), (object)args);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageManager.MessageBoxHata("Dikkat", "Form açılırken hatalar oluştu", ex.Message);
        //        return null;
        //    }
        //}
        //public TempList OpenListForm(object[] args)
        //{
        //    try
        //    {
        //        MenuYetki yetki = (MenuYetki)new ObjectConvert().ToObject(args, "MenuYetki");
        //        return (TempList)Activator.CreateInstance(GetFormTypeFromDll(yetki.ListFormName), (object)args);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageManager.MessageBoxHata("Dikkat", "Form açılırken hatalar oluştu", ex.Message);
        //        return null;
        //    }
        //}
        //public TempMainList OpenMainListForm(object[] args)
        //{
        //    try
        //    {
        //        MenuYetki yetki = (MenuYetki)new ObjectConvert().ToObject(args, "MenuYetki");
        //        return (TempMainList)Activator.CreateInstance(GetFormTypeFromDll(yetki.ListFormName), (object)args);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageManager.MessageBoxHata("Dikkat", "Form açılırken hatalar oluştu", ex.Message);
        //        return null;
        //    }
        //}
        //public TempReportDoc OpenReportFormDoc(object[] args)
        //{
        //    try
        //    {
        //        MenuYetki yetki = (MenuYetki)new ObjectConvert().ToObject(args, "MenuYetki");
        //        return (TempReportDoc)Activator.CreateInstance(GetFormTypeFromDll(yetki.EditFormName), (object)args);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageManager.MessageBoxHata("Dikkat", "Form açılırken hatalar oluştu", ex.Message);
        //        return null;
        //    }
        //}
        //public TempReportTable OpenReportFormTable(object[] args)
        //{
        //    try
        //    {
        //        MenuYetki yetki = (MenuYetki)new ObjectConvert().ToObject(args, "MenuYetki");
        //        return (TempReportTable)Activator.CreateInstance(GetFormTypeFromDll(yetki.EditFormName), (object)args);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageManager.MessageBoxHata("Dikkat", "Form açılırken hatalar oluştu", ex.Message);
        //        return null;
        //    }
        //}
        //public TempReportPivot OpenReportFormPivot(object[] args)
        //{
        //    try
        //    {
        //        MenuYetki yetki = (MenuYetki)new ObjectConvert().ToObject(args, "MenuYetki");
        //        return (TempReportPivot)Activator.CreateInstance(GetFormTypeFromDll(yetki.EditFormName), (object)args);
        //    }
        //    catch (Exception ex)
        //    {
        //        Messages.MessageBoxHata("Dikkat", "Form açılırken hatalar oluştu", ex.Message);
        //        return null;
        //    }
        //}
        //public TempFreeForm OpenFreeForm(object[] args)
        //{
        //    try
        //    {
        //        MenuYetki yetki = (MenuYetki)new ObjectConvert().ToObject(args, "MenuYetki");
        //        return (TempFreeForm)Activator.CreateInstance(GetFormTypeFromDll(yetki.EditFormName), (object)args);
        //    }
        //    catch (Exception ex)
        //    {
        //        Messages.MessageBoxHata("Dikkat", "Form açılırken hatalar oluştu", ex.Message);
        //        return null;
        //    }
        //}
    }
}

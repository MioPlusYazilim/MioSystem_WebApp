using DevExpress.Skins;
using DevExpress.UserSkins;
using MioSystem.Utils;
using Portal.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace MioSystem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("tr-TR");
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("tr-TR");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);


            var strProcessName = Process.GetCurrentProcess().ProcessName;
            var Oprocesses = Process.GetProcessesByName(strProcessName);
            //var language = Properties.Settings.Default.Language;

            if (Oprocesses.Length > 10)
            {
                MessageManager.MessageBoxBilgi("Dikkat", "Program zaten çalışıyor", string.Empty);
            }
            else
            {
                string portalConnStr = "6YbhCkHgaA6iIX7siwNoIsd72itGbIusYRdHQasXdjTrFTSV4PUMmkgMbb4JtMfN+kLT4GsgFWHGTVHnyLZ1/S9d0TZDftMlFiWnNLner1Wk5pW8lkAc00dAxqXqlBKNZ4RocThIXhcNZ+nIJjlE+GPJKF+OYn9j/AAaE8If0uwnU0H0kXwz4BPywiWvW/9MkucAqUqKmQs=";
                var loginUser = Login.GetLoginUser();
                loginUser.globalKey = portalConnStr;

                //DevExpress.Skins.SkinManager.EnableFormSkins();
                //DevExpress.Skins.SkinManager.EnableMdiFormSkins();
                //DevExpress.UserSkins.BonusSkins.Register();

                string versiyonNumber = string.Empty;
                //Version myVersion = null;
                //if (ApplicationDeployment.IsNetworkDeployed)
                //{
                //    myVersion = ApplicationDeployment.CurrentDeployment.CurrentVersion;
                //    versiyonNumber = myVersion.Major.ToString() + "." + myVersion.Minor.ToString() + "." + myVersion.Build.ToString() + "." + myVersion.Revision.ToString();

                //}
                //else
                //{
                //    versiyonNumber = Assembly.GetExecutingAssembly().GetName().Version.ToString();
                //}
                //string[] versiyon = versiyonNumber.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
                //versiyonNumber = versiyon[0] + "." + versiyon[1].PadLeft(2, '0') + "." + versiyon[2].PadLeft(2, '0') + "." + versiyon[3].PadLeft(2, '0');


                using (FrmLogin frmLogin = new())
                {
                    if (frmLogin.ShowDialog() == DialogResult.OK)
                    {
                        //    using (SQLHelper helper = new SQLHelper())
                        //    {
                        //        /*bu parametre sadece güncellemelerde kullanılıcak*/
                        //        if (helper.CheckIsSystemUpdate(activeUser.ConnStr, activeUser.VersionNumber) == false)
                        //        {
                        //            try
                        //            {
                        //                helper.SetForAutoUpdate(activeUser.ConnStr, File.ReadAllText(Application.StartupPath + "\\SQLUpdates\\TableUpdates.Sql"), activeUser.VersionNumber);
                        //                helper.SetForAutoUpdate(activeUser.ConnStr, File.ReadAllText(Application.StartupPath + "\\SQLUpdates\\TriggerUpdates.Sql"), activeUser.VersionNumber);
                        //                helper.SetForAutoUpdate(activeUser.ConnStr, File.ReadAllText(Application.StartupPath + "\\SQLUpdates\\WiewUpdates.Sql"), activeUser.VersionNumber);
                        //                helper.SetForAutoUpdate(activeUser.ConnStr, File.ReadAllText(Application.StartupPath + "\\SQLUpdates\\StoredProcUpdates.Sql"), activeUser.VersionNumber);

                        //                helper.SetSystemUpdate(activeUser.ConnStr, activeUser.VersionNumber);
                        //            }
                        //            catch (Exception ex)
                        //            {
                        //                MessageBox.Show(ex.Message);
                        //                return;
                        //            }
                        //        }
                        //    }

                        //    using (FrmDataLayerLoad loader = new FrmDataLayerLoad(activeUser))
                        //        loader.ShowDialog();
                        Application.Run(new FrmMainForm());
                    }
                }
            }
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception ex = (Exception)e.ExceptionObject;
            MessageBox.Show(ex.Message);
        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.ToString());
        }
    }
}
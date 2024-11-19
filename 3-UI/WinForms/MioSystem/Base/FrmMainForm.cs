using DevExpress.DataAccess.Native.Sql.QueryBuilder;
using DevExpress.Utils.Extensions;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using MioSystem.Base;
using Portal.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MioSystem
{
    public partial class FrmMainForm : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        Login loginUser = Login.GetLoginUser();
        public FrmMainForm()
        {
            InitializeComponent();
        }

        private void FrmMainForm_Load(object sender, EventArgs e)
        {
            SetAccoudionMenu();
        }
        void SetAccoudionMenu()
        {
            MainMenuAccordionControl.Elements.Clear();
            foreach (var ParentGroup in loginUser.mainMenu)
            {
                //Moduller
                var PGrp = new AccordionControlElement()
                {
                    Style = DevExpress.XtraBars.Navigation.ElementStyle.Group,
                    Name = ParentGroup.menuName,
                    Expanded = false,
                    Text = ParentGroup.menuName,
                    Tag = ParentGroup.id,
                };
                switch (ParentGroup.modulID)
                {
                    case 2:
                        PGrp.ImageOptions.SvgImage = Properties.Resources.turkish_lira_sign;
                        break;
                    case 3:
                        PGrp.ImageOptions.SvgImage = Properties.Resources.passport;
                        break;
                    case 4:
                        PGrp.ImageOptions.SvgImage = Properties.Resources.Airplane;
                        break;
                    case 5:
                        PGrp.ImageOptions.SvgImage = Properties.Resources.ship;
                        break;
                    case 6:
                        PGrp.ImageOptions.SvgImage = Properties.Resources.Bus;
                        break;
                    case 7:
                        PGrp.ImageOptions.SvgImage = Properties.Resources.bed;
                        break;
                    case 8:
                        PGrp.ImageOptions.SvgImage = Properties.Resources.taxi_bus;
                        break;
                    case 9:
                        PGrp.ImageOptions.SvgImage = Properties.Resources.Car;
                        break;
                }

                //ALt Grup
                MainMenuAccordionControl.Elements.Add(PGrp);
                foreach (var ChildGroup in ParentGroup.items)
                {
                    var CGrp = new AccordionControlElement()
                    {
                        Style = ChildGroup.menuType == 3 ? DevExpress.XtraBars.Navigation.ElementStyle.Item : DevExpress.XtraBars.Navigation.ElementStyle.Group,
                        Name = ChildGroup.menuName,
                        Expanded = false,
                        Text = ChildGroup.menuName,
                        Tag = ChildGroup.id,
                    };
                    if (ChildGroup.menuType == 3)
                        CGrp.Click += AccordionControlElement_Click;
                    PGrp.Elements.Add(CGrp);
                    foreach (var Items in ChildGroup.items)
                    {
                        // işlemler
                        var Itm = new AccordionControlElement()
                        {
                            Style = DevExpress.XtraBars.Navigation.ElementStyle.Item,
                            Name = Items.menuName,
                            Expanded = false,
                            Text = Items.menuName,
                            Tag = Items.id,
                        };
                        Itm.Click += AccordionControlElement_Click;
                        CGrp.Elements.Add(Itm);
                    }
                }

                var SGrp = new AccordionControlElement()
                {
                    Style = DevExpress.XtraBars.Navigation.ElementStyle.Group,
                    Name = ParentGroup.menuName + "Settings",
                    Expanded = false,
                    Text = "Tanımlar",
                    Tag = ParentGroup.id,
                };
                PGrp.Elements.Add(SGrp);
                foreach (var SettingsItem in loginUser.settingsMenu.Where(x => x.modulID == ParentGroup.modulID))
                {
                    var scount = 0;
                    foreach (var sItem in SettingsItem.items)
                    {
                        scount++;
                        foreach (var item in sItem.items)
                        {
                            var Itm = new AccordionControlElement()
                            {
                                Style = DevExpress.XtraBars.Navigation.ElementStyle.Item,
                                Name = item.menuName,
                                Expanded = false,
                                Text = item.menuName,
                                Tag = item.id,
                            };
                            Itm.Click += AccordionControlElement_Click;
                            SGrp.Elements.Add(Itm);
                        }
                        if (scount < SettingsItem.items.Count)
                            SGrp.Elements.Add(new AccordionControlSeparator());
                    }

                }
            }
        }

        private async void AccordionControlElement_Click(object sender, EventArgs e)
        {
            var element = (AccordionControlElement)sender;
            if (element != null)
            {
                var navAuth = loginUser.authories.FirstOrDefault(x => x.id == Convert.ToInt32(element.Tag));
                if (navAuth != null)
                {
                    switch (navAuth.formType)
                    {
                        case 1:
                        case 2:
                            await OpenMainList(navAuth);
                            break;
                        case 3:
                        case 4:
                        case 5:
                            await OpenSingleForm(navAuth);
                            break;
                        case 6:
                            await OpenSingleForm(navAuth);
                            break;
                    }
                }
            }
        }

        async Task OpenMainList(NavigationAuthory navAuth)
        {
            await Task.Factory.StartNew(() =>
            {
                var listName = navAuth.menuName + "_" + navAuth.modulID + "_" + navAuth.formType;
                if (!fluentDesignFormContainer1.Controls.ContainsKey(listName))
                {
                    FrmMainList mainList = new();
                    mainList.Text = navAuth.listFormCaption;
                    mainList.Name = listName;
                    mainList.Dock = DockStyle.Fill;
                    fluentDesignFormContainer1.Invoke(new MethodInvoker(delegate ()
                    {
                        fluentDesignFormContainer1.Controls.Add(mainList);

                        mainList.BringToFront();

                    }));
                }
                else
                {
                    var control = fluentDesignFormContainer1.Controls.Find(listName, true);
                    if (control.Length == 1)
                    {
                        fluentDesignFormContainer1.Invoke(new MethodInvoker(delegate ()
                        {
                            barStaticItemNavigation.Caption = control[0].Text;
                            control[0].BringToFront();
                        }));
                    }
                }
            });
        }
        async Task OpenReportForm(NavigationAuthory navAuth)
        {

        }
        async Task OpenSingleForm(NavigationAuthory navAuth)
        {

        }

        private void ModuleItm_Click(object sender, EventArgs e)
        {
            var menuitem = ((AccordionControlElement)sender);

            var control = fluentDesignFormContainer1.Controls.Find(menuitem.Name, true);
            if (control.Length == 1)
            {
                fluentDesignFormContainer1.Invoke(new MethodInvoker(delegate ()
                {
                    barStaticItemNavigation.Caption = control[0].Text;
                    control[0].BringToFront();
                }));
            }
        }

        private void fluentDesignFormContainer1_ControlAdded(object sender, ControlEventArgs e)
        {
            var control = e.Control;
            var ModuleItm = new AccordionControlElement()
            {
                Style = DevExpress.XtraBars.Navigation.ElementStyle.Item,
                Name = control.Name,
                Text = control.Text
            };
            ModuleItm.Click += ModuleItm_Click; ;
            accordionControlOpenedModules.Elements.Add(ModuleItm);
            barStaticItemNavigation.Caption = ModuleItm.Name;
        }

        private void fluentDesignFormContainer1_ControlRemoved(object sender, ControlEventArgs e)
        {
            var control = e.Control;
            var ModuleItm = accordionControlOpenedModules.Elements.FirstOrDefault(x => x.Name == control.Name && x.Text == control.Text);

            if (ModuleItm != null)
            {
                accordionControlOpenedModules.Elements.Remove(ModuleItm);
            }
            if(fluentDesignFormContainer1.Controls.Count > 0)
            {
                control = fluentDesignFormContainer1.TopLevelControl;
                barStaticItemNavigation.Caption = control.Text;
            }
            
        }
    }
}

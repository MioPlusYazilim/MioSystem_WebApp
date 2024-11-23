using DevExpress.DataAccess.Native.Sql.QueryBuilder;
using DevExpress.Utils.Extensions;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking2010.Dragging;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraReports.UI;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MioSystem.Base;
using MioSystem.Utils;
using Portal.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace MioSystem
{
    public partial class FrmMainForm : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        Login loginUser = Login.GetLoginUser();
        public FrmMainForm()
        {
            InitializeComponent();
            tabbedView1.DocumentAdded += TabbedView1_DocumentAdded;
        }

        private void TabbedView1_DocumentAdded(object sender, DevExpress.XtraBars.Docking2010.Views.DocumentEventArgs e)
        {
            var tabbedView = sender as DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView;
            tabbedView.Controller.Select(e.Document as DevExpress.XtraBars.Docking2010.Views.Tabbed.Document);
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
                    case 1:
                        PGrp.ImageOptions.SvgImage = Properties.Resources.gear;
                        break;
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
                    if (ChildGroup.menuType == 6)
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
                if (ParentGroup.modulID > 1)
                {
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
        }

        private void AccordionControlElement_Click(object sender, EventArgs e)
        {
            var element = (AccordionControlElement)sender;
            if (element != null)
            {
                var navAuth = loginUser.authories.FirstOrDefault(x => x.id == Convert.ToInt32(element.Tag));
                if (navAuth != null)
                {
                    CreateForm(navAuth, navAuth.formType);
                }
            }
            MainMenuAccordionControl.OptionsMinimizing.State = AccordionControlState.Minimized;
        }

        void CreateForm(NavigationAuthory_Model navAuth, int  FormTypeID)
        {
            var nFormSettings = new BaseFormSettings()
            {
                FormID = 0,
                FormAuthoryID = navAuth.id,
                FormModulID = navAuth.modulID,
            };
            nFormSettings.Init();
            if (FormTypeID == 6)
            {
                FormFactory.CreateOrActivateEditForm(documentManager1, nFormSettings);
            }
            else
            {
                FormFactory.CreateOrActivateListForm(documentManager1, nFormSettings, FormTypeID);
            }
        }
    }
}

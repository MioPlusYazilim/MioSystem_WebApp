using System;
namespace Portal.Model
{
    public class PortalMenuView : IDisposable
    {
        public string MenuGroupName { get; set; }
        public int MenuGroupID { get; set; }
        public int MenuGroupOrder { get; set; }
        public string MenuSectionName { get; set; }
        public int MenuSectionID { get; set; }
        public int MenuSectionOrder { get; set; }
        public string MenuItemName { get; set; }
        public int MenuItemID { get; set; }
        public int MenuItemOrder { get; set; }
        public int? ModulID { get; set; }
        public int? IslemGrubuID { get; set; }
        public int IslemYeriID { get; set; }
        public bool Active { get; set; }
        public bool ActiveForWeb { get; set; }
        public string EditFormName { get; set; }
        public string ListFormName { get; set; }
        public int MenuID { get; set; }
        public int FormType { get; set; }
        public int DataType { get; set; }
        public int? ImageIndex { get; set; }
        public string ImageName { get; set; }
        public int MenuOrder { get; set; }
        public bool QuickMenu { get; set; }
        public int? QuickImageIndex { get; set; }
        public string QuickImageName { get; set; }

        public bool View { get; set; }
        public bool New { get; set; }
        public bool Delete { get; set; }
        public bool Modify { get; set; }
        public bool Print { get; set; }
        public string ReportIDs { get; set; }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
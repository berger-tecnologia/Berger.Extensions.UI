using Berger.Extensions.Abstractions;

namespace Berger.Extensions.UI
{
    public class Page : BaseEntity, IModule
    {
        #region Properties
        public Guid HeaderID { get; set; }
        public Guid ModuleId { get; set; }
        public Guid FooterID { get; set; }
        public string Name { get; set; } = string.Empty;
        #endregion

        #region Virtual
        public Header Header { get; set; } = new Header();
        public Footer Footer { get; set; } = new Footer();
        public IModule Module { get; set; }
        public Template Template { get; set; }
        public List<Page> Childrens { get; set; } = new List<Page>();
        public List<Element> Menus { get; set; } = new List<Element>();
        #endregion

        #region Methods
        public void SetModule(string name)
        {
            Module.SetModule(name);
        }
        #endregion
    }
}
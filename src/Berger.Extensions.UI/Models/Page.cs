using Berger.Extensions.Abstractions;

namespace Berger.Extensions.UI
{
    public class Page : IBaseEntity
    {
        #region Properties
        public Guid HeaderID { get; set; }
        public Guid ModuleID { get; set; }
        public Guid FooterID { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<Behavior> Behaviors { get; set; } = new List<Behavior>();
        #endregion

        #region Virtuals
        public Header Header { get; set; } = new Header();
        public Footer Footer { get; set; } = new Footer();
        //public Module Module { get; set; } = new Module();
        //public Template Template { get; set; } = new Template();
        public List<Page> Childrens { get; set; } = new List<Page>();
        public List<Element> Menus { get; set; } = new List<Element>();
        public Guid ID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Deleted { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? DeletedOn { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? ModifiedOn { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime CreatedOn { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Delete()
        {
            //this.Delete = true;
        }
        #endregion

        #region Methods
        public static void SetModule(string module)
        {
            //this.Module = new Module(module);
        }
        #endregion
    }
}
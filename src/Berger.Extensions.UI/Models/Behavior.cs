using Berger.Extensions.Abstractions;

namespace Berger.Extensions.UI
{
    public class Behavior : BaseEntity
    {
        #region Properties
        public Guid SoftwareID { get; set; }
        public Guid? TemplateID { get; set; }
        public Guid? PageID { get; set; }
        public BehaviorType BehaviorType { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<Element> Elements { get; set; } = new List<Element>();
        public List<Element> Sections { get; set; } = new List<Element>();
        public List<IMetadata> Metadata { get; set; } = new List<IMetadata>();
        #endregion

        #region Virtual
        public Page Page { get; set; } = new Page();
        public Template Template { get; set; } = new Template();
        //public ITemplate Template { get; set; }
        public ISoftware Software { get; set; }
        #endregion

        #region Methods
        public void SetTemplateId(Guid id)
        {
            this.TemplateID = id;
        }
        public void SetSoftwareID(Guid id)
        {
            this.SoftwareID = id;
        }
        public void SetPageId(Guid id)
        {
            this.PageID = id;
        }
        #endregion
    }
}
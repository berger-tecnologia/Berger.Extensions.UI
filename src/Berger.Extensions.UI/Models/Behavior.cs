using Berger.Extensions.Abstractions;

namespace Berger.Extensions.UI
{
    public class Behavior : BaseEntity
    {
        #region Properties
        public Guid SoftwareID { get; set; }
        public Guid? TemplateId { get; set; }
        public Guid? PageId { get; set; }
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
            this.TemplateId = id;
        }
        public void SetSoftwareId(Guid id)
        {
            this.SoftwareID = id;
        }
        public void SetPageId(Guid id)
        {
            this.PageId = id;
        }
        #endregion
    }
}
using Berger.Extensions.Abstractions;

namespace Berger.Extensions.UI
{
    public class Behavior : BaseEntity
    {
        #region Properties
        public Guid? PageID { get; set; }
        public Guid? TemplateID { get; set; }
        public Guid? ApplicationID { get; set; }
        public BehaviorType BehaviorType { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<Element> Elements { get; set; } = new List<Element>();
        public List<Element> Sections { get; set; } = new List<Element>();
        public List<IVariation> Variations { get; set; }
        #endregion

        #region Virtual
        public Page Page { get; set; } = new Page();
        public ITemplate Template { get; set; }
        public ISoftware Application { get; set; }
        #endregion

        #region Methods
        public void SetTemplateId(Guid id)
        {
            this.TemplateID = id;
        }
        public void SetApplicationID(Guid id)
        {
            this.ApplicationID = id;
        }
        public void SetPageId(Guid id)
        {
            this.PageID = id;
        }
        #endregion
    }
}
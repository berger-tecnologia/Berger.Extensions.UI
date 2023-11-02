using Berger.Extensions.Abstractions;

namespace Berger.Extensions.UI
{
    // TODO FALTANDO COISA
    public class Behavior
    {
        #region Constructors
        public Behavior(IBaseEntity baseEntity)
        {
            BaseEntity = baseEntity;
        }
        #endregion

        #region Interfaces
        private readonly IBaseEntity BaseEntity;
        #endregion

        #region Properties
        public Guid? PageID { get; set; }
        public Guid? TemplateID { get; set; }
        public Guid? ApplicationID { get; set; }
        public BehaviorType BehaviorType { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<Element> Elements { get; set; } = new List<Element>();
        public List<Element> Sections { get; set; } = new List<Element>();
        //public List<Variation> Variations { get; set; } = new List<Variation>();
        #endregion

        #region Virtual
        public Page Page { get; set; } = new Page();
        //public Template Template { get; set; } = new Template();
        //public Application Application { get; set; } = new Application();

        public Guid ID
        {
            get => BaseEntity.ID;
            set => BaseEntity.ID = value;
        }
        public bool Deleted
        {
            get => BaseEntity.Deleted;
            set => BaseEntity.Deleted = value;
        }

        public void Delete()
        {
            BaseEntity.Delete();
        }

        public DateTime? ModifiedOn => throw new NotImplementedException();

        public DateTime CreatedOn => throw new NotImplementedException();
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
        public void SetPageID(Guid id)
        {
            this.PageID = id;
        }
        #endregion
    }
}
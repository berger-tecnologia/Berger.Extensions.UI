using Berger.Extensions.Abstractions;

namespace Berger.Extensions.UI
{
    public class BaseAttribute : IBaseEntity
    {
        #region Properties
        public Guid ID { get; set; }
        public string AttributeID { get; set; } = string.Empty;
        public bool Deleted { get; set; } = false;
        public DateTime? DeletedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public DateTime CreatedOn { get; set; }
        #endregion

        #region Methods
        public void Delete()
        {
            this.Deleted = true;
        }
        public void SetAttributeId(string id)
        {
            this.AttributeID = id;
        }
        #endregion
    }
}
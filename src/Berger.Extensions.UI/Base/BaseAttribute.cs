using Berger.Extensions.Abstractions;

namespace Berger.Extensions.UI
{
    public class BaseAttribute : BaseEntity
    {
        #region Properties
        public string AttributeID { get; set; } = string.Empty;
        #endregion

        #region Methods
        public void SetAttributeId(string id)
        {
            this.AttributeID = id;
        }
        #endregion
    }
}
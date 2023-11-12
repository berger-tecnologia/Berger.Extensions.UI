using Berger.Extensions.Abstractions;

namespace Berger.Extensions.UI
{
    public class BaseAttribute : BaseEntity
    {
        #region Properties
        public string AttributeId { get; set; } = string.Empty;
        #endregion

        #region Methods
        public void SetAttributeId(string id)
        {
            this.AttributeId = id;
        }
        #endregion
    }
}
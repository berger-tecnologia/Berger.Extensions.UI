using Berger.Extensions.Abstractions;

namespace Berger.Extensions.UI
{
    public class BaseAttribute : BaseEntityWrapper
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
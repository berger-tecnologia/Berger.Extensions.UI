using Berger.Extensions.Storage;
using Berger.Extensions.Abstractions;

namespace Berger.Extensions.UI
{
    public class Template : BaseEntity, ITemplate
    {
        #region Properties
        public string Name { get; set; } = string.Empty;
        public List<Asset> Assets { get; set; } = new List<Asset>();
        #endregion
    }
}
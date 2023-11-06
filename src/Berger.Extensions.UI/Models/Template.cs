using Berger.Extensions.Abstractions;

namespace Berger.Extensions.UI
{
    public class Template : BaseEntity, ITemplate
    {
        #region Properties
        public string Name { get; set; } = string.Empty;
        public List<IVariation> Variations { get; set; }
        public List<IAsset<IFileExtension>> Assets { get; set; }
        #endregion
    }
}
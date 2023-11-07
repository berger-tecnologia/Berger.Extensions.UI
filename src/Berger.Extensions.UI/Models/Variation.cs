using Berger.Extensions.Abstractions;

namespace Berger.Extensions.UI
{
    public class Variation : BaseEntity, IVariation
    {
        public string Key { get; set; } = string.Empty;
        public Dictionary<string, string> Attributes { get; set; } = new Dictionary<string, string>();
    }
}
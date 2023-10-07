namespace Berger.Extensions.UI
{
    public class PageGroup
    {
        public Guid ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<Guid> Elements { get; set; } = new List<Guid>();
    }
}
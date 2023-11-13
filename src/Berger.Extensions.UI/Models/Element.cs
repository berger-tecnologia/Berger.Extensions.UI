namespace Berger.Extensions.UI
{
    public class Element : BaseElement
    {
        #region Properties
        public Guid? ParentId { get; set; }
        public Guid? ColorId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Order { get; set; } = 0;
        public bool IsModal { get; set; } = false;
        #endregion

        #region Virtual
        public Color Color { get; set; }
        public Element Parent { get; set; }
        #endregion

        #region Methods
        public void SetOrder(int order)
        {
            this.Order = order;
        }
        public void SetAsModal()
        {
            this.IsModal = true;
        }
        public void SetTitle(string title)
        {
            this.Title = title;
        }
        #endregion
    }
}
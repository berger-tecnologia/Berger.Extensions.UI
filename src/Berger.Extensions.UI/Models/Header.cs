namespace Berger.Extensions.UI
{
    public class Header : BaseElement
    {
        #region Constructors
        public Header()
        {
        }
        #endregion

        #region Properties
        public string Title { get; set; } = string.Empty;
        public string Module { get; set; } = string.Empty;
        public string Subtitle { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime? Date { get; set; }
        public bool Search { get; set; } = false;
        public List<Element> Menus { get; set; } = new List<Element>();
        public List<Element> Buttons { get; set; } = new List<Element>();
        #endregion

        #region Methods
        public void SetDate(DateTime? date)
        {
            this.Date = date;
        }
        public void SetSearch(bool search)
        {
            this.Search = search;
        }
        #endregion
    }
}
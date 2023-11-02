namespace Berger.Extensions.UI
{
    public class BaseElement : BaseAttribute
    {
        #region Constructors
        public BaseElement()
        {
        }
        public BaseElement(ElementType type)
        {
            ElementType = type;
        }
        #endregion

        #region Properties
        public ElementType ElementType { get; set; }
        public string Href { get; set; } = string.Empty;
        public string Class { get; set; } = string.Empty;
        public string Style { get; set; } = string.Empty;
        public string Target { get; set; } = string.Empty;
        #endregion

        #region Methods
        public void SetType(ElementType type)
        {
            this.ElementType = type;
        }
        public void SetHref(string link)
        {
            this.Href = link;
        }
        public void SetClass(string classValue)
        {
            this.Class = classValue;
        }
        #endregion
    }
}
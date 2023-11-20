using Berger.Extensions.Abstractions;

namespace Berger.Extensions.UI
{
    public class ChartComponent<T> : IBaseElement<T> where T : Enum
    {
        #region Constructors
        public ChartComponent()
        {
        }
        #endregion

        #region Properties
        public T ElementType { get; set; }
        public string Color { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Subtitle { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public List<IElement> Menus { get; set; }
        public string Href { get; set; } = string.Empty;
        public string Class { get; set; } = string.Empty;
        public string Style { get; set; } = string.Empty;
        public string Target { get; set; } = string.Empty;
        #endregion

        #region Methods
        public void SetClass(string classValue)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Methods
        public void SetColor(string color)
        {
            this.Color = color;
        }
        public void SetHref(string link)
        {
            throw new NotImplementedException();
        }
        public void SetType(T type)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
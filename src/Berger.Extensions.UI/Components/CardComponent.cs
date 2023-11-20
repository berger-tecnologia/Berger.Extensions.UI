using Berger.Extensions.Abstractions;

namespace Berger.Extensions.UI
{
    public class CardComponent<T> : BaseEntity, IBaseElement<T>, IBaseEntity<Guid> where T : Enum
    {
        #region Constructors
        public CardComponent()
        {
        }
        #endregion

        #region Properties
        public T ElementType { get; set; }
        public string Href { get; set; } = string.Empty;
        public string Class { get; set; } = string.Empty;
        public string Style { get; set; } = string.Empty;
        public string Target { get; set; } = string.Empty;
        public int Counter { get; set; } = 0;
        public string Title { get; set; } = string.Empty;
        public string Icon { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public List<IElement> Menus { get; set; } = new List<IElement>();
        #endregion

        #region Methods
        public void SetType(T type)
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
        public void SetIcon(string icon)
        {
            this.Icon = icon;
        }
        public void SetCounter(int counter)
        {
            this.Counter = counter;
        }
        public void SetColor(string color)
        {
            this.Color = color;
        }
        #endregion
    }
}
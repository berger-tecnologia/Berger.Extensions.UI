using Berger.Extensions.System;

namespace Berger.Extensions.UI
{
    public class CardComponent : Menu
    {
        #region Constructors
        public CardComponent()
        {
        }
        #endregion

        #region Properties
        public int Counter { get; set; } = 0;
        public string Title { get; set; } = string.Empty;
        public string Icon { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        #endregion

        #region Methods
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
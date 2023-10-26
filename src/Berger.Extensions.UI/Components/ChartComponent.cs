using Berger.Extensions.System;

namespace Berger.Extensions.UI
{
    public class ChartComponent : BaseMenu
    {
        #region Constructors
        public ChartComponent()
        {
        }
        #endregion

        #region Properties
        public string Color { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Subtitle { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        #endregion

        #region Methods
        public void SetColor(string color)
        {
            this.Color = color;
        }
        #endregion
    }
}
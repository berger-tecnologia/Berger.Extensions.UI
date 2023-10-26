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
        public string Title { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
        #endregion

        #region Methods
        public void SetColor(string color)
        {
            this.Color = color;
        }
        #endregion
    }
}
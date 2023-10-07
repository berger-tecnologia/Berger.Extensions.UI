﻿using Berger.Extensions.System;

namespace Berger.Extensions.UI
{
    public class ChartComponent : Menu
    {
        #region Constructors
        public ChartComponent()
        {
        }
        #endregion

        #region Properties
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
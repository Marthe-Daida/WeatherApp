using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;

namespace WeatherLibrary
{
    public partial class WeatherView : Component
    {
        public WeatherView()
        {
            InitializeComponent();
        }

        public WeatherView(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}

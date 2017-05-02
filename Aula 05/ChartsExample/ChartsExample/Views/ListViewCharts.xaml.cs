using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ChartsExample.Views
{
    public partial class ListViewCharts : ContentPage
    {
        public ListViewCharts()
        {
            InitializeComponent();
            BindingContext = new ViewModels.ListViewChartsViewModel();
        }
    }
}

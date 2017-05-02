using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ChartsExample.Views
{
    public partial class PizzaExamplePage : ContentPage
    {
        public PizzaExamplePage()
        {
            InitializeComponent();
            BindingContext = new ViewModels.PizzaViewModel(this.Navigation);
        }
    }
}

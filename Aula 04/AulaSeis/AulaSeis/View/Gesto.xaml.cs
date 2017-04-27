using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AulaSeis.View
{
    public partial class Gesto : ContentPage
    {
        public Gesto()
        {
            InitializeComponent();
            BindingContext = new ViewModel.DependencyServiceViewModel(this);
        }
    }
}

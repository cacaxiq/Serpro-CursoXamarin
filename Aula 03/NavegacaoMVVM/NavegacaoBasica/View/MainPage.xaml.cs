using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NavegacaoBasica.View
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BindingContext = new ViewModel.MainViewModel();
        }
    }
}

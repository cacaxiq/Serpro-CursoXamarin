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

        void NavegacaoBasica(object sender, System.EventArgs e)
        {
            Navigation?.PushAsync(new MainPage());
        }

        void NavegacaoModal(object sender, System.EventArgs e)
        {
            Navigation?.PushModalAsync(new MainPage());
        }

        void Voltar(object sender, System.EventArgs e)
        {
            Navigation?.PopModalAsync();
        }
    }
}

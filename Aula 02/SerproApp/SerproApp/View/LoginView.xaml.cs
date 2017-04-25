using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SerproApp.View
{
    public partial class LoginView : ContentPage
    {
        public LoginView()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new MainView());
        }
    }
}

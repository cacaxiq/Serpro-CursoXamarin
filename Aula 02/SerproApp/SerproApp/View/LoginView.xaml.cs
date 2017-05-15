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
            NavigationPage.SetHasNavigationBar(this, false);
            BindingContext = new ViewModel.LoginViewModel(this, this.Navigation);
        }
    }
}

using System;
using System.Collections.Generic;
using SerproApp.ViewModel;
using Xamarin.Forms;

namespace SerproApp.View
{
    public partial class MasterView : ContentPage
    {
        public ListView Lista { get { return lista; } }

        public MasterViewModel ViewModel { get { return new MasterViewModel(); } }

        public MasterView()
        {
            InitializeComponent();
            BindingContext = ViewModel;
            this.lista.ItemsSource = ViewModel.MenuItens;
        }
    }
}

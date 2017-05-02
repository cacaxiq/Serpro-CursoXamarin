using System;
using ListViewExample.Infra;
using Xamarin.Forms;

namespace ListViewExample.Views
{
    public partial class ListViewSimples : ContentPage
    {
        public ListViewSimples()
        {
            InitializeComponent();
            BindingContext = new ViewModels.ListViewExampleViewModel();

        }

    }
}

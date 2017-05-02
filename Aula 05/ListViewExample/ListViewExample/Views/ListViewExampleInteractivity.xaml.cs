using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ListViewExample.Views
{
    public partial class ListViewExampleInteractivity : ContentPage
    {
        public ListViewExampleInteractivity()
        {
            InitializeComponent();
            BindingContext = new ViewModels.ListViewExampleViewModel(this);
        }

        public void OnDelete(object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);
            DisplayAlert("Delete Context Action", mi.CommandParameter + " delete context action", "OK");
        }
    }
}

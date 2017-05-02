using System;
using System.Collections.Generic;
using ListViewExample.Model;
using Xamarin.Forms;

namespace ListViewExample.Views
{
    public partial class ListViewDataTemplate : ContentPage
    {
        public ListViewDataTemplate()
        {
            InitializeComponent();
            BindingContext = new ViewModels.ListViewExampleViewModel();
        }

        void OnSelectLine(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return; //ItemSelected is called on deselection, which results in SelectedItem being set to null
            }

            DisplayAlert("Item Selected", ((Pessoa)e.SelectedItem).Nome, "Ok");
        }
    }
}

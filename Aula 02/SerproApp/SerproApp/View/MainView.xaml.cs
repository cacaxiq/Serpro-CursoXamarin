using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SerproApp.View
{
    public partial class MainView : MasterDetailPage
    {
        public MainView()
        {   InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            this.masterPage.Lista.ItemSelected += OnItemSelected;
        }

        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MenuItem;
            if (item != null)
            {
                Detail = new NavigationPage(new PaginaUmView((string)item.CommandParameter))
                {
                    BackgroundColor =   Color.FromHex("#35372E"),
                    BarTextColor = Color.White

                };
                masterPage.Lista.SelectedItem = null;
                IsPresented = false;
            }
        }

    }
}



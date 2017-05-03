using System;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace MapasExample.Views
{
    public partial class MapasExamplePage : ContentPage
    {
        public MapasExamplePage()
        {
            InitializeComponent();
            BindingContext = new ViewModels.MapsViewModel(this.meuMapa, this.Navigation);
        }

        void Handle_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var picke = (Picker)sender;
            int selectedIndex = picke.SelectedIndex;

            if (selectedIndex != -1)
            {
                DisplayAlert("Tipo de mapa", "Mapa alterado para " + picke.SelectedItem, "Ok");
                meuMapa.MapType = (MapType)picke.SelectedItem;
            }
        }
    }
}

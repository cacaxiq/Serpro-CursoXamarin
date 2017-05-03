using System;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace MapasExample
{
    public partial class MapasExamplePage : ContentPage
    {
        public MapasExamplePage()
        {
            InitializeComponent();
            BindingContext = new ViewModels.MapsViewModel(this.meuMapa);
        }

        void Handle_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;

            if (selectedIndex != -1)
            {
                DisplayAlert("Tipo de mapa", "Mapa alterado para " + picker.SelectedItem, "Ok");
                meuMapa.MapType = (MapType)picker.SelectedItem;
            }
        }
    }
}

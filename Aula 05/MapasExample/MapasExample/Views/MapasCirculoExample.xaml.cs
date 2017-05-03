﻿using System;
using System.Collections.Generic;
using MapasExample.CustomMaps;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace MapasExample.Views
{
    public partial class MapasCirculoExample : ContentPage
    {
        public MapasCirculoExample()
        {
            InitializeComponent();
            // BindingContext = new ViewModels.MapsViewModel(this.meuMapa);

            var pin = new Pin
            {
                Type = PinType.Place,
                Position = new Position(37.79752, -122.40183),
                Label = "Xamarin San Francisco Office",
                Address = "394 Pacific Ave, San Francisco CA"
            };

            var position = new Position(37.79752, -122.40183);
            meuMapa.Circle = new CustomCircle
            {
                Position = position,
                Radius = 1000
            };

            meuMapa.Pins.Add(pin);
            meuMapa.MoveToRegion(MapSpan.FromCenterAndRadius(position, Distance.FromMiles(1.0)));
        }
    }
}

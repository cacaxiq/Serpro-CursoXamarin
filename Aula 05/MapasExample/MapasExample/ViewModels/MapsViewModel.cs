using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using MapasExample.CustomMaps;
using Xamarin.Forms;
using Xamarin.Forms.Maps;


namespace MapasExample.ViewModels
{
    public class MapsViewModel
    {
        private INavigation navegacao;
        private Map mapa;
        private CustomMap customMapa;

        public MapsViewModel()
        {
        }

        public MapsViewModel(Map _mapa, INavigation _navegacao)
        {
            mapa = _mapa;
            navegacao = _navegacao;
        }

        public MapsViewModel(CustomMap _mapa)
        {
            customMapa = _mapa;
        }

        public ObservableCollection<MapType> TipoMapas
        {
            get
            {
                var lista = new ObservableCollection<MapType> {
                    MapType.Hybrid, MapType.Satellite, MapType.Street
                };

                return lista;
            }
        }

        public Command InserirPinCommand
        {
            get { return new Command(GerarPin); }
        }

        public Command InserirPinCirculoCommand
        {
            get { return new Command(GerarPinCirculo); }
        }

        public Command MapCustomCommand
        {
            get { return new Command(NavegarMapaCustom); }
        }

        private void GerarPin()
        {
            var random = new Random();


            var position = new Position(random.Next(-80, -20), random.Next(-40, 10)); // Latitude, Longitude

            var randomPin = random.Next(1, 4);

            PinType pinT = PinType.SearchResult;

            switch (randomPin)
            {
                case 1:
                    pinT = PinType.Generic;
                    break;
                case 2:
                    pinT = PinType.Place;
                    break;
                case 3:
                    pinT = PinType.SavedPin;
                    break;
                case 4:
                    pinT = PinType.SearchResult;
                    break;
                default:
                    break;
            }

            var pin = new Pin
            {
                Type = pinT,
                Position = position,
                Label = "custom pin",
                Address = "custom detail info"
            };
            mapa.Pins.Add(pin);
            mapa.MoveToRegion(MapSpan.FromCenterAndRadius(position, Distance.FromMiles(1.0)));

        }

        private void GerarPinCirculo()
        {
            var random = new Random();

            var position = new Position(random.Next(-80, -20), random.Next(-40, 10)); // Latitude, Longitude

            var randomPin = random.Next(1, 4);

            PinType pinT = PinType.Generic;

            switch (randomPin)
            {
                case 1:
                    pinT = PinType.Generic;
                    break;
                case 2:
                    pinT = PinType.Place;
                    break;
                case 3:
                    pinT = PinType.SavedPin;
                    break;
                case 4:
                    pinT = PinType.SearchResult;
                    break;
                default:
                    break;
            }


            var pin = new Pin
            {
                Type = pinT,
                Position = position,
                Label = "custom pin",
                Address = "custom detail info"
            };

            customMapa.Circle = new CustomCircle
            {
                Position = position,
                Radius = 1000
            };

            customMapa.Pins.Add(pin);
            customMapa.MoveToRegion(MapSpan.FromCenterAndRadius(position, Distance.FromMiles(1.0)));
        }

        async void NavegarMapaCustom()
        {
            await navegacao.PushAsync(new Views.MapasCirculoExample());
        }
    }
}

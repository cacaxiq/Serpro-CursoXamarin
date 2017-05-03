using System;
using Xamarin.Forms.Maps;

namespace MapasExample.CustomMaps
{
    public class CustomMap : Map
    {
        public CustomCircle Circle { get; set; }
    }

    public class CustomCircle
    {
        public Position Position { get; set; }

        public double Radius { get; set; }
    }
}


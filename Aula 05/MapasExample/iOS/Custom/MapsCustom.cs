using System.Linq;
using MapasExample.CustomMaps;
using MapasExample.iOS.Custo;
using MapKit;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Maps.iOS;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomMap), typeof(MapsCustom))]
namespace MapasExample.iOS.Custo
{
    public class MapsCustom : MapRenderer
    {
        MKCircleRenderer circleRenderer;

        protected override void OnElementChanged(ElementChangedEventArgs<View> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null)
            {
                var nativeMap = Control as MKMapView;
                nativeMap.OverlayRenderer = null;
            }

            if (e.NewElement != null)
            {
                var formsMap = (CustomMap)e.NewElement;
                var nativeMap = Control as MKMapView;
                var circle = formsMap.Circle;

                if (circle != null)
                {
                    nativeMap.OverlayRenderer = GetOverlayRenderer;

                    var circleOverlay = MKCircle.Circle(new CoreLocation.CLLocationCoordinate2D(circle.Position.Latitude, circle.Position.Longitude), circle.Radius);
                    nativeMap.AddOverlay(circleOverlay);
                }
            }
        }

        MKOverlayRenderer GetOverlayRenderer(MKMapView mapView, IMKOverlay overlay)
        {
            if (circleRenderer == null)
            {
                circleRenderer = new MKCircleRenderer(overlay as MKCircle);
                circleRenderer.FillColor = UIColor.Red;
                circleRenderer.Alpha = 0.4f;
            }
            return circleRenderer;
        }
    }
}
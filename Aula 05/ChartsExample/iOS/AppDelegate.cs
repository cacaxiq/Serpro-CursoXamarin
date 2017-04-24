using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

namespace ChartsExample.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            OxyPlot.Xamarin.Forms.Platform.iOS.PlotViewRenderer.Init();
            Forms.Init();

            this.LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}

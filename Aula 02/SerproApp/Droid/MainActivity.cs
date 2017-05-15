using Android.App;
using Android.Content.PM;
using Android.OS;
using AsNum.XFControls.Droid;

namespace SerproApp.Droid
{
    [Activity(Label = "Serpro.Droid", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{

			base.OnCreate(savedInstanceState);

			AsNumAssemblyHelper.HoldAssembly();
            OxyPlot.Xamarin.Forms.Platform.Android.PlotViewRenderer.Init();
			global::Xamarin.Forms.Forms.Init(this, savedInstanceState);

			LoadApplication(new App());
		}
	}
}


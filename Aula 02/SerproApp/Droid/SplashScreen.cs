
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace SerproApp.Droid
{
    [Activity(MainLauncher = true, NoHistory = true)]
    public class SplashScreen : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.SplashScreen);
        }

        protected async override void OnResume()
        {
            base.OnResume();
            await Task.Delay(4000);
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        }
    }
}

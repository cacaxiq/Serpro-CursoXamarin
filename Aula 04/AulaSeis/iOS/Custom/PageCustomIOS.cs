using System;
using AulaSeis.Custom;
using AulaSeis.iOS.Custom;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: Xamarin.Forms.ExportRenderer(typeof(PageCustom), typeof(PageCustomIOS))]
namespace AulaSeis.iOS.Custom
{
    public class PageCustomIOS : PageRenderer
    {
        public PageCustomIOS()
        {
        }
    }
}

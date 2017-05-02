using System;
using AulaSeis.Custom;
using AulaSeis.Droid.Custom;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(ButtonLink), typeof(ButtonLinkCustom))]
namespace AulaSeis.Droid.Custom
{
    public class ButtonLinkCustom : ButtonRenderer
    {


        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {

            base.OnElementChanged(e);
            if (e.OldElement == null)
            {

            }
        }
    }

}
using System;
using Xamarin.Forms;

namespace AulaSeis.Custom
{
    public class BorderedEntry : Entry
    {


        public static readonly BindableProperty TipoBordaProperty =
            BindableProperty.Create("TipoBorda", typeof(int), typeof(BorderedEntry), default(int));

        public static readonly BindableProperty CorBordaProperty =
            BindableProperty.Create("CorBorda", typeof(Color), typeof(BorderedEntry), default(Color));

        public static readonly BindableProperty TamanhoBordaProperty =
            BindableProperty.Create("TamanhoBorda", typeof(float), typeof(BorderedEntry), default(float));

        public int TipoBorda
        {
            get { return (int)GetValue(TipoBordaProperty); }
            set { SetValue(TipoBordaProperty, value); }
        }

        public Color CorBorda
        {
            get { return (Color)GetValue(CorBordaProperty); }
            set { SetValue(CorBordaProperty, value); }
        }

        public float TamanhoBorda
        {
            get { return (float)GetValue(TamanhoBordaProperty); }
            set { SetValue(TamanhoBordaProperty, value); }
        }
    }
}

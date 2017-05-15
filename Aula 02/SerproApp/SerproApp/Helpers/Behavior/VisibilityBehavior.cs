using System;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace SerproApp.Helpers.Behavior
{
    public class VisibilityBehavior : Behavior<Button>
    {
        public VisibilityBehavior()
        {
        }

        static readonly BindablePropertyKey IsValidPropertyKey = BindableProperty.CreateReadOnly("IsValid", typeof(bool), typeof(VisibilityBehavior), true);

        public static readonly BindableProperty IsValidProperty = IsValidPropertyKey.BindableProperty;

        public bool IsValid
        {
            get { return (bool)base.GetValue(IsValidProperty); }
            private set { base.SetValue(IsValidPropertyKey, value); }
        }

        static readonly BindablePropertyKey IsValidInversePropertyKey = BindableProperty.CreateReadOnly("IsValidInverse", typeof(bool), typeof(VisibilityBehavior), false);

        public static readonly BindableProperty IsValidInverseProperty = IsValidInversePropertyKey.BindableProperty;

        public bool IsValidInverse
        {
            get { return (bool)base.GetValue(IsValidInverseProperty); }
            private set { base.SetValue(IsValidInversePropertyKey, value); }
        }


        protected override void OnAttachedTo(Button bindable)
        {
            bindable.Clicked += HandleTextChanged;
        }

        async void HandleTextChanged(object sender, EventArgs e)
        {
            IsValidInverse = IsValid;
            IsValid = !IsValid;

            var btn = (Button)sender;
            if (btn.Text == "Gráfico")
            {
                btn.Text = "Valores";
            }
            else { btn.Text = "Gráfico"; }

            btn.TextColor = Color.WhiteSmoke;
            await Task.Delay(200);
            btn.TextColor = Color.White;
        }

        protected override void OnDetachingFrom(Button bindable)
        {
            bindable.Clicked -= HandleTextChanged;

        }
    }
}

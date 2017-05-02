using Xamarin.Forms;

namespace ChartsExample.Views
{
    public partial class ChartsExamplePage : ContentPage
    {
        public ChartsExamplePage()
        {
            InitializeComponent();
            BindingContext = new ViewModels.BarraViewModel(this.Navigation);
        }
    }
}

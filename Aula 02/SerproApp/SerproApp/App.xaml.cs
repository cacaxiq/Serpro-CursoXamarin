using Xamarin.Forms;
using SerproApp.View;
using Xamarin.Forms.Xaml;

namespace SerproApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ContentPage
            {
                Content = new StackLayout()
                {
                    Children = {
                new Label() { Text = "A", FontSize = 30},
                new Label() { Text = "B", FontSize = 30},
                new Label() { Text = "C", FontSize = 30},
                new Label() { Text = "D", FontSize = 30},
                new Label() {Text="E", FontSize = 30}
            }
                }
            };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

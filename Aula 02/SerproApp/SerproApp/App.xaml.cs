using Xamarin.Forms;
using SerproApp.View;
using Xamarin.Forms.Xaml;
using SerproApp.Model;
using SerproApp.Services.WebService.ServiceClass;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace SerproApp
{
    public partial class App : Application
    {
        //LoginService loginService;

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new View.MainView());


        }

        protected override void OnStart()
        {

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

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

            MainPage = new NavigationPage(new View.LoginView())
            {
                BackgroundColor = Color.FromHex("#00420c"),
                BarTextColor = Color.Silver,
                BarBackgroundColor = Color.Blue, //Color.FromHex("#00420c")
            };

            NavigationPage.SetHasNavigationBar(this, false);
            //loginService = new LoginService();
        }

        protected override void OnStart()
        {
            var login = new Login();

            login.UserPassword = "Teste";
            login.UserCPF = "123456";
            login.SecureCode = "true1234";

            //await loginService.SaveTodoItemAsync(login, true);
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

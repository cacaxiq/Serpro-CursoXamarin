using AulaSeis.View;
using Xamarin.Forms;

namespace AulaSeis
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    break;
                case Device.Android:
                    Xamarin.Forms.DependencyService.Get<DependencServices.INotification>().PushNotification("Aplicativo Iniciado", "Vamos começar a praticar Xamarin.");
                    break;
                case Device.WinPhone:
                case Device.Windows:
                default:

                    break;
            }
        }

        protected override void OnSleep()
        {
            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    break;
                case Device.Android:
                    Xamarin.Forms.DependencyService.Get<DependencServices.INotification>().PushNotification("Aplicativo Em Segundo Plano", "Entrei em repouso!!!");
                    break;
                case Device.WinPhone:
                case Device.Windows:
                default:

                    break;
            }
        }

        protected override void OnResume()
        {
            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    break;
                case Device.Android:
                    Xamarin.Forms.DependencyService.Get<DependencServices.INotification>().PushNotification("Aplicativo Reaberto", "Maurílio libera a pizza!!!");
                    break;
                case Device.WinPhone:
                case Device.Windows:
                default:

                    break;
            }
        }
    }
}

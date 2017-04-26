using System;
using Xamarin.Forms;

namespace NavegacaoBasica.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {
            AboutCommand = new Command(ExecuteAboutCommand);
        }

        public Command AboutCommand
        {
            get;
        }

        async void ExecuteAboutCommand(object obj)
        {
            await PushAsync<AboutViewModel>();
        }
    }
}

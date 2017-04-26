using System;
using Xamarin.Forms;

namespace NavegacaoBasica.ViewModel
{
    public class MainViewModel
    {
        private INavigation Navegacao;

        public MainViewModel(INavigation _navegacao)
        {
            Navegacao = _navegacao;
            NavegueiCommand = new Command(ExecuteNavegueiCommand);

        }

        public Command NavegueiCommand
        {
            get;
            set;
        }

        void ExecuteNavegueiCommand()
        {
            Navegacao.PushAsync(new View.MainPage());
        }

    }
}

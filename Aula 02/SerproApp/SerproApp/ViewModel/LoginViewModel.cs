using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Input;
using PropertyChanged;
using SerproApp.Model;
using SerproApp.Services.WebService.ServiceClass;
using SerproApp.View;
using Xamarin.Forms;

namespace SerproApp.ViewModel
{
    [ImplementPropertyChanged]
    public class LoginViewModel
    {
        LoginService loginService;
        Page page;
        INavigation navegacao;

        public LoginViewModel(Page _page, INavigation _navegacao)
        {
            loginService = new LoginService();
            page = _page;
            navegacao = _navegacao;

        }

        private string _cpf;
        public string CPF
        {
            get { return _cpf; }
            set { _cpf = value; LoginCommand.ChangeCanExecute(); }
        }

        private string _senha;
        public string Senha
        {
            get { return _senha; }
            set { _senha = value; LoginCommand.ChangeCanExecute(); }
        }

        private string _keeplogged;
        public string KeepLogged
        {
            get { return _keeplogged; }
            set { _keeplogged = value; }
        }

        public ICommand PrimeiroAcessoCommand
        {
            get { return new Command(ExecutePrimeiroAcessoCommand); }
        }

        public ICommand EsqueceuSenhaCommand
        {
            get { return new Command(ExecuteEsqueceuSenhaCommand); }
        }

        public Command LoginCommand
        {
            get { return new Command(ExecuteLoginCommand, CanExecuteLoginCommand); }
        }

        void ExecutePrimeiroAcessoCommand(object obj)
        {
            throw new NotImplementedException();
        }

        void ExecuteEsqueceuSenhaCommand(object obj)
        {
            throw new NotImplementedException();
        }

        async void ExecuteLoginCommand()
        {
            var retorno = await loginService.RefreshDataAsync();
            if (retorno.Count == 0)
                await page.DisplayAlert("Erro", "Falha no ligin.", "Ok");

            var exist = retorno.Exists(p => p.UserCPF == CPF && p.UserPassword == Senha);

            if (exist)
            {
                await page.DisplayAlert("Sucesso", "Voce será direcionado.", "Ok");
                await navegacao.PushAsync(new MainView());
            }
        }


        bool CanExecuteLoginCommand()
        {
            return false == (string.IsNullOrEmpty(CPF) || string.IsNullOrEmpty(Senha));

        }
    }
}


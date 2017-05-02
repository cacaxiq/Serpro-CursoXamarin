using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Threading.Tasks;
using System.Windows.Input;
using ListViewExample.Infra;
using ListViewExample.Model;
using Xamarin.Forms;
using Microsoft.WindowsAzure.MobileServices;
using System.Collections.Generic;

namespace ListViewExample.ViewModels
{
    public class ListViewExampleViewModel : EventChanged
    {
        private PessoaService pessoaService;

        private Page page;

        public ListViewExampleViewModel()
        {
            pessoaService = new PessoaService();

            Pessoas = new ObservableCollection<Pessoa>();

            CarregaPessoas();
        }

        public ListViewExampleViewModel(Page _page)
        {
            page = _page;

            pessoaService = new PessoaService();

            Pessoas = new ObservableCollection<Pessoa>();

            CarregaPessoas();
        }

        private bool _isRefreshing = false;
        public bool IsRefreshing
        {
            get { return _isRefreshing; }
            set
            {
                _isRefreshing = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Pessoa> Pessoas
        {
            get;
            set;
        }

        public ICommand RefreshList
        {
            get { return new Command(AtualizaLista); }
        }

        public ICommand DetalheCommand
        {
            get { return new Command<Pessoa>(ExecuteDetalheCommand); }
        }

        public ICommand RemoverCommand
        {
            get { return new Command<Pessoa>(ExecuteRemoverCommand); }
        }

        private async void CarregaPessoas()
        {
            var lista = await pessoaService.Get();
            Pessoas.Clear();
            foreach (var item in lista)
            {
                Pessoas.Add(item);
            }
        }

        public async void AtualizaLista()
        {
            IsRefreshing = true;
            var lista = await pessoaService.GetOrdered();
            Pessoas.Clear();
            foreach (var item in lista)
            {
                Pessoas.Add(item);
            }
            IsRefreshing = false;
        }

        public void ExecuteDetalheCommand(Pessoa pessoa)
        {
            page.DisplayAlert("Também é possivel direcionar para uma outra página sobre detalhes do ", pessoa.Nome, "OK");
        }

        public void ExecuteRemoverCommand(Pessoa pessoa)
        {
            page.DisplayAlert("É possível executar várias processos utilizando todo o objeto do ", pessoa.Nome, "OK");
        }
    }
}

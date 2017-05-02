using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace ListViewExample.ViewModels
{
    public class MainViewModel
    {
        readonly INavigation Navegacao;

        public MainViewModel(INavigation _navigation)
        {
            Navegacao = _navigation;
        }

        public ICommand ListViewSimples
        {
            get { return new Command(() => ChangePage(new Views.ListViewSimples())); }
        }

        public ICommand ListViewDataTemplate
        {
            get { return new Command(() => ChangePage(new Views.ListViewDataTemplate())); }
        }

        public ICommand ListViewRefresh
        {
            get { return new Command(() => ChangePage(new Views.ListViewRefresh())); }
        }

        public ICommand ListViewExampleInteractivity
        {
            get { return new Command(() => ChangePage(new Views.ListViewExampleInteractivity())); }
        }

        async void ChangePage(Page page)
        {
            await Navegacao.PushAsync(page);
        }
    }
}

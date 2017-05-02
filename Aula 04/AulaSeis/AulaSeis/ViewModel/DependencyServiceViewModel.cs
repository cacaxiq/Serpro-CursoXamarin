using System;
using System.Diagnostics.Contracts;
using System.Windows.Input;
using AulaSeis.DependencServices;
using AulaSeis.Infra;
using Xamarin.Forms;

namespace AulaSeis.ViewModel
{
    public class DependencyServiceViewModel : ObservedClass
    {
        public DependencyServiceViewModel()
        {
        }

        Page Page;

        public DependencyServiceViewModel(Page page)
        {
            Page = page;
        }

        private string _textToTalk;
        public string TextToTalk
        {
            get { return _textToTalk; }
            set { _textToTalk = value; OnPropertyChanged(); }
        }


        public ICommand Talk
        {
            get { return new Command(() => DependencyService.Get<ITalkCell>().TextToTalk(this.TextToTalk)); }
        }

        public ICommand AlertCommand
        {
            get { return new Command(() => ExecuteAlertCommand()); }
        }


        public void Teste()
        {
            DependencyService.Get<ITalkCell>().TextToTalk("Curso Zarb Solutions na ATTPS!");
        }

        void ExecuteAlertCommand()
        {
            Page.DisplayAlert("Atenção", "Vc clicou 3 vezes nesse botão!!!!", "Ok");
        }


    }
}

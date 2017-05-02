using System;
using System.ComponentModel;
using OxyPlot;
using Xamarin.Forms;

namespace ChartsExample.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public BaseViewModel()
        {
        }

        public BaseViewModel(INavigation navegacao)
        {
            Navegacao = navegacao;
        }

        protected PlotModel plot;

        protected INavigation Navegacao;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}

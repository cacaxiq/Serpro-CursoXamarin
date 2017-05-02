using System;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using Xamarin.Forms;

namespace ChartsExample.ViewModels
{
    public class BarraViewModel : BaseViewModel
    {

        public BarraViewModel(INavigation navegacao)
        {
            Model = Series.BarSeriesExamples.BarSeries();
            Navegacao = navegacao;
        }

        private PlotModel _model;
        public PlotModel Model
        {
            get { return _model; }
            set { _model = value; OnPropertyChanged("Model"); }
        }

        public double HalfScreenHeight
        {
            get { return 300; }
        }

        public Command PizzaCommand
        {
            get { return new Command(async () => await Navegacao.PushAsync(new Views.PizzaExamplePage())); }
        }

    }
}

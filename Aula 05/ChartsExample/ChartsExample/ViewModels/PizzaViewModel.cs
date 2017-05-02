using System;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using Xamarin.Forms;

namespace ChartsExample.ViewModels
{
    public class PizzaViewModel : BaseViewModel
    {
        public PizzaViewModel(INavigation navegacao)
        {
            Navegacao = navegacao;
            Model = Series.BarSeriesExamples.BarSeries_grouped();
        }

        private PlotModel _model;
        public PlotModel Model
        {
            get { return _model; }
            set { _model = value; OnPropertyChanged("Model"); }
        }

        public double HalfScreenHeight
        {
            get { return 400; }
        }

        public Command ChangedPageCommand
        {
            get { return new Command(async () => await Navegacao.PushAsync(new Views.ListViewCharts())); }
        }
    }
}

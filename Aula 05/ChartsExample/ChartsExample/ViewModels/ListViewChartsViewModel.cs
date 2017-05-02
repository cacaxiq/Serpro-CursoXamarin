using System;
using OxyPlot;
using Xamarin.Forms;

namespace ChartsExample.ViewModels
{
    public class ListViewChartsViewModel : BaseViewModel
    {
        public ListViewChartsViewModel()
        {
            Model = Series.TwoColorLineSeriesExamples.TwoColorLineSeries();
            Model1 = Series.StemSeriesExamples.StemSeries();
            Model2 = Series.ScatterSeriesExamples.ScatterSeries();
            Model3 = Series.HeatMapSeriesExamples.HeatMapSeries();
            Model4 = Series.ColumnSeriesExamples.ColumnSeries();
            Model5 = Series.LineSeriesExamples.LineSeriesExample3();
            Model6 = Series.ContourSeriesExamples.ContourSeries();
            Model7 = Series.FunctionSeriesExamples.FunctionSeries();

        }

        public double HalfScreenHeight
        {
            get { return 250; }
        }

        private PlotModel _model;
        public PlotModel Model
        {
            get { return _model; }
            set { _model = value; OnPropertyChanged("Model"); }
        }

        private PlotModel _model1;
        public PlotModel Model1
        {
            get { return _model1; }
            set { _model1 = value; OnPropertyChanged("Model1"); }
        }

        private PlotModel _model2;
        public PlotModel Model2
        {
            get { return _model2; }
            set { _model2 = value; OnPropertyChanged("Model2"); }
        }

        private PlotModel _model3;
        public PlotModel Model3
        {
            get { return _model3; }
            set { _model3 = value; OnPropertyChanged("Model3"); }
        }

        private PlotModel _model4;
        public PlotModel Model4
        {
            get { return _model4; }
            set { _model4 = value; OnPropertyChanged("Model4"); }
        }

        private PlotModel _model5;
        public PlotModel Model5
        {
            get { return _model5; }
            set { _model5 = value; OnPropertyChanged("Model5"); }
        }

        private PlotModel _model6;
        public PlotModel Model6
        {
            get { return _model6; }
            set { _model6 = value; OnPropertyChanged("Model6"); }
        }

        private PlotModel _model7;
        public PlotModel Model7
        {
            get { return _model7; }
            set { _model7 = value; OnPropertyChanged("Model7"); }
        }
    }
}

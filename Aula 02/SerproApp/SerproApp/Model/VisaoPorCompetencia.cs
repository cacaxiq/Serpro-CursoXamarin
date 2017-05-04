using System;
using OxyPlot;
using OxyPlot.Xamarin.Forms;
using PropertyChanged;

namespace SerproApp.Model
{
    [ImplementPropertyChanged]
    public class VisaoPorCompetencia
    {
        public VisaoPorCompetencia()
        {
        }

        public string Ano
        {
            get;
            set;
        }

        public PlotModel Grafico
        {
            get;
            set;
        }
    }
}

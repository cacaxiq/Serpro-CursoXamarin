using System;
using System.Collections.ObjectModel;
using PropertyChanged;
using SerproApp.Model;

namespace SerproApp.ViewModel
{
    [ImplementPropertyChanged]
    public class PaginaUmViewModel
    {
        public PaginaUmViewModel()
        {
            Lista = new ObservableCollection<VisaoPorCompetencia> {
                new VisaoPorCompetencia(){ Ano = "2016", Grafico = BarSeriesExamples.SerproSeries()},
new VisaoPorCompetencia() { Ano = "2015", Grafico = BarSeriesExamples.SerproSeries()},
new VisaoPorCompetencia() { Ano = "2014", Grafico = BarSeriesExamples.SerproSeries()},
new VisaoPorCompetencia() { Ano = "2013", Grafico = BarSeriesExamples.SerproSeries()},
new VisaoPorCompetencia() { Ano = "2012", Grafico = BarSeriesExamples.SerproSeries()},
new VisaoPorCompetencia() { Ano = "2011", Grafico = BarSeriesExamples.SerproSeries()},

            };


        }

        public ObservableCollection<VisaoPorCompetencia> Lista
        {
            get;
        }

    }
}

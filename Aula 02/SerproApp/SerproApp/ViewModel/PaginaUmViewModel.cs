using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using OxyPlot;
using PropertyChanged;
using SerproApp.Model;
using Xamarin.Forms;

namespace SerproApp.ViewModel
{
    [ImplementPropertyChanged]
    public class PaginaUmViewModel : BaseViewModel
    {
        public PaginaUmViewModel(string titulo)
        {
            ItemTesteLista = new ObservableCollection<ItemTeste>()
                                        {
                                            new ItemTeste{ DisplayName = "teste 01"},
                                            new ItemTeste{ DisplayName = "teste 01"},
                                            new ItemTeste{ DisplayName = "teste 01"},
                                            new ItemTeste{ DisplayName = "teste 01"}
            };

            Grafico = BarSeriesExamples.SerproSeries(titulo);

			DescricaoPicker = "Detalhe por mes";
            ListaPicker = Meses;
        }

		public PaginaUmViewModel(string titulo, string tipoGrafico)
		{
			ItemTesteLista = new ObservableCollection<ItemTeste>()
										{
											new ItemTeste{ DisplayName = "teste 01"},
											new ItemTeste{ DisplayName = "teste 01"},
											new ItemTeste{ DisplayName = "teste 01"},
											new ItemTeste{ DisplayName = "teste 01"}
			};

            DescricaoPicker = "Detalhe por Semana";

			ListaPicker = Semanas;

            Grafico = BarSeriesExamples.SerproSeriesMes(titulo);
		}

        public ObservableCollection<ItemTeste> ItemTesteLista
        {
            get;
        }

        public PlotModel Grafico
		{
			get;
		}

        public bool ListaVisibilidade
        {
            get;
            set;
        }

        public bool GraficoVisibilidade
        {
            get; set;
        }

		public string DescricaoPicker
		{
			get; set;
		}

		public ObservableCollection<string> ListaPicker
		{
			get; set;
		}

        public Command GraficoCommand
        {
            get { return new Command(ExecuteGraficoCommand); }
        }

        public Command ListaCommand
        {
            get { return new Command(ExecuteListaCommand); }
        }

        private void ExecuteGraficoCommand()
        {
            ListaVisibilidade = false;
            GraficoVisibilidade = true;
        }

        private void ExecuteListaCommand()
        {
            ListaVisibilidade = true;
            GraficoVisibilidade = false;
        }
    }
}

using System;
using System.Collections.Generic;
using OxyPlot.Xamarin.Forms;
using Xamarin.Forms;

namespace SerproApp.View
{
    public partial class PaginaUmView : ContentPage
    {
        public string Titulo
        {
            get;
            set;
        }

        public PaginaUmView(string titulo)
        {
            Titulo = titulo;
            InitializeComponent();
            BindingContext = new ViewModel.PaginaUmViewModel(titulo);
        }

		public PaginaUmView(string titulo, string tipoGrafico)
		{
			Titulo = titulo;
			InitializeComponent();
			BindingContext = new ViewModel.PaginaUmViewModel(titulo, tipoGrafico);
		}

		public PaginaUmView()
		{
            Titulo = "2017";
			InitializeComponent();
			BindingContext = new ViewModel.PaginaUmViewModel("2017");
        }

        void Handle_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var item = (Picker)sender;

            var title = (string)item.SelectedItem + " de " + Titulo;
            if (item.Title == "Detalhe por mes")
                this.Navigation.PushAsync(new PaginaUmView(title, "mes"));
			
        }
    }
}

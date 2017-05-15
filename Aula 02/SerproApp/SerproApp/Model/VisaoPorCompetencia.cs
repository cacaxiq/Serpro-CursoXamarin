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

        public ItemCompetencia ItemCompetencia
        {
            get;
            set;
        }
    }
}

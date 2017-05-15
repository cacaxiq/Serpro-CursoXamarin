using System;
using System.Collections.ObjectModel;
using PropertyChanged;

namespace SerproApp.ViewModel
{
    [ImplementPropertyChanged]
    public class BaseViewModel
    {
        public BaseViewModel()
        {
        }


        public ObservableCollection<String> Meses
        {
            get
            {
                return new ObservableCollection<string>() {
                        "Janeiro",
                        "Fevereiro",
                        "Março",
                        "Abril",
                        "Maio",
                        "Junho",
                        "Julho",
                        "Agosto",
                        "Setembro",
                        "Outubro",
                        "Novembro",
                        "Dezembro"
                };
            }
        }

        public ObservableCollection<string> Semanas
        {
            get
            {
                return new ObservableCollection<string>() {
                    "Semana 01",
                    "Semana 02",
                    "Semana 03",
                    "Semana 04",
                };
            }
        }
    }
}

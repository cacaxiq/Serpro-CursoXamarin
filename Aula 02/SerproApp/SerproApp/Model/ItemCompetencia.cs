using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using OxyPlot;

namespace SerproApp.Model
{
    public class ItemCompetencia
    {
        public ItemCompetencia()
        {

        }

        public PlotModel Grafico
        {
            get; set;
        }

        public ObservableCollection<ItemTeste> ItemTesteLista
        {
            get; set;
        }
    }
}

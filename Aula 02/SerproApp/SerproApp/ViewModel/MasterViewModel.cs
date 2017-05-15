using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using PropertyChanged;
using Xamarin.Forms;

namespace SerproApp.ViewModel
{
    [ImplementPropertyChanged]
    public class MasterViewModel
    {
        public MasterViewModel()
        {
            MenuItens = new ObservableCollection<MenuItem>() {
                new MenuItem(){ Icon="ano2017.png",CommandParameter="2017"},
                new MenuItem(){ Icon="ano2016.png",CommandParameter="2016"},
                new MenuItem(){ Icon="ano2015.png",CommandParameter="2015"},
                new MenuItem(){ Icon="ano2014.png",CommandParameter="2014"},
                new MenuItem(){ Icon="ano2013.png",CommandParameter="2013"},

            };

        }

        public ObservableCollection<MenuItem> MenuItens
        {
            get;
        }

        public ICommand MenuItemCommand
        {
            get;
        }
    }
}

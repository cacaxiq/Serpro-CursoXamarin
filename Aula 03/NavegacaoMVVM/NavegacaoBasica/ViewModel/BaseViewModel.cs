using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NavegacaoBasica.ViewModel
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public BaseViewModel()
        {


        }

        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            var propertyChanged = PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        protected async Task PushAsync<TViewModel>(params object[] args) where TViewModel : BaseViewModel
        {
            var viewModelType = typeof(TViewModel);

            var viewModelTypeName = viewModelType.Name;
            var viewModelWordLength = "ViewModel".Length;
            var viewTypeName = $"NavegacaoBasica.View.{viewModelTypeName.Substring(0, viewModelTypeName.Length - viewModelWordLength)}View";
            var viewType = Type.GetType(viewTypeName);

            var page = Activator.CreateInstance(viewType) as Page;

            var viewModel = Activator.CreateInstance(viewModelType, args);

            if (page != null)
            {
                page.BindingContext = viewModel;
            }

            await Application.Current.MainPage.Navigation.PushAsync(page);
        }
    }
}

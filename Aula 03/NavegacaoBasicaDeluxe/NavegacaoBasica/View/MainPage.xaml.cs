using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NavegacaoBasica.View
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BindingContext = new ViewModel.MainViewModel(0, false, 0, false);
        }

        public MainPage(int countStack, bool isCountStack, int countStackModal, bool isCountStackModal)
        {
            InitializeComponent();

            BindingContext = new ViewModel.MainViewModel(countStack, isCountStack, countStackModal, isCountStackModal);
        }

        void NavegacaoBasica(object sender, System.EventArgs e)
        {
            if (Navigation.ModalStack.Count == 0)
            {
                Navigation?.PushAsync(new MainPage(int.Parse(countStack.Text), true, int.Parse(countStackModal.Text), false));
            }
        }

        void NavegacaoModal(object sender, System.EventArgs e)
        {
            Navigation?.PushModalAsync(new MainPage(int.Parse(countStack.Text), false, int.Parse(countStackModal.Text), true));
        }

        void Voltar(object sender, System.EventArgs e)
        {
            Navigation?.PopModalAsync();
            if (Navigation.ModalStack.Count > 0)
            {
                int down = int.Parse(countStackModal.Text);
                countStackModal.Text = (--down).ToString();
            }

        }
    }
}

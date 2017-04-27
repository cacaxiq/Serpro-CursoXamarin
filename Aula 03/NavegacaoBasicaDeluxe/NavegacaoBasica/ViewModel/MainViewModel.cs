using System;
using Xamarin.Forms;

namespace NavegacaoBasica.ViewModel
{
    public class MainViewModel
    {
        public MainViewModel(int countStack, bool isCountStack, int countStackModal, bool isCountStackModal)
        {
            if (isCountStack)
            {
                CountNavigationStack = ++countStack;
            }
            else { CountNavigationStack = countStack; }


            if (isCountStackModal)
            {
                CountNavigationStackModal = ++countStackModal;
            }
            else
            {
                CountNavigationStackModal = countStackModal;
            }

            var random = new Random();

            ContentBackColor = new Color(
                random.NextDouble(),
                random.NextDouble(),
                random.NextDouble(),
                random.NextDouble()
            );

        }

        public int CountNavigationStack
        {
            get;
            set;
        }

        public int CountNavigationStackModal
        {
            get; set;
        }

        public Color ContentBackColor
        {
            get;
            set;
        }
    }
}

using System;
using System.ComponentModel;
using PropertyChanged;


namespace SerproApp.ViewModel
{
    [ImplementPropertyChanged]
    public class LoginViewModel
    {
        public LoginViewModel()
        {
            Name = "carlos henrique";
            Name2 = "rocha gabriel";
        }

        public string Name
        {
            get;
            set;
        }

        public string Name2
        {
            get; set;
        }

        public int Progresso
        {
            get; set;
        }
    }

}

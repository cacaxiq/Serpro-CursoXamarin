using System;
using PropertyChanged;

namespace SerproApp.Model
{
    [ImplementPropertyChanged]
    public class Login
    {
        public string Id
        {
            get; set;
        }
        public string UserCPF
        {
            get;
            set;
        }
        public string UserPassword
        {
            get; set;
        }
        public bool KeepLogged
        {
            get;
            set;
        }
        public string SecureCode
        {
            get; set;
        }
    }
}

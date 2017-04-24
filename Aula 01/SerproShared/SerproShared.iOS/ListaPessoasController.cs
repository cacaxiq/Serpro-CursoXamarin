using Foundation;
using System;
using UIKit;
using Serpro.Shared.Service;
using System.Linq;

namespace SerproShared.iOS
{
    public partial class ListaPessoasController : UIViewController
    {
        public ListaPessoasController(IntPtr handle) : base(handle)
        {

        }

        public override async void ViewDidLoad()
        {
            var pessoaService = new PessoaService();

            var pessoas = await pessoaService.GetPessoa();

            listaPessoas.Source = new PessoaDataSource(pessoas.Select(p => p.Nome).ToList());
        }
    }
}
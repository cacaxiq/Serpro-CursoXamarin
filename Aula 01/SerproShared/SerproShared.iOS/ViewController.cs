using System;
using Foundation;
using Microsoft.WindowsAzure.MobileServices;
using Serpro.Shared.Model;
using Serpro.Shared.Service;
using UIKit;

namespace SerproShared.iOS
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            CurrentPlatform.Init();

            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            this.adicionarPessoa.TouchUpInside += async (sender, e) =>
            {

                var pessoaService = new PessoaService();

                var pessoa = new Pessoa
                {
                    Ativo = txt_ativo.Text == "Sim",
                    CPF = Convert.ToInt64(txt_cpf.Text),
                    DataNascimento = new DateTime(Convert.ToInt32(txt_dataNascimento.Text.Split('/')[2]), Convert.ToInt32(txt_dataNascimento.Text.Split('/')[1]), Convert.ToInt32(txt_dataNascimento.Text.Split('/')[0])),
                    Nome = txt_nome.Text,
                    Ocupacao = txt_ocupacao.Text,
                    QtdadeFilhos = Convert.ToInt32(txt_qtdadefilhos.Text),
                    Sexo = txt_sexo.Text
                };

                await pessoaService.InsertPessoa(pessoa);
            };
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            base.PrepareForSegue(segue, sender);

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

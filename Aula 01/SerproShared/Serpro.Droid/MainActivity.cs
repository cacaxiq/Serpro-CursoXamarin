using Android.App;
using Android.Widget;
using Android.OS;
using Serpro.Shared.Service;
using Serpro.Shared.Model;
using System;
using Android.Content;

namespace Serpro.Droid
{
    [Activity(Label = "Inserir Pessoas", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            var nome = FindViewById<TextView>(Resource.Id.txt_nome);
            var sexo = FindViewById<TextView>(Resource.Id.sexo);
            var dataNascimento = FindViewById<TextView>(Resource.Id.dataNascimento);
            var ativo = FindViewById<TextView>(Resource.Id.ativo);
            var ocupacao = FindViewById<TextView>(Resource.Id.ocupacao);
            var qtdadeFilhos = FindViewById<TextView>(Resource.Id.qtdadeFilhos);
            var cpf = FindViewById<TextView>(Resource.Id.CPF);

            var addPessoa = FindViewById<Button>(Resource.Id.addPessoa);
            var navegarLista = FindViewById<Button>(Resource.Id.navegarLista);

            var pessoaService = new PessoaService();

            addPessoa.Click += async (sender, e) =>
            {

                var pessoa = new Pessoa
                {
                    Ativo = ativo.Text == "Sim",
                    CPF = Convert.ToInt64(cpf.Text),
                    DataNascimento = new DateTime(Convert.ToInt32(dataNascimento.Text.Split('/')[2]), Convert.ToInt32(dataNascimento.Text.Split('/')[1]), Convert.ToInt32(dataNascimento.Text.Split('/')[0])),
                    Nome = nome.Text,
                    Ocupacao = ocupacao.Text,
                    QtdadeFilhos = Convert.ToInt32(qtdadeFilhos.Text),
                    Sexo = sexo.Text
                };

                await pessoaService.InsertPessoa(pessoa);
            };

            navegarLista.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(ListaPessoas));
                StartActivity(intent);
            };
        }
    }
}


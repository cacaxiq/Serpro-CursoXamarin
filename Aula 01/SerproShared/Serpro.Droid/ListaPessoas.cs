
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Serpro.Shared.Service;

namespace Serpro.Droid
{
    [Activity(Label = "ListaPessoas")]
    public class ListaPessoas : Activity
    {
        protected async override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.ListaPessoas);

            var listaPessoas = FindViewById<ListView>(Resource.Id.listaPessoas);

            var pessoaService = new PessoaService();

            var pessoas = await pessoaService.GetPessoa();

            listaPessoas.Adapter = new ArrayAdapter(this,
                                                    Android.Resource.Layout.SimpleListItem1,
                                                    pessoas.Select(p => p.Nome).ToArray());
        }
    }
}

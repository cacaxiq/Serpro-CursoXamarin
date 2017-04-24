using System.Linq;
using Android;
using Android.App;
using Android.OS;
using Android.Widget;
using Serpro.Shared.Service;

namespace SerproShared.Droid
{
    [Activity(Label = "Serpro.Droid")]
    public class ListViewPessoa : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.La);

            var listaPessoas = FindViewById<ListView>(Resource.Id.listaPessoas);

            var pessoaService = new PessoaService();

            var pessoas = pessoaService.GetPessoa();

            listaPessoas.Adapter += new ArrayAdapter(this,
                                                    Android.Resource.Layout.SimpleListItem1,
                                                    pessoas.Result.Select(p => p.Nome).ToArray());
        }
    }
}

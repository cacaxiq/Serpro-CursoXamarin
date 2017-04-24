using System;
using System.Collections.Generic;
using Microsoft.WindowsAzure.MobileServices;
using System.Threading.Tasks;
using Serpro.Shared.Model;

namespace Serpro.Shared.Service
{
    public class PessoaService
    {
        private MobileServiceClient client;
        private IMobileServiceTable<Pessoa> pessoaTable;

        public PessoaService()
        {
            client = new MobileServiceClient("http://serpro-aula01.azurewebsites.net");
            pessoaTable = client.GetTable<Pessoa>();
        }

        public async Task<IEnumerable<Pessoa>> GetPessoa()
        {
            IEnumerable<Pessoa> listaPessoas = new List<Pessoa>();

            listaPessoas = await pessoaTable.ToEnumerableAsync();

            return listaPessoas;

        }

        public async Task<Pessoa> InsertPessoa(Pessoa product)
        {

            await pessoaTable.InsertAsync(product);

            return product;

        }

        public async Task<Pessoa> UpdatePessoa(Pessoa product)
        {

            await pessoaTable.UpdateAsync(product);

            return product;

        }

        public async Task<Pessoa> DeletePessoa(Pessoa product)
        {

            await pessoaTable.DeleteAsync(product);

            return product;

        }
    }
}

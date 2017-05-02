using Microsoft.WindowsAzure.MobileServices;
using ListViewExample.Model;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;

namespace ListViewExample.Infra
{
    public class AzureServiceBase<TEntity>
    {
        protected IMobileServiceClient _client;
        protected IMobileServiceTable<TEntity> _table;
        protected const string serviceUrl = "http://serpro-aula01.azurewebsites.net";

        public AzureServiceBase()
        {
            _client = new MobileServiceClient(serviceUrl);
            _table = _client.GetTable<TEntity>();
        }
    }
}

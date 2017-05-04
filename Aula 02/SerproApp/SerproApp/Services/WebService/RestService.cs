using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SerproApp.Helpers.Dependency;
using Xamarin.Forms;

namespace SerproApp.Services.WebService
{
    public class RestService<T> : IRestService<T>
    {
        HttpClient client;

        public List<T> Items { get; private set; }

        private string RestUrl;

        private string NomeClasse;

        Page page;

        public RestService()
        {
            client = new HttpClient();
            //client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

            client.DefaultRequestHeaders.Add("cache-control", "no-cache");
            client.DefaultRequestHeaders
                  .Accept
                  .Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("zumo-api-version", "2.0.0");

            NomeClasse = typeof(T).ToString().Split('.').Last();

            RestUrl = string.Format(Constants.RestUrl, NomeClasse);

            page = App.Current.MainPage;
        }

        public async Task<List<T>> RefreshDataAsync()
        {
            Items = new List<T>();

            var uri = new Uri(RestUrl);

            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    Items = JsonConvert.DeserializeObject<List<T>>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"ERROR {0}", ex.Message);
            }

            return Items;
        }

        public async Task SaveTodoItemAsync(T item, bool isNewItem = false)
        {
            var id = GetPropValue(item, "Id");
            var uri = new Uri(string.Format(RestUrl, id));

            try
            {
                var json = JsonConvert.SerializeObject(item);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = null;
                if (isNewItem)
                {
                    response = await client.PostAsync(uri, content);
                }
                else
                {
                    var request = new HttpRequestMessage(new HttpMethod("PATCH"), uri) { Content = content };

                    response = await client.SendAsync(request);
                }

                if (response.IsSuccessStatusCode)
                {
                    await page.DisplayAlert("Sucesso", NomeClasse + " successfully saved.", "Ok");
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"ERROR {0}", ex.Message);
            }
        }

        public async Task DeleteTodoItemAsync(string id)
        {
            var uri = new Uri(string.Format(RestUrl, id));

            try
            {
                var response = await client.DeleteAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    Debug.WriteLine(nameof(T) + "successfully deleted.");
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"ERROR {0}", ex.Message);
            }
        }

        public static object GetPropValue(object src, string propName)
        {
            return src.GetType().GetRuntimeProperty(propName).GetValue(src, null);
        }
    }
}

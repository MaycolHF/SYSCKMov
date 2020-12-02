using Newtonsoft.Json;
using SYSCKM.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SYSCKM.Services
{
    public class StikersService : IStikersService<Stikers>
    {
        HttpClient client;
        public List<Stikers> Items { get; private set; }
        public StikersService()
        {
#if DEBUG
            client = new HttpClient(DependencyService.Get<IHttpClientHandlerService>().GetInsecureHandler());
#else
            client = new HttpClient();
#endif
        }
        public async Task<List<Stikers>> getall(Stikers obj)
        {
            Items = new List<Stikers>();
            Uri uri = new Uri(string.Format(Constants.UrlStikers, string.Empty));
            try
            {
                string json = JsonConvert.SerializeObject(obj);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                if (obj!=null)
                {
                    HttpResponseMessage response = await client.PostAsync(uri, content);
                    if (response.IsSuccessStatusCode)
                    {
                        string contentData = await response.Content.ReadAsStringAsync();
                        Items = JsonConvert.DeserializeObject<List<Stikers>>(contentData);
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }
            return Items;
        }
    }
}

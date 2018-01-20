using System;
using System.Configuration;
using System.Net.Http;
using System.Threading.Tasks;

namespace ProMan_Simulator
{
    /// <summary>
    /// Got idea from https://code.msdn.microsoft.com/Web-API-With-HttpClient-Or-87e07c98
    /// </summary>
    public class HttpHelper : IDisposable
    {
        private readonly HttpClient client;

        public HttpHelper()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(ConfigurationManager.AppSettings["WebAPIServer"]);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

        public HttpHelper(string uri)
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(uri);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<T> HttpGet<T>(string adress)
        {
            T tag = default(T);
            HttpResponseMessage res = await client.GetAsync(adress);
            res.EnsureSuccessStatusCode();
            if (res.IsSuccessStatusCode)
            {
                tag = await res.Content.ReadAsAsync<T>();
            }
            return tag;
        }

        public async Task HttpPost<T>(string adress, T value)
        {
            HttpResponseMessage res = await client.PostAsJsonAsync(adress, value);
            res.EnsureSuccessStatusCode();
            if (res.IsSuccessStatusCode)
            {
                Console.WriteLine("Sucessfull put");
            }
        }

        public async Task HttpPut<T>(string adress, T value)
        {
            HttpResponseMessage res = await client.GetAsync(adress);
            res.EnsureSuccessStatusCode();
            if (res.IsSuccessStatusCode)
            {
                T tag = await res.Content.ReadAsAsync<T>();
                tag = value;
                res = await client.PutAsJsonAsync(adress, tag);
            }
        }
        public async Task HttpDelete(string adress)
        {
            HttpResponseMessage res = await client.DeleteAsync(adress);
            res.EnsureSuccessStatusCode();
            if (res.IsSuccessStatusCode)
            {
                Console.WriteLine("Sucessfull delete");
            }
        }

        public void Dispose()
        {
            client.Dispose();
        }
    }
}

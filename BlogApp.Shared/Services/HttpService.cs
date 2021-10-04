using BlogApp.Shared.Utils;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlogApp.Shared.Services
{
    public class HttpService
    {
        public T CallApi<T>(string endpoint, object objRequest = null, HttpType httpType = HttpType.Get, Dictionary<string, string> headers = null)
        {
            var response = default(T);
            var client = new HttpClient();

            if (headers != null)
            {
                foreach (KeyValuePair<string, string> entry in headers)
                {
                    client.DefaultRequestHeaders.Add(entry.Key, entry.Value);
                }
            }

            var responseMessage = new HttpResponseMessage();
            client.DefaultRequestHeaders.Add("Accept", "application/json");

            switch (httpType)
            {
                case HttpType.Get:
                    responseMessage = client.GetAsync(endpoint).GetAwaiter().GetResult();
                    break;
                case HttpType.Post:
                    responseMessage = client.PostAsJsonAsync(endpoint, objRequest).GetAwaiter().GetResult();
                    break;
                case HttpType.Put:
                    responseMessage = client.PutAsJsonAsync(endpoint, objRequest).GetAwaiter().GetResult();
                    break;
            }

            if (responseMessage.IsSuccessStatusCode)
            {
                response = responseMessage.Content.ReadAsAsync<T>().Result;
            }

            return response;
        }

        public async Task<T> CallApiAsync<T>(string endpoint, object objRequest = null, HttpType httpType = HttpType.Get, Dictionary<string, string> headers = null)
        {
            T response = default(T);
            var client = new HttpClient();

            if(headers != null)
            {
                foreach (KeyValuePair<string, string> entry in headers)
                {
                    client.DefaultRequestHeaders.Add(entry.Key, entry.Value);
                }
            }

            client.DefaultRequestHeaders.Add("Accept", "application/json");
            HttpResponseMessage httpResponseMessage;
            switch (httpType)
            {
                case HttpType.Get:
                    using (httpResponseMessage = await client.GetAsync(endpoint))
                    {
                        //if (httpResponseMessage.IsSuccessStatusCode)
                        {
                            response = await httpResponseMessage.Content.ReadAsAsync<T>();
                        }
                    }
                    break;
                case HttpType.Post:
                    using (httpResponseMessage = await client.PostAsJsonAsync(endpoint, objRequest))
                    {
                        //if (httpResponseMessage.IsSuccessStatusCode)
                        {
                            response = await httpResponseMessage.Content.ReadAsAsync<T>();
                        }
                    }
                    break;
                case HttpType.Put:
                    using (httpResponseMessage = await client.PutAsJsonAsync(endpoint, objRequest))
                    {
                        //if (httpResponseMessage.IsSuccessStatusCode)
                        {
                            response = await httpResponseMessage.Content.ReadAsAsync<T>();
                        }
                    }
                    break;
            }

            return response;
        }
    }
}

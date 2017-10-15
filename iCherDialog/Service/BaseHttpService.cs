using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;
using System.Json;
using System.Text;

namespace iCherDialog.Service
{
    public class BaseHttpService
    {
        public HttpClient Client { get; }
        public string ContentType { get; set; } = "application/json";
        public Encoding Encoding { get; set; } = null;
        private IHttpClientFact clientFactory;

        public BaseHttpService(IHttpClientFact clientFactory)
        {
            this.clientFactory = clientFactory;
            var httpClientCacheKey = Guid.NewGuid().ToString();

            this.Client = this.clientFactory.GetForKey(httpClientCacheKey);
            this.Encoding = Encoding.UTF8;
            this.ContentType = ContentType;
        }

        public async Task<TResponse> GetAsync<TResponse>(string uri)
        {
            try
            {
                var response = await Client.GetAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    var respContent = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<TResponse>(respContent);
                }
                else
                {
                    throw new Exception($"Failed request with code {response.StatusCode}: {response.ReasonPhrase}");
                }
            }
            catch (JsonSerializationException)
            {
                throw new InvalidOperationException($"Failed to parse the response to type {typeof(TResponse).Name}");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
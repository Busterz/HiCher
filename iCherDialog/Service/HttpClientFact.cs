using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace iCherDialog.Service
{
    public interface IHttpClientFact
    {
        HttpClient GetForKey(string key);
    }

    public class HttpClientFact : IHttpClientFact
    {
        protected static readonly ConcurrentDictionary<string, HttpClient> HttpClientCache = new ConcurrentDictionary<string, HttpClient>();

        public HttpClient GetForKey(string key)
        {
            return HttpClientCache.GetOrAdd(key, k => {
                var client = new HttpClient()
                {
                    /* Other setup */
                };

                return client;
            });
        }
    }
}
using System;
using System.Net.Http;

namespace Capgemini.Helper
{
    public class ApiHelper : IApiHelper

    {
        public HttpClient Initial()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5000/");
            return client;
        }
    }
}
using System;
using RestSharp;

namespace AzurePlusXamApp.Services
{
    public class BaseClient
    {
        public BaseClient()
        {
            var client = new RestClient("http://example.com");
        }
    }
}

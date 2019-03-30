using System;
using RestSharp;

namespace AzurePlusXamApp.Services
{
    public class WeatherService
    {
        public static string GetWeather(string location)
        {
            var client = new RestClient("http://example.com");
            // client.Authenticator = new HttpBasicAuthenticator(username, password);

            var request = new RestRequest("resource/{id}", Method.POST);
            request.AddParameter("name", "value");
            return ""; 
        }
    }
}

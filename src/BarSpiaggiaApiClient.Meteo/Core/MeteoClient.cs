using BarSpiaggiaAPIClient.Meteo.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace BarSpiaggiaAPIClient.Meteo.Core
{
    public class MeteoClient : IMeteoClient
    {
        private string url = "";
        private string result;

        private const string BaseUrl = "http://api.weatherapi.com/v1/current.json?key=";
        private const string ApiKey = "7f4389ff11a94fd4938110520212306";

        public MeteoClient()
        {
            Info = new Information();
            try
            {
                url += BaseUrl;
                url += ApiKey;
            }
            catch(ArgumentNullException)
            {
                throw;
            }
            catch(SecurityException)
            {
                throw;
            }
        }

        public Information Info { get; private init; }
        public Location Location { get; private set; }

        public async Task SearchAsync(string city)
        {
            using var client = new HttpClient();
            url += $"&q={city}&aqi=no";

            try
            {
                result = await client.GetStringAsync(url);
            }
            catch (HttpRequestException)
            {
                Info.Text = "Inserisci una città valida";
                return;
            }
            catch(InvalidOperationException)
            {
                Info.Text = "Error";
                return;
            }

            var deserialized = JObject.Parse(result);
            try
            {
                Info.Temperature = deserialized["current"]?["temp_c"]?.ToObject<double?>();
                Info.Text = deserialized["current"]?["condition"]?["text"]?.ToString();
                Info.Icon = deserialized["current"]?["condition"]?["icon"]?.ToString();
                Location = deserialized["location"]?.ToObject<Location>();
            }
            catch (NullReferenceException)
            {
                throw;
            }
            catch (InvalidOperationException)
            {
                throw;
            }
        }
    }
}
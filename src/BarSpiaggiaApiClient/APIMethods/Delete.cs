using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace BarSpiaggiaApiClient.APIMethods
{
    public class Delete : Method
    {
        public Delete() : base()
        {

        }

        protected override void CreateConnection()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44337/swagger/index.html");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
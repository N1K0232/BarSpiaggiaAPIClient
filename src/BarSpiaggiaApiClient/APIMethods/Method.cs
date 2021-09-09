using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BarSpiaggiaApiClient.APIMethods
{
    public abstract class Method
    {
        internal HttpClient client;

        protected Method()
        {
            client = null;
            CreateConnection();
        }

        protected abstract void CreateConnection();
    }
}
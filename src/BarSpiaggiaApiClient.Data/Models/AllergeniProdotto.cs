using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarSpiaggiaApiClient.Data.Models
{
    public class AllergeniProdotto
    {
        public Guid IDAllergene { get; set; }
        public Guid IDProdotto { get; set; }
    }
}
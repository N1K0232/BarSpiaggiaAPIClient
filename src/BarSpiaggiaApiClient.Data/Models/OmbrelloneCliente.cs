using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarSpiaggiaApiClient.Data.Models
{
    public class OmbrelloneCliente
    {
        public Guid IDOmbrellone { get; set; }
        public Guid IDCliente { get; set; }
        public DateTime DataPrenotazione { get; set; }
        public TimeSpan OraPrenotazione { get; set; }
    }
}
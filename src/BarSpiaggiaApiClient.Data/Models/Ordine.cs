using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarSpiaggiaApiClient.Data.Models
{
    public class Ordine
    {
        public Guid IDOrdine { get; set; }
        public Guid IDCameriere { get; set; }
        public Guid IDCliente { get; set; }
        public Guid IDOmbrellone { get; set; }
        public string Annotazioni { get; set; }
        public DateTime DataOrdinazione { get; set; }
        public TimeSpan OraOrdinazione { get; set; }
    }
}
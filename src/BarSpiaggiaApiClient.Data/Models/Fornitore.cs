using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarSpiaggiaApiClient.Data.Models
{
    public class Fornitore
    {
        public Guid IDFornitore { get; set; }
        public string NomeSocieta { get; set; }
        public string Contatto { get; set; }
        public string Posizione { get; set; }
        public string Indirizzo { get; set; }
        public string Citta { get; set; }
        public string Zona { get; set; }
        public string CAP { get; set; }
        public string Paese { get; set; }
        public string Telefono { get; set; }
        public string Fax { get; set; }
        public string HomePage { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarSpiaggiaApiClient.Data.Models
{
    public class Prodotto
    {
        public Guid IDProdotto { get; set; }
        public Guid IDCategoria { get; set; }
        public Guid IDCorriere { get; set; }
        public Guid IDFornitore { get; set; }
        public string Nome { get; set; }
        public DateTime DataScadenza { get; set; }
        public int QuantitaDisponibile { get; set; }
        public decimal Prezzo { get; set; }
    }
}
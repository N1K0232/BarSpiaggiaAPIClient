using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarSpiaggiaApiClient.Data.Models
{
    public class DettagliOrdine
    {
        public Guid IDOrdine { get; set; }
        public Guid IDProdotto { get; set; }
        public int QuantitaOrdinata { get; set; }
        public decimal PrezzoUnitario { get; set; }
    }
}
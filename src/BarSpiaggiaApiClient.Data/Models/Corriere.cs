using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarSpiaggiaApiClient.Data.Models
{
    public class Corriere
    {
        public Guid IDCorriere { get; set; }
        public string NomeSocieta { get; set; }
        public string Telefono { get; set; }
    }
}
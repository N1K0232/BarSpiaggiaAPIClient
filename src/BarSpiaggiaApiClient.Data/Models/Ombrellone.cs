using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarSpiaggiaApiClient.Data.Models
{
    public class Ombrellone
    {
        public Guid IDOmbrellone { get; set; }
        public int Fila { get; set; }
        public string Lettera { get; set; }
        public bool Occupato { get; set; }
    }
}
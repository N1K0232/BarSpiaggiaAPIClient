using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarSpiaggiaApiClient.Data.Models
{
    public class Credenziali
    {
        public Guid IDBar { get; set; }
        public Guid IDCameriere { get; set; }
        public Guid IDCliente { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime DataUltimoAccesso { get; set; }
        public DateTime DataUltimoCambioPassword { get; set; }
        public DateTime DataRichiestaCambioPassword { get; set; }
    }
}
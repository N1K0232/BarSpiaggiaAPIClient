using System;

namespace BarSpiaggiaApiClient.Data.Models
{
    public class Cameriere
    {
        public Guid IDCameriere { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateTime DataNascita { get; set; }
        public int Eta { get; set; }
        public string CodiceFiscale { get; set; }
        public string Sesso { get; set; }
        public string CAP { get; set; }
        public string Indirizzo { get; set; }
        public string Telefono { get; set; }
        public bool Occupato { get; set; }
    }
}
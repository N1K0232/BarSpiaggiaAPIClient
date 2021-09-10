using System;

namespace BarSpiaggiaApiClient.Data.Requesters
{
    public class NewPasswordRequester
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime DataUltimoAccesso { get; set; }
        public DateTime DataUltimoCambioPassword { get; set; }
        public DateTime DataRichiestaCambioPassword { get; set; }
    }
}
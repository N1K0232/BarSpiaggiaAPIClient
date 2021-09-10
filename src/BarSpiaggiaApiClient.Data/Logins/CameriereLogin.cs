using BarSpiaggiaApiClient.Data.Models;

namespace BarSpiaggiaApiClient.Data.Logins
{
    public class CameriereLogin
    {
        public CameriereLogin(Cameriere cameriere, Credenziali credenziali)
        {
            this.Cameriere = cameriere;
            this.Credenziali = credenziali;
        }

        public Cameriere Cameriere { get; }
        public Credenziali Credenziali { get; }
    }
}
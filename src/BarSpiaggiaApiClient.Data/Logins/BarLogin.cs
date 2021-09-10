using BarSpiaggiaApiClient.Data.Models;

namespace BarSpiaggiaApiClient.Data.Logins
{
    public class BarLogin
    {
        public BarLogin(Bar bar, Credenziali credenziali)
        {
            this.Bar = bar;
            this.Credenziali = credenziali;
        }

        public Bar Bar { get; }
        public Credenziali Credenziali { get; }
    }
}
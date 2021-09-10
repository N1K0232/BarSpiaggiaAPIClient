using BarSpiaggiaApiClient.Data.Models;

namespace BarSpiaggiaApiClient.Data.Logins
{
    public class ClienteLogin
    {
        public ClienteLogin(Cliente cliente, Credenziali credenziali)
        {
            this.Cliente = cliente;
            this.Credenziali = credenziali;
        }

        public Cliente Cliente { get; }
        public Credenziali Credenziali { get; }
    }
}
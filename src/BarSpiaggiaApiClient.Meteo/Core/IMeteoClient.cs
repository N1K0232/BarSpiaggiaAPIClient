using System.Threading.Tasks;

namespace BarSpiaggiaAPIClient.Meteo.Core
{
    public interface IMeteoClient
    {
        Task SearchAsync(string city);
    }
}
using BarSpiaggiaAPIClient.Meteo.Core;
using BarSpiaggiaAPIClient.Meteo.Models;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        public async static Task Main(string[] args)
        {
            MeteoClient meteoClient = new MeteoClient();
            await meteoClient.SearchAsync("Bologna");
            Information info = meteoClient.Info;
            Location location = meteoClient.Location;
        }
    }
}
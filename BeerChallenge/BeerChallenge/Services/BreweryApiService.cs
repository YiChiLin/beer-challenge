using System;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using BeerChallenge.Models;
using Newtonsoft.Json;

namespace BeerChallenge.Services
{
    public class BreweryApiService : IApiService<BeerResponse>
    {
        public async Task<BeerResponse> GetAsync()
        {
            using (var client = new WebClient())
            {
                var uri = new Uri("http://api.brewerydb.com/v2/beers/?key=d905bda1503354da3820dc22ba49ad69");
                var response = await client.DownloadDataTaskAsync(uri);
                var result = Encoding.UTF8.GetString(response);
                return JsonConvert.DeserializeObject<BeerResponse>(result);
            }
        }
    }
}
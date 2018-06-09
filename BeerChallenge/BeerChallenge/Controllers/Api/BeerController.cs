using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using BeerChallenge.Models;
using BeerChallenge.Services;

namespace BeerChallenge.Controllers.Api
{
    public class BeerController : ApiController
    {
        [HttpGet]
        public async Task<List<BeerResponseDetail>> Beers(string beerName = "")
        {
            var service = new BreweryApiService();
            var data = (await service.GetAllBeerInformationAsync()).Data;
            return string.IsNullOrEmpty(beerName) ? data : data.Where(beer => beer.Name.Contains(beerName)).ToList();
        }
    }
}
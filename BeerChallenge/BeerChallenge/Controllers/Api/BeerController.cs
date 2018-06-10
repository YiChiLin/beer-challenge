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
        private static readonly IBeerService _BeerService = new BeerService();

        [HttpGet]
        public async Task<List<BeerResponseDetail>> Beers(string beerName = "")
        {
            var data = (await _BeerService.GetBeersAsync()).Data;
            return string.IsNullOrEmpty(beerName) ? data : data.Where(beer => beer.Name.Contains(beerName)).ToList();
        }
    }
}
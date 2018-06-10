using System;
using System.Threading.Tasks;
using BeerChallenge.Models;

namespace BeerChallenge.Services
{
    public interface IBeerService
    {
        Task<BeerResponse> GetBeersAsync();
    }

    public class BeerService : IBeerService
    {
        private BeerResponse _BeerCache;
        private IApiService<BeerResponse> _BreweryApiService { get; }

        public BeerService()
        {
            _BreweryApiService = new BreweryApiService();
        }

        public async Task<BeerResponse> GetBeersAsync()
        {
            const int cacheTimeoutMinutes = 5;
            if (_BeerCache == null || DateTime.Now.Subtract(_BeerCache.LatestUpdateTime).Minutes > cacheTimeoutMinutes)
            {
                _BeerCache = await _BreweryApiService.GetAsync();
                _BeerCache.LatestUpdateTime = DateTime.Now;
            }

            return _BeerCache;
        }
    }
}
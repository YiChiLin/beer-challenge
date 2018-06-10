using System.Threading.Tasks;

namespace BeerChallenge.Services
{
    public interface IApiService<TOut>
    {
        Task<TOut> GetAsync();
    }
}
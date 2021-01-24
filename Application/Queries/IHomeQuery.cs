using System.Threading;
using System.Threading.Tasks;
using Application.Models;

namespace Application.Queries
{
    public interface IHomeQuery
    {
        Task<HomeModel> GetHomeModel(CancellationToken cancellationToken = default);
    }
}
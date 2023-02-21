using HackerRank.Monitoring.Domain.Models;

namespace HackerRank.Monitoring.Domain.IRepositories
{
    public interface IRatingsRepository
    {
        Task<IList<Ratings>> GetRatings();
        Task<Ratings> GetRatingsbyId(int id);
        Task PostRatings(Ratings ratings);
        Task UpdateRatings(int R_Id, Ratings ratings);
        Task DeleteRatings(Ratings ratings);
    }
}

using HackerRank.Monitoring.Domain.IRepositories;
using HackerRank.Monitoring.Domain.Models;
using HackerRank.Monitoring.Infrastructrure.Dbcontexts;
using Microsoft.EntityFrameworkCore;

namespace HackerRank.Monitoring.Infrastructrure.Repositories
{
    public class RatingsRepository : IRatingsRepository
    {
        private readonly HRMonitaringDbContext _hRMonitaringDbContext;
        public RatingsRepository(HRMonitaringDbContext hRMonitaringDbContext)
        {
            _hRMonitaringDbContext = hRMonitaringDbContext;
        }

        public async Task DeleteRatings(Ratings ratings)
        {
            _hRMonitaringDbContext.ratings.Remove(ratings);
            _hRMonitaringDbContext.SaveChangesAsync();
        }

        public async Task<IList<Ratings>> GetRatings()
        {
            return await _hRMonitaringDbContext.ratings.ToListAsync();
        }

        public async Task<Ratings> GetRatingsbyId(int id)
        {
            return await _hRMonitaringDbContext.ratings.FirstOrDefaultAsync(x => x.Rating_Id == id);
        }

        public async Task PostRatings(Ratings ratings)
        {

            _hRMonitaringDbContext.ratings.Add(ratings);
            _hRMonitaringDbContext.SaveChanges();
        }

        public async Task UpdateRatings(int QId, Ratings ratings)
        {
            try
            {
                _hRMonitaringDbContext.ratings.Update(ratings);
                await _hRMonitaringDbContext.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

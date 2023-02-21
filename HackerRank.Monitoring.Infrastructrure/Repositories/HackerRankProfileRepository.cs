using HackerRank.Monitoring.Domain.IRepositories;
using HackerRank.Monitoring.Domain.Models;
using HackerRank.Monitoring.Infrastructrure.Dbcontexts;
using Microsoft.EntityFrameworkCore;

namespace HackerRank.Monitoring.Infrastructrure.Repositories
{
    public class HackerRankProfileRepository : IHackerRankProfileRepository
    {
        private readonly HRMonitaringDbContext _hRMonitaringDbContext;

        public HackerRankProfileRepository(HRMonitaringDbContext hRMonitaringDbContext)
        {
            this._hRMonitaringDbContext = hRMonitaringDbContext;
        }

        public async Task<IList<HackerRank_Profile>> GetHackerRank_Profile()
        {
            return await _hRMonitaringDbContext.hackerRank_Profiles.ToListAsync();
        }

        public async Task<HackerRank_Profile> GetHackerRank_ProfilebyId(int userid)
        {
            return await _hRMonitaringDbContext.hackerRank_Profiles.FirstOrDefaultAsync(x => x.User_Id == userid);
        }

        public async Task<int> PostHackerRank_Profile(HackerRank_Profile hackerRank_Profile)
        {
            var userEntity = await _hRMonitaringDbContext.hackerRank_Profiles.FirstOrDefaultAsync(x => x.HR_Email == hackerRank_Profile.HR_Email);
            if (userEntity == null)
            {
                _hRMonitaringDbContext.hackerRank_Profiles.AddAsync(hackerRank_Profile);
                _hRMonitaringDbContext.SaveChangesAsync();
                return 1;
            }
            return 0;
        }

        public void UpdateHackerRankProfile(int userId, HackerRank_Profile hackerRank_Profile)
        {
            try
            {
                _hRMonitaringDbContext.hackerRank_Profiles.Update(hackerRank_Profile);
                _hRMonitaringDbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task DeleteHackerRankProfile(HackerRank_Profile hackerRank_Profile)
        {
            _hRMonitaringDbContext.hackerRank_Profiles.Remove(hackerRank_Profile);
            await _hRMonitaringDbContext.SaveChangesAsync();
        }

        public async Task<HackerRank_Profile> GetHackerRankProfileByEmail(string email)
        {
            return await _hRMonitaringDbContext.hackerRank_Profiles.FirstOrDefaultAsync(x => x.HR_Email == email);
        }
    }
}

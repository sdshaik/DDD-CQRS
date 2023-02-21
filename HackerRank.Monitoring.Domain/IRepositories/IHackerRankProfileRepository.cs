using HackerRank.Monitoring.Domain.Models;

namespace HackerRank.Monitoring.Domain.IRepositories
{
    public interface IHackerRankProfileRepository
    {
        Task<IList<HackerRank_Profile>> GetHackerRank_Profile();
        Task<HackerRank_Profile> GetHackerRank_ProfilebyId(int id);
        Task<int> PostHackerRank_Profile(HackerRank_Profile hackerRank_Profile);
        void UpdateHackerRankProfile(int userId, HackerRank_Profile hackerRank_Profile);
        Task DeleteHackerRankProfile(HackerRank_Profile hackerRank_Profile);
        Task<HackerRank_Profile> GetHackerRankProfileByEmail(string email);
    }
}

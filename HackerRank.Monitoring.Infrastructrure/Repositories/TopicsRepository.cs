using HackerRank.Monitoring.Domain.IRepositories;
using HackerRank.Monitoring.Domain.Models;
using HackerRank.Monitoring.Infrastructrure.Dbcontexts;
using Microsoft.EntityFrameworkCore;

namespace HackerRank.Monitoring.Infrastructrure.Repositories
{
    public class TopicsRepository : ITopicsRepository
    {
        private readonly HRMonitaringDbContext _hRMonitaringDbContext;
        public TopicsRepository(HRMonitaringDbContext hRMonitaringDbContext)
        {
            _hRMonitaringDbContext = hRMonitaringDbContext;
        }

        public async Task<IList<Topics>> GetTopics()
        {
            return await _hRMonitaringDbContext.topics.ToListAsync();
        }

        public async Task PostTopic(Topics topics)
        {
            var entity = await _hRMonitaringDbContext.topics.AddAsync(topics);
            await _hRMonitaringDbContext.SaveChangesAsync();
        }
    }
}

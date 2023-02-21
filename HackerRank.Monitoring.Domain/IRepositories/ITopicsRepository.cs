using HackerRank.Monitoring.Domain.Models;

namespace HackerRank.Monitoring.Domain.IRepositories
{
    public interface ITopicsRepository
    {
        Task<IList<Topics>> GetTopics();
        Task PostTopic(Topics topics);
    }
}

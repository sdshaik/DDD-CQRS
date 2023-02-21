using HackerRank.Monitoring.Api.Query.TopicsQuery;
using HackerRank.Monitoring.Domain.IRepositories;
using HackerRank.Monitoring.Domain.Models;
using MediatR;

namespace HackerRank.Monitoring.Api.QueryHandler.TopicsQuery
{
    public class GetTopicsQueryHandler : IRequestHandler<GetTopicsQuery, IList<Topics>>
    {
        private readonly ITopicsRepository _topicsRepository;
        public GetTopicsQueryHandler(ITopicsRepository topicsRepository)
        {
            _topicsRepository = topicsRepository;
        }
        Task<IList<Topics>> IRequestHandler<GetTopicsQuery, IList<Topics>>.Handle(GetTopicsQuery request, CancellationToken cancellationToken)
        {
            var profile = _topicsRepository.GetTopics();
            return profile;
        }
    }
}

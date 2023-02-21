using HackerRank.Monitoring.Api.Query.HackerRankProfileQuery;
using HackerRank.Monitoring.Domain.IRepositories;
using HackerRank.Monitoring.Domain.Models;
using MediatR;

namespace HackerRank.Monitoring.Api.QueryHandler.HackerRankProfileQuery
{
    public class GethackerRankProfileQueryHandler : IRequestHandler<GethackerRankProfileQuery, IList<HackerRank_Profile>>
    {
        private readonly IHackerRankProfileRepository _hackerRankProfileRepository;
        public GethackerRankProfileQueryHandler(IHackerRankProfileRepository hackerRankProfileRepository)
        {
            _hackerRankProfileRepository = hackerRankProfileRepository;
        }
        public async Task<IList<HackerRank_Profile>> Handle(GethackerRankProfileQuery request, CancellationToken cancellationToken)
        {
            var profile = await _hackerRankProfileRepository.GetHackerRank_Profile();
            return profile;
        }
    }
}

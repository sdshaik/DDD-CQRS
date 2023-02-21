using HackerRank.Monitoring.Api.Query.HackerRankProfileQuery;
using HackerRank.Monitoring.Domain.IRepositories;
using HackerRank.Monitoring.Domain.Models;
using MediatR;

namespace HackerRank.Monitoring.Api.QueryHandler.HackerRankProfileQueryHandlers
{
    public class GetHackerRankProfileByEmailQueryHandler : IRequestHandler<GetHackerRankProfileByEmailQuery, HackerRank_Profile>
    {
        private readonly IHackerRankProfileRepository _hackerRankProfileRepository;

        public GetHackerRankProfileByEmailQueryHandler(IHackerRankProfileRepository hackerRankProfileRepository)
        {
            _hackerRankProfileRepository = hackerRankProfileRepository;
        }

        public async Task<HackerRank_Profile> Handle(GetHackerRankProfileByEmailQuery request, CancellationToken cancellationToken)
        {
            var profile = await _hackerRankProfileRepository.GetHackerRankProfileByEmail(request.Email);
            return profile;
        }
    }
}

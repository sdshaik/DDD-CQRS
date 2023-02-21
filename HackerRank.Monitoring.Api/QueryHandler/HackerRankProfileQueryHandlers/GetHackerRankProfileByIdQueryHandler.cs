using HackerRank.Monitoring.Api.Query.HackerRankProfileQuery;
using HackerRank.Monitoring.Domain.IRepositories;
using HackerRank.Monitoring.Domain.Models;
using MediatR;

namespace HackerRank.Monitoring.Api.QueryHandler.HackerRankProfileQuery
{
    public class GetHackerRankProfileByIdQueryHandler : IRequestHandler<GetHackerRankProfileByIdQuery, HackerRank_Profile>
    {
        private readonly IHackerRankProfileRepository _hackerRankProfileRepository;

        public GetHackerRankProfileByIdQueryHandler(IHackerRankProfileRepository hackerRankProfileRepository)
        {
            _hackerRankProfileRepository = hackerRankProfileRepository;
        }

        public async Task<HackerRank_Profile> Handle(GetHackerRankProfileByIdQuery request, CancellationToken cancellationToken)
        {
            var profile = await _hackerRankProfileRepository.GetHackerRank_ProfilebyId(request.Id);
            return profile;
        }
    }
}

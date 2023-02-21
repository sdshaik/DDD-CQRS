using HackerRank.Monitoring.Api.Query.RatingsQuery;
using HackerRank.Monitoring.Domain.IRepositories;
using HackerRank.Monitoring.Domain.Models;
using MediatR;

namespace HackerRank.Monitoring.Api.QueryHandler.RatingsQuery
{
    public class GetRatingsByIdQueryHandlers : IRequestHandler<GetRatingsByIdQuery, Ratings>
    {
        private readonly IRatingsRepository _ratingsRepository;

        public GetRatingsByIdQueryHandlers(IRatingsRepository ratingsRepository)
        {
            _ratingsRepository = ratingsRepository;
        }

        public async Task<Ratings> Handle(GetRatingsByIdQuery request, CancellationToken cancellationToken)
        {
            var profile = await _ratingsRepository.GetRatingsbyId(request.Id);
            return profile;
        }
    }
}

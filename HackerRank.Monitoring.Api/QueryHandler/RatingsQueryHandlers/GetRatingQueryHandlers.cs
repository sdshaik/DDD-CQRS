using HackerRank.Monitoring.Api.Query.RatingsQuery;
using HackerRank.Monitoring.Domain.IRepositories;
using HackerRank.Monitoring.Domain.Models;
using MediatR;

namespace HackerRank.Monitoring.Api.QueryHandler.RatingsQuery
{
    public class GetRatingQueryHandlers : IRequestHandler<GetRatingsQuery, IList<Ratings>>
    {
        private readonly IRatingsRepository _ratingRepository;
        public GetRatingQueryHandlers(IRatingsRepository ratingsRepository)
        {
            _ratingRepository = ratingsRepository;
        }
        public async Task<IList<Ratings>> Handle(GetRatingsQuery request, CancellationToken cancellationToken)
        {
            var profile = await _ratingRepository.GetRatings();
            return profile;
        }
    }
}

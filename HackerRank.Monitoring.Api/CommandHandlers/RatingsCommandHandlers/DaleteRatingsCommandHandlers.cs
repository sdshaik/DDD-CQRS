using HackerRank.Monitoring.Domain.IRepositories;
using HackerRank.Monitoring.Domain.Models;
using MediatR;

namespace HackerRank.Monitoring.Api.Commands.RatingsCommands
{
    public class DaleteRatingsCommandHandlers : IRequestHandler<DaleteRatingsCommand, Ratings>
    {
        private readonly IRatingsRepository _ratingsRepository;
        public DaleteRatingsCommandHandlers(IRatingsRepository ratingsRepository)
        {
            _ratingsRepository = ratingsRepository;
        }

        public async Task<Ratings> Handle(DaleteRatingsCommand request, CancellationToken cancellationToken)
        {
            var ratings = await _ratingsRepository.GetRatingsbyId(request.Id);
            if (ratings == null)
            {
                return default;
            }
            _ratingsRepository.DeleteRatings(ratings);
            return ratings;
        }
    }
}

using HackerRank.Monitoring.Domain.IRepositories;
using HackerRank.Monitoring.Domain.Models;
using MediatR;

namespace HackerRank.Monitoring.Api.Commands.RatingsCommands
{
    public class SetRatingsCommandHandlers : IRequestHandler<SetRatingsCommand, int>
    {
        private readonly IRatingsRepository _ratingsRepository;
        public SetRatingsCommandHandlers(IRatingsRepository ratingsRepository)
        {
            _ratingsRepository = ratingsRepository;
        }
        public async Task<int> Handle(SetRatingsCommand request, CancellationToken cancellationToken)
        {
            var ratings = new Ratings().Setratings(request.Submitted_Date, request.Time_Took, request.Rating, request.Topic_Id, request.Qus_Id);
            await _ratingsRepository.PostRatings(ratings);
            return ratings.Rating_Id;
        }
    }
}

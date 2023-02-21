using HackerRank.Monitoring.Domain.IRepositories;
using MediatR;

namespace HackerRank.Monitoring.Api.Commands.RatingsCommands
{
    public class UpdateRatingsCommandHandlers : IRequestHandler<UpdateRatingsCommand, int>
    {
        private readonly IRatingsRepository _ratingsRepository;
        public UpdateRatingsCommandHandlers(IRatingsRepository ratingsRepository)
        {
            _ratingsRepository = ratingsRepository;
        }
        public async Task<int> Handle(UpdateRatingsCommand request, CancellationToken cancellationToken)
        {
            var ratings = await _ratingsRepository.GetRatingsbyId(request.Rating_Id);
            ratings.Setratings(request.Submitted_Date, request.Time_Took, request.Rating, request.Topic_Id, request.Qus_Id);
            _ratingsRepository.UpdateRatings(request.Rating_Id, ratings);
            return ratings.Rating_Id;
        }
    }
}

using HackerRank.Monitoring.Api.Commands.HackerRankProfileCommands;
using HackerRank.Monitoring.Domain.IRepositories;
using MediatR;

namespace HackerRank.Monitoring.Api.CommandHandlers.HackerRankProfileCommandHandler
{

    public class UpdateHackerRankProfileCommandHandler : IRequestHandler<putHackerRankProfileCommand, int>
    {
        private readonly IHackerRankProfileRepository _hackerRankProfileRepository;
        public UpdateHackerRankProfileCommandHandler(IHackerRankProfileRepository hackerRankProfileRepository)
        {
            _hackerRankProfileRepository = hackerRankProfileRepository;
        }
        public async Task<int> Handle(putHackerRankProfileCommand request, CancellationToken cancellationToken)
        {
            var hackerRank_Profile = await _hackerRankProfileRepository.GetHackerRank_ProfilebyId(request.User_Id);
            hackerRank_Profile.SetHackerRank_Profile(request.HR_UserName, request.HR_Email, request.HR_Badges);
            _hackerRankProfileRepository.UpdateHackerRankProfile(request.User_Id, hackerRank_Profile);
            return hackerRank_Profile.User_Id;
        }
    }
}

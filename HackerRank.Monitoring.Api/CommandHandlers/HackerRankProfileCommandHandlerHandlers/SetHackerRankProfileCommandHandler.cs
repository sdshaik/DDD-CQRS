using HackerRank.Monitoring.Api.Commands.HackerRankProfileCommands;
using HackerRank.Monitoring.Domain.IRepositories;
using HackerRank.Monitoring.Domain.Models;
using MediatR;

namespace HackerRank.Monitoring.Api.CommandHandlers.HackerRankProfileCommandHandler
{
    public class SetHackerRankProfileCommandHandler : IRequestHandler<SetHackerRankProfileCommand, int>
    {
        private readonly IHackerRankProfileRepository _hackerRankProfileRepository;
        public SetHackerRankProfileCommandHandler(IHackerRankProfileRepository hackerRankProfileRepository)
        {
            _hackerRankProfileRepository = hackerRankProfileRepository;
        }
        public async Task<int> Handle(SetHackerRankProfileCommand request, CancellationToken cancellationToken)
        {
            var hackerRank_Profile = new HackerRank_Profile().SetHackerRank_Profile(request.HR_UserName, request.HR_Email, request.HR_Badges);
            int user = await _hackerRankProfileRepository.PostHackerRank_Profile(hackerRank_Profile);
            if (user == 1)
            {
                return hackerRank_Profile.User_Id;
            }
            return user;

        }
    }
}

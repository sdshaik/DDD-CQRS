using HackerRank.Monitoring.Api.Commands.HackerRankProfileCommands;
using HackerRank.Monitoring.Domain.IRepositories;
using HackerRank.Monitoring.Domain.Models;
using MediatR;

namespace HackerRank.Monitoring.Api.CommandHandlers.HackerRankProfileCommandHandler
{
    public class DeleteHackerRankProfileCommandHandler : IRequestHandler<DeleteHackerRankProfileCommand, HackerRank_Profile>
    {
        private readonly IHackerRankProfileRepository _hackerRankProfileRepository;
        public DeleteHackerRankProfileCommandHandler(IHackerRankProfileRepository hackerRankProfileRepository)
        {
            _hackerRankProfileRepository = hackerRankProfileRepository;
        }

        public async Task<HackerRank_Profile> Handle(DeleteHackerRankProfileCommand request, CancellationToken cancellationToken)
        {
            var hackerRank_Profile = await _hackerRankProfileRepository.GetHackerRank_ProfilebyId(request.User_Id);
            if (hackerRank_Profile == null)
            {
                return default;
            }
            _hackerRankProfileRepository.DeleteHackerRankProfile(hackerRank_Profile);
            return hackerRank_Profile;
        }
    }
}
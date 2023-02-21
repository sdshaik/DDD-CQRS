using HackerRank.Monitoring.Domain.Models;
using MediatR;

namespace HackerRank.Monitoring.Api.Commands.HackerRankProfileCommands
{
    public class DeleteHackerRankProfileCommand : IRequest<HackerRank_Profile>
    {
        public int User_Id { get; set; }
    }
}

using MediatR;
using System.ComponentModel.DataAnnotations;

namespace HackerRank.Monitoring.Api.Commands.HackerRankProfileCommands
{
    public class SetHackerRankProfileCommand : IRequest<int>
    {
        public string? HR_UserName { get; set; }
        [Required]
        [EmailAddress]
        public string HR_Email { get; set; }
        public int HR_Badges { get; set; }
    }
}

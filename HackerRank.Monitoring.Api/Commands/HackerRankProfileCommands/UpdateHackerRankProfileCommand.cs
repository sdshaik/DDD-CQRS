using MediatR;
using System.ComponentModel.DataAnnotations;

namespace HackerRank.Monitoring.Api.Commands.HackerRankProfileCommands
{
    public class putHackerRankProfileCommand : IRequest<int>
    {
        public int User_Id { get; set; }
        public string? HR_UserName { get; set; }
        [Required]
        [EmailAddress]
        public string HR_Email { get; set; }
        public int HR_Badges { get; set; }
    }
}

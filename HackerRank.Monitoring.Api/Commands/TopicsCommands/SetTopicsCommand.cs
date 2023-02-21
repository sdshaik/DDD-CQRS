using MediatR;
using System.ComponentModel.DataAnnotations;

namespace HackerRank.Monitoring.Api.Commands.TopicsCommands
{
    public class SetTopicsCommand : IRequest<int>
    {
        [Required]
        public string Topic { get; set; }
    }
}

using MediatR;
using System.ComponentModel.DataAnnotations;

namespace HackerRank.Monitoring.Api.Commands.AlgorithmQuestionsCommands
{
    public class SetAlgorithmQuestionsCommand : IRequest<int>
    {
        [Required]
        public string? Qus_Level { get; set; }
        [Required]
        public string Question { get; set; }
        public int Topic_Id { get; set; }
    }
}

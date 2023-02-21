using MediatR;
using System.ComponentModel.DataAnnotations;

namespace HackerRank.Monitoring.Api.Commands.AlgorithmQuestionsCommands
{
    public class PutAlgorithmQuestionsCommand : IRequest<int>
    {
        public int Qus_Id { get; set; }
        [Required]
        public string? Qus_Level { get; set; }
        [Required]
        public string Question { get; set; }
        public int Topic_Id { get; set; }
    }
}

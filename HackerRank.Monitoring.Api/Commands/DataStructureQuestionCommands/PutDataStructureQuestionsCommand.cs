using MediatR;
using System.ComponentModel.DataAnnotations;

namespace HackerRank.Monitoring.Api.Commands.DataStructureQuestionCommands
{
    public class PutDataStructureQuestionsCommand : IRequest<int>
    {
        public int Qus_Id { get; set; }
        [Required]
        public string? Qus_Level { get; set; }
        [Required]
        public string Question { get; set; }
        public int Topic_Id { get; set; }
    }
}

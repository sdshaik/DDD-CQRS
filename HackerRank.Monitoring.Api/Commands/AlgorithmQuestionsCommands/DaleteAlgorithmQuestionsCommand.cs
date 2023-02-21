using HackerRank.Monitoring.Domain.Models;
using MediatR;

namespace HackerRank.Monitoring.Api.Commands.AlgorithmQuestionsCommands
{
    public class DaleteAlgorithmQuestionsCommand : IRequest<Algorithm_Questions>
    {
        public int Qus_Id { get; set; }
    }
}

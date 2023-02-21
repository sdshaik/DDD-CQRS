using HackerRank.Monitoring.Domain.Models;
using MediatR;

namespace HackerRank.Monitoring.Api.Commands.DataStructureQuestionCommands
{
    public class DaleteDataStructureQuestionsCommand : IRequest<DataStructure_Questions>
    {
        public int Qus_Id { get; set; }
    }
}

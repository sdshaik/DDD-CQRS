using HackerRank.Monitoring.Domain.Models;
using MediatR;

namespace HackerRank.Monitoring.Api.Query.DataStructureQuestionsQuery
{
    public class GetDataStructureQuestionsByIdQuery : IRequest<DataStructure_Questions>
    {
        public int Id { get; set; }
    }
}

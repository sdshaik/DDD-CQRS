using HackerRank.Monitoring.Domain.Models;
using MediatR;

namespace HackerRank.Monitoring.Api.Query.DataStructureQuestionsQuery
{
    public class GetDataStructureQuestionsQuery : IRequest<IList<DataStructure_Questions>>
    {
    }
}

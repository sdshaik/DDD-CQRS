using HackerRank.Monitoring.Domain.Models;
using MediatR;

namespace HackerRank.Monitoring.Api.Query.AlgorithmQuestionsQuery
{
    public class GetAlgorithmQuesionsQuery : IRequest<IList<Algorithm_Questions>>
    {
    }
}

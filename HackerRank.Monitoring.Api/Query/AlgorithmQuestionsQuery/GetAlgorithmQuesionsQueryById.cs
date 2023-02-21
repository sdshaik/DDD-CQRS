using HackerRank.Monitoring.Domain.Models;
using MediatR;

namespace HackerRank.Monitoring.Api.Query.AlgorithmQuestionsQuery
{
    public class GetAlgorithmQuesionsQueryById : IRequest<Algorithm_Questions>
    {
        public int Id { get; set; }
    }
}

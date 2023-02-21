using HackerRank.Monitoring.Api.Query.AlgorithmQuestionsQuery;
using HackerRank.Monitoring.Domain.IRepositories;
using HackerRank.Monitoring.Domain.Models;
using MediatR;

namespace HackerRank.Monitoring.Api.QueryHandler.AlgorithmQuestionsQuery
{
    public class GetAlgorithmQuestionsQueryHandler : IRequestHandler<GetAlgorithmQuesionsQuery, IList<Algorithm_Questions>>
    {
        private readonly IAlgorithmQuestionsRepository _algorithmQuestionsRepository;
        public GetAlgorithmQuestionsQueryHandler(IAlgorithmQuestionsRepository algorithmQuestionsRepository)
        {
            _algorithmQuestionsRepository = algorithmQuestionsRepository;
        }
        public async Task<IList<Algorithm_Questions>> Handle(GetAlgorithmQuesionsQuery request, CancellationToken cancellationToken)
        {
            var profile = await _algorithmQuestionsRepository.GetAlgorithmQuestions();
            return profile;
        }
    }
}

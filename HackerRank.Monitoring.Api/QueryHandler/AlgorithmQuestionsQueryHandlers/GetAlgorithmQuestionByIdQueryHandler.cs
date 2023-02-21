using HackerRank.Monitoring.Api.Query.AlgorithmQuestionsQuery;
using HackerRank.Monitoring.Domain.IRepositories;
using HackerRank.Monitoring.Domain.Models;
using MediatR;

namespace HackerRank.Monitoring.Api.QueryHandler.AlgorithmQuestionsQuery
{
    public class GetAlgorithmQuestionByIdQueryHandler : IRequestHandler<GetAlgorithmQuesionsQueryById, Algorithm_Questions>
    {
        private readonly IAlgorithmQuestionsRepository _algorithmQuestionsRepository;

        public GetAlgorithmQuestionByIdQueryHandler(IAlgorithmQuestionsRepository algorithmQuestionsRepository)
        {
            _algorithmQuestionsRepository = algorithmQuestionsRepository;
        }

        public async Task<Algorithm_Questions> Handle(GetAlgorithmQuesionsQueryById request, CancellationToken cancellationToken)
        {
            var profile = await _algorithmQuestionsRepository.GetAlgorithmQuestionsbyId(request.Id);
            return profile;
        }
    }
}

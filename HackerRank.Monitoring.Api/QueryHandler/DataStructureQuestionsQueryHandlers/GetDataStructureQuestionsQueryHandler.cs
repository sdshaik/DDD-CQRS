using HackerRank.Monitoring.Api.Query.DataStructureQuestionsQuery;
using HackerRank.Monitoring.Domain.IRepositories;
using HackerRank.Monitoring.Domain.Models;
using MediatR;

namespace HackerRank.Monitoring.Api.QueryHandler.DataStructureQuestionsQuery
{
    public class GetDataStructureQuestionsQueryHandler : IRequestHandler<GetDataStructureQuestionsQuery, IList<DataStructure_Questions>>
    {
        private readonly IDataStructureQuestionsRepository _dataStructureQuestionsRepository;
        public GetDataStructureQuestionsQueryHandler(IDataStructureQuestionsRepository dataStructureQuestionsRepository)
        {
            _dataStructureQuestionsRepository = dataStructureQuestionsRepository;
        }
        public async Task<IList<DataStructure_Questions>> Handle(GetDataStructureQuestionsQuery request, CancellationToken cancellationToken)
        {
            var profile = await _dataStructureQuestionsRepository.GetDataStructuresQuestions();
            return profile;
        }
    }
}

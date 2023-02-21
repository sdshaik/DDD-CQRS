using HackerRank.Monitoring.Api.Query.DataStructureQuestionsQuery;
using HackerRank.Monitoring.Domain.IRepositories;
using HackerRank.Monitoring.Domain.Models;
using MediatR;

namespace HackerRank.Monitoring.Api.QueryHandler.DataStructureQuestionsQuery
{
    public class GetDataStructureQuestionsByIdQueryHandler : IRequestHandler<GetDataStructureQuestionsByIdQuery, DataStructure_Questions>
    {
        private readonly IDataStructureQuestionsRepository _dataStructureQuestionsRepository;

        public GetDataStructureQuestionsByIdQueryHandler(IDataStructureQuestionsRepository dataStructureQuestionsRepository)
        {
            _dataStructureQuestionsRepository = dataStructureQuestionsRepository;
        }

        public async Task<DataStructure_Questions> Handle(GetDataStructureQuestionsByIdQuery request, CancellationToken cancellationToken)
        {
            var profile = await _dataStructureQuestionsRepository.GetDataStructureQuestionsbyId(request.Id);
            return profile;
        }
    }
}

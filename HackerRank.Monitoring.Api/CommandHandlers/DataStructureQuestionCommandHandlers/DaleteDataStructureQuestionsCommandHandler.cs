using HackerRank.Monitoring.Domain.IRepositories;
using HackerRank.Monitoring.Domain.Models;
using MediatR;

namespace HackerRank.Monitoring.Api.Commands.DataStructureQuestionCommands
{
    public class DaleteDataStructureQuestionsCommandHandler : IRequestHandler<DaleteDataStructureQuestionsCommand, DataStructure_Questions>
    {
        private readonly IDataStructureQuestionsRepository _dataStructureQuestionsRepository;
        public DaleteDataStructureQuestionsCommandHandler(IDataStructureQuestionsRepository dataStructureQuestionsRepository)
        {
            _dataStructureQuestionsRepository = dataStructureQuestionsRepository;
        }

        public async Task<DataStructure_Questions> Handle(DaleteDataStructureQuestionsCommand request, CancellationToken cancellationToken)
        {
            var qus = await _dataStructureQuestionsRepository.GetDataStructureQuestionsbyId(request.Qus_Id);
            if (qus == null)
            {
                return default;
            }
            _dataStructureQuestionsRepository.DeleteDataStructureQuestions(qus);
            return qus;
        }
    }
}

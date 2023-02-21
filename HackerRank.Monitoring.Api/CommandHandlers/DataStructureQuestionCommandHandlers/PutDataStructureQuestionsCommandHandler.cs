using HackerRank.Monitoring.Domain.IRepositories;
using MediatR;

namespace HackerRank.Monitoring.Api.Commands.DataStructureQuestionCommands
{
    public class PutDataStructureQuestionsCommandHandler : IRequestHandler<PutDataStructureQuestionsCommand, int>
    {
        private readonly IDataStructureQuestionsRepository _dataStructureQuestionsRepository;
        public PutDataStructureQuestionsCommandHandler(IDataStructureQuestionsRepository dataStructureQuestionsRepository)
        {
            _dataStructureQuestionsRepository = dataStructureQuestionsRepository;
        }

        public async Task<int> Handle(PutDataStructureQuestionsCommand request, CancellationToken cancellationToken)
        {
            var question = await _dataStructureQuestionsRepository.GetDataStructureQuestionsbyId(request.Qus_Id);
            question.setDataStructure_Questions(request.Qus_Level, request.Question, request.Topic_Id);
            _dataStructureQuestionsRepository.UpdateDataStructureQuestions(request.Qus_Id, question);
            return question.Qus_Id;
        }
    }
}

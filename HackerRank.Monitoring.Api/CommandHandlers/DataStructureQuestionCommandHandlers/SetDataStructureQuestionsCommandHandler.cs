using HackerRank.Monitoring.Domain.IRepositories;
using HackerRank.Monitoring.Domain.Models;
using MediatR;

namespace HackerRank.Monitoring.Api.Commands.DataStructureQuestionCommands
{
    public class SetDataStructureQuestionsCommandHandler : IRequestHandler<SetDataStructureQuestionsCommand, int>
    {
        private readonly IDataStructureQuestionsRepository _dataStructureQuestionsRepository;
        public SetDataStructureQuestionsCommandHandler(IDataStructureQuestionsRepository dataStructureQuestionsRepository)
        {
            _dataStructureQuestionsRepository = dataStructureQuestionsRepository;
        }
        public async Task<int> Handle(SetDataStructureQuestionsCommand request, CancellationToken cancellationToken)
        {
            var question = new DataStructure_Questions().setDataStructure_Questions(request.Qus_Level, request.Question, request.Topic_Id);
            await _dataStructureQuestionsRepository.PostDataStructureQuestions(question);
            return question.Qus_Id;
        }
    }
}

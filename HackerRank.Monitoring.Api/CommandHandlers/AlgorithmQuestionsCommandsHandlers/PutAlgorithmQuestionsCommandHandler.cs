using HackerRank.Monitoring.Domain.IRepositories;
using MediatR;

namespace HackerRank.Monitoring.Api.Commands.AlgorithmQuestionsCommands
{
    public class PutAlgorithmQuestionsCommandHandlers : IRequestHandler<PutAlgorithmQuestionsCommand, int>
    {
        private readonly IAlgorithmQuestionsRepository _algorithmQuestionsRepository;
        public PutAlgorithmQuestionsCommandHandlers(IAlgorithmQuestionsRepository algorithmQuestionsRepository)
        {
            _algorithmQuestionsRepository = algorithmQuestionsRepository;
        }

        public async Task<int> Handle(PutAlgorithmQuestionsCommand request, CancellationToken cancellationToken)
        {
            var question = await _algorithmQuestionsRepository.GetAlgorithmQuestionsbyId(request.Qus_Id);
            question.setAlgorithmQuestions(request.Qus_Level, request.Question, request.Topic_Id);
            _algorithmQuestionsRepository.UpdateAlgorithmQuestions(request.Qus_Id, question);
            return question.Qus_Id;
        }
    }
}

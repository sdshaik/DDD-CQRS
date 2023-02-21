using HackerRank.Monitoring.Domain.IRepositories;
using HackerRank.Monitoring.Domain.Models;
using MediatR;

namespace HackerRank.Monitoring.Api.Commands.AlgorithmQuestionsCommands
{
    public class SetAlgorithmQuestionsCommandHandler : IRequestHandler<SetAlgorithmQuestionsCommand, int>
    {
        private readonly IAlgorithmQuestionsRepository _algorithmQuestionsRepository;
        public SetAlgorithmQuestionsCommandHandler(IAlgorithmQuestionsRepository algorithmQuestionsRepository)
        {
            _algorithmQuestionsRepository = algorithmQuestionsRepository;
        }
        public async Task<int> Handle(SetAlgorithmQuestionsCommand request, CancellationToken cancellationToken)
        {
            var question = new Algorithm_Questions().setAlgorithmQuestions(request.Qus_Level, request.Question, request.Topic_Id);
            await _algorithmQuestionsRepository.PostAlgorithmQuestions(question);
            return question.Qus_Id;
        }
    }
}

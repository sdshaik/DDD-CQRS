using HackerRank.Monitoring.Domain.IRepositories;
using HackerRank.Monitoring.Domain.Models;
using MediatR;

namespace HackerRank.Monitoring.Api.Commands.AlgorithmQuestionsCommands
{
    public class DaleteAlgorithmQuestionsCommandHandlers : IRequestHandler<DaleteAlgorithmQuestionsCommand, Algorithm_Questions>
    {
        private readonly IAlgorithmQuestionsRepository _algorithmQuestionsRepository;
        public DaleteAlgorithmQuestionsCommandHandlers(IAlgorithmQuestionsRepository algorithmQuestionsRepository)
        {
            _algorithmQuestionsRepository = algorithmQuestionsRepository;
        }

        public async Task<Algorithm_Questions> Handle(DaleteAlgorithmQuestionsCommand request, CancellationToken cancellationToken)
        {
            var qus = await _algorithmQuestionsRepository.GetAlgorithmQuestionsbyId(request.Qus_Id);
            if (qus == null)
            {
                return default;
            }
            _algorithmQuestionsRepository.DeleteAlgorithmQuestions(qus);
            return qus;
        }
    }
}

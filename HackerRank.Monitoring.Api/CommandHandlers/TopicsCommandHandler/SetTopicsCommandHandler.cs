using HackerRank.Monitoring.Api.Commands.TopicsCommands;
using HackerRank.Monitoring.Domain.IRepositories;
using HackerRank.Monitoring.Domain.Models;
using MediatR;

namespace HackerRank.Monitoring.Api.CommandHandlers.TopicsCommandHandler
{
    public class SetTopicsCommandHandler : IRequestHandler<SetTopicsCommand, int>
    {
        private readonly ITopicsRepository _topicsRepository;
        public SetTopicsCommandHandler(ITopicsRepository topicsRepository)
        {
            _topicsRepository = topicsRepository;
        }
        public async Task<int> Handle(SetTopicsCommand request, CancellationToken cancellationToken)
        {
            var topic = new Topics().SetTopics(request.Topic);
            await _topicsRepository.PostTopic(topic);
            return topic.Topic_Id;
        }
    }
}


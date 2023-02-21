using HackerRank.Monitoring.Domain.Models;
using MediatR;

namespace HackerRank.Monitoring.Api.Query.TopicsQuery
{
    public class GetTopicsQuery : IRequest<IList<Topics>>
    {
    }
}

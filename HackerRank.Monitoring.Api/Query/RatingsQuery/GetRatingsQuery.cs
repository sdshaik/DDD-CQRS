using HackerRank.Monitoring.Domain.Models;
using MediatR;

namespace HackerRank.Monitoring.Api.Query.RatingsQuery
{
    public class GetRatingsQuery : IRequest<IList<Ratings>>
    {
    }
}

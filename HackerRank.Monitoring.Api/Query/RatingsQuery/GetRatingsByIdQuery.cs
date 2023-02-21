using HackerRank.Monitoring.Domain.Models;
using MediatR;

namespace HackerRank.Monitoring.Api.Query.RatingsQuery
{
    public class GetRatingsByIdQuery : IRequest<Ratings>
    {
        public int Id { get; set; }
    }
}

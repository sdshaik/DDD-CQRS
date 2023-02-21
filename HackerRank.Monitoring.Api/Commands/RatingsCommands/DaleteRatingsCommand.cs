using HackerRank.Monitoring.Domain.Models;
using MediatR;

namespace HackerRank.Monitoring.Api.Commands.RatingsCommands
{
    public class DaleteRatingsCommand : IRequest<Ratings>
    {
        public int Id { get; set; }
    }
}

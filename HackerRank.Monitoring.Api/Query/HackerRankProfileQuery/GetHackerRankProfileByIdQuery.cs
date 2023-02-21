using HackerRank.Monitoring.Domain.Models;
using MediatR;

namespace HackerRank.Monitoring.Api.Query.HackerRankProfileQuery
{
    public class GetHackerRankProfileByIdQuery : IRequest<HackerRank_Profile>
    {
        public int Id { get; set; }
    }
}

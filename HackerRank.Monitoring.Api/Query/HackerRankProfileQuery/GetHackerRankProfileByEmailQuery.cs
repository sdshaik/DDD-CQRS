using HackerRank.Monitoring.Domain.Models;
using MediatR;

namespace HackerRank.Monitoring.Api.Query.HackerRankProfileQuery
{
    public class GetHackerRankProfileByEmailQuery : IRequest<HackerRank_Profile>
    {
        public string Email { get; set; }
    }
}

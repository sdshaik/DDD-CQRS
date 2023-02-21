using HackerRank.Monitoring.Domain.Models;
using MediatR;

namespace HackerRank.Monitoring.Api.Query.HackerRankProfileQuery
{
    public record GethackerRankProfileQuery : IRequest<IList<HackerRank_Profile>>
    {
    }
}

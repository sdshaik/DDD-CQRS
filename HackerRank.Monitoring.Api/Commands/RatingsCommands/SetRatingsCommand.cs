using MediatR;

namespace HackerRank.Monitoring.Api.Commands.RatingsCommands
{
    public class SetRatingsCommand : IRequest<int>
    {
        public DateTime Submitted_Date { get; set; }
        public string Time_Took { get; set; }
        public string Rating { get; set; }
        public int Topic_Id { get; set; }
        public int? Qus_Id { get; set; }
    }
}

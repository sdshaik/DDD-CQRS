using MediatR;

namespace HackerRank.Monitoring.Api.Commands.RatingsCommands
{
    public class UpdateRatingsCommand : IRequest<int>
    {
        public int Rating_Id { get; set; }
        public DateTime Submitted_Date { get; set; }
        public string Time_Took { get; set; }
        public string Rating { get; set; }
        public int Topic_Id { get; set; }
        public int Qus_Id { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace HackerRank.Monitoring.Domain.Models
{
    public class Ratings
    {
        [Key]
        public int Rating_Id { get; private set; }
        public DateTime Submitted_Date { get; private set; }
        public string Time_Took { get; private set; }
        public string Rating { get; private set; }
        public int Topic_Id { get; private set; }
        [ForeignKey("Topic_Id")]
        [JsonIgnore]
        public virtual Topics Topics { get; set; }
        public int? Qus_Id { get; private set; }
        [ForeignKey("Qus_Id")]
        [JsonIgnore]
        public virtual DataStructure_Questions DataStructure_Questions { get; set; }

        public Ratings Setratings(DateTime submited_date, string time_took, string ratings, int topicId, int? QusId)
        {
            submited_date = DateTime.UtcNow;
            Time_Took = time_took;
            Topic_Id = topicId;
            Rating = ratings;
            Qus_Id = QusId;
            return this;
        }
    }
}

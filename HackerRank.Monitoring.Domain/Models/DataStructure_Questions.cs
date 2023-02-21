using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace HackerRank.Monitoring.Domain.Models
{
    public class DataStructure_Questions
    {
        [Key]
        public int Qus_Id { get; private set; }
        [Required]
        public string? Qus_Level { get; private set; }
        [Required]
        public string Question { get; private set; }
        public int Topic_Id { get; private set; }
        [ForeignKey("Topic_Id")]
        [JsonIgnore]
        public virtual Topics Topics { get; set; }

        public DataStructure_Questions setDataStructure_Questions(string qusLevel, string qus, int topicId)
        {
            Qus_Level = qusLevel;
            Question = qus;
            Topic_Id = topicId;
            return this;
        }
    }
}

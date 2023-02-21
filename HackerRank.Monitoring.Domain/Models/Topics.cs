using System.ComponentModel.DataAnnotations;

namespace HackerRank.Monitoring.Domain.Models
{
    public class Topics
    {
        [Key]
        public int Topic_Id { get; private set; }
        [Required]
        public string Topic { get; private set; }

        public Topics SetTopics(string topic)
        {
            Topic = topic;
            return this;
        }
    }
}

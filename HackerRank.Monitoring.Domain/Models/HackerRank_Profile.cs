using System.ComponentModel.DataAnnotations;

namespace HackerRank.Monitoring.Domain.Models
{
    public class HackerRank_Profile
    {
        [Key]
        public int User_Id { get; private set; }
        public string? HR_UserName { get; private set; }
        [Required]
        [EmailAddress]
        public string HR_Email { get; private set; }
        public int HR_Badges { get; private set; }

        public HackerRank_Profile SetHackerRank_Profile(string userName, string email, int badges)
        {
            HR_UserName = userName;
            HR_Email = email;
            HR_Badges = badges;
            return this;
        }
    }
}

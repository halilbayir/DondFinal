using System.Collections.Generic;

namespace Dond.Models
{
    public class User : BaseEntity
    {
        public string Email { get; set; }
        public string Username { get; set; }
        public string Passwords { get; set; }
        public int CurrentSession { get; set; }

        public virtual ICollection<UserProgress> UserProgress { get; set; }
        public virtual ICollection<UserAchievement> UserAchievement { get; set; }
        public virtual ICollection<HighScore> UserHighScore { get; set; }

        public User()
        {
           UserProgress = new List<UserProgress>();
           UserAchievement = new List<UserAchievement>();
           UserHighScore = new List<HighScore>();
        }
    }
}

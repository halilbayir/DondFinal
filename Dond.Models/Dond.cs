using System.Data.Entity;

namespace Dond.Models
{
    public class DondDBContext : DbContext
    {
        //TODO Dbset leri ayarlayacaksınız.
        public DondDBContext() { }

        public DbSet<User> Users { get; set; }
        public DbSet<UserAchievement> UserAchievements { get; set; }
        public DbSet<UserProgress> UserProgresses { get; set; }
        public DbSet<HighScore> HighScores { get; set; }
        public DbSet<Puzzle> Puzzles { get; set; }

    }
}

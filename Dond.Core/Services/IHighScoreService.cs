using Dond.Core.Services;
using System.Collections.Generic;
using System.Linq;
using Dond.Models;

namespace dond.Core.Services
{
    public interface IHighScoreService
    {
        bool AddHighScore(HighScore hs);
        float GetUserHighScore(int userId);
        List<HighScore> GetAllHighScore();
    }
    public class HighScoreService : BaseService, IHighScoreService
    {
        public HighScoreService(DondDBContext context) : base(context) { }
        public bool AddHighScore(HighScore hs)
        {
            var userHighScore = Context.HighScores.FirstOrDefault(x => x.UserId == hs.UserId);
            if (userHighScore == null || !(userHighScore.Score > hs.Score)) return false;
            Context.HighScores.Add(hs);
            Context.SaveChanges();
            return true; 
        }

        public float GetUserHighScore(int userId)
        {
            var userHighScore =
                Context.HighScores.Where(x => x.UserId == userId).OrderByDescending(t => t.UserId).First();
            return userHighScore.Score;
        }

        public List<HighScore> GetAllHighScore()
        {
            return Context.HighScores.ToList();
        }
    }
}

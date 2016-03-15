using Dond.Core.Services;
using System.Collections.Generic;
using System.Linq;
using Dond.Models;

namespace dond.Core.Services
{
    public interface IUserAchievementService
    {
        bool AddUserAchievement(UserAchievement userAchievement);
        List<UserAchievement> GetUserAchievements(int userId);
    }
    public class UserAchievementService : BaseService , IUserAchievementService
    {
        public UserAchievementService(DondDBContext context):base(context) { }

        public bool AddUserAchievement(UserAchievement userAchievement)
        {
            var userAch =
                Context.UserAchievements.FirstOrDefault(
                    x => x.UserId == userAchievement.UserId && x.AchievementId == userAchievement.AchievementId);
            if (userAch != null) return false;
            Context.UserAchievements.Add(userAchievement);
            Context.SaveChanges(); 
            return true;
        }

        public List<UserAchievement> GetUserAchievements(int userId)
        {
            return Context.UserAchievements.Where(x => x.UserId == userId).ToList();
        }
    }
}

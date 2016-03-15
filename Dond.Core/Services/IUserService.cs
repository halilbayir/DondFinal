using System.Linq;
using Dond.Models;
using Dond.Core.Services;

namespace dond.Core.Services
{
    public interface IUserService
    {
        User AddUser(User user);
        User GetUser(int userId);
        bool ChangeUserState(int userId);
    }
    public class UserService : BaseService,IUserService
    {
        public UserService(DondDBContext context) : base(context) { }
        public User AddUser(User user)
        {
            if (Context.Users.Any(x => x.Username.Equals(user.Username) && x.Email.Equals(user.Email) && !x.IsActive))
            {
                user.IsActive = true;
                Context.SaveChanges();
                return user;
            }
            Context.Users.Add(user); 
            Context.SaveChanges();
            return user;
        }

        public User GetUser(int userId)
        {
            return Context.Users.Find(userId);
        }

        public bool ChangeUserState(int userId)
        {
            var user = Context.Users.Find(userId);
            user.IsActive = false;
            Context.SaveChanges();
            return true;
        }
    }

}

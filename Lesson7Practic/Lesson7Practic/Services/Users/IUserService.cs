using Lesson7Practic.Models;

namespace Lesson7Practic.Services.Users
{
    internal interface IUserService
    {
        public User AddUser(User user);
        public User GetUser(User user);
    }
}

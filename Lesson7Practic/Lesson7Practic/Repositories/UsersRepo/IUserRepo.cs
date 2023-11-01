using Lesson7Practic.Models;
using System.ComponentModel.DataAnnotations;

namespace Lesson7Practic.Repositories.UsersRepo
{
    public interface IUserRepo
    {
        public User AddUser(string name, string password);
    }
}

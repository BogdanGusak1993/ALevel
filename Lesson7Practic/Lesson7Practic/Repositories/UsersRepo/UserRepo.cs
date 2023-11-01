using Lesson7Practic.Models;
using System.IO;


namespace Lesson7Practic.Repositories.UsersRepo
{
    public class UserRepo : IUserRepo
    {
        public User AddUser(string name, string password)
        {
            User user = new User();

            user.Name = name;
            user.Password = password;
            user.Id = Guid.NewGuid();

            PutUserDataInXML.LoadDataToXml(user);

            return user;
        }
    }
}

using HW8.Entities;
using HW8.Repositories.Abstractions;
using Microsoft.Extensions.DependencyInjection;


namespace HW8.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly List <UserEntity> _mockStorage;
        public string AddUser(string name, string password)
        {
            var user = new UserEntity()
            {
                Id = Guid.NewGuid().ToString(),
                Name = name,
                Password = password,
            };

            _mockStorage.Add(user);
            return user.Id;
        }

        public UserEntity GetUser(string id)
        {
            foreach (var item in _mockStorage)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }

            return null;
        }
    }
}

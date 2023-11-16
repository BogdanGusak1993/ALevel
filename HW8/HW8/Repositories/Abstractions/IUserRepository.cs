using HW8.Entities;
using Microsoft.Extensions.DependencyInjection;


namespace HW8.Repositories.Abstractions
{
    public interface IUserRepository
    {
        string AddUser(string name, string password);

        UserEntity GetUser(string id);
    }
}


using HW8.Models;
using Microsoft.Extensions.DependencyInjection;

namespace HW8.Serivces.Abstractions
{
    internal interface IUserService
    {
        string AddUser(string firstName, string lastName);
        User GetUser(string id);
    }
}

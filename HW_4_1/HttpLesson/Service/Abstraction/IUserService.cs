using System.Threading.Tasks;
using ALevelSample.Dtos;
using ALevelSample.Dtos.Responses;

namespace ALevelSample.Services.Abstractions;

public interface IUserService
{
    Task<UserDto> GetUserById(int id);
    Task<UserResponse> CreateUser(string name, string job);
    Task<UserDto> DeleteUserById(int id);
    Task<UserDto> GetUsersList();
    Task<UserResponse> UpDateUser(string name, string job);
    Task<UserResponse> PatchUser(string name, string job);
}
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using ALevelSample.Config;
using ALevelSample.Dtos;
using ALevelSample.Dtos.Requests;
using ALevelSample.Dtos.Responses;
using ALevelSample.Services.Abstractions;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace ALevelSample.Services;

public sealed class UserService : IUserService
{
    private readonly IInternalHttpClientService _httpClientService;
    private readonly ILogger<UserService> _logger;
    private readonly ApiOption _options;
    private readonly string _userApi = "api/users";

    public UserService(
        IInternalHttpClientService httpClientService,
        IOptions<ApiOption> options,
        ILogger<UserService> logger)
    {
        _httpClientService = httpClientService;
        _logger = logger;
        _options = options.Value;
    }

    public async Task<UserDto> GetUserById(int id)
    {
      var result = await _httpClientService.SendAsync<BaseResponse<UserDto>, object>($"{_options.Host}{_userApi}/{id}", HttpMethod.Get);

      if (result?.Data != null)
      {
          _logger.LogInformation($"User with id = {result.Data.Id} was found");
      }
        else
        {
            _logger.LogInformation($"{HttpStatusCode.BadRequest}");
        }

        return result?.Data;
    }
    public async Task<UserDto> DeleteUserById(int id)
    {
        var result = await _httpClientService.SendAsync<BaseResponse<UserDto>, object>($"{_options.Host}{_userApi}/{id}", HttpMethod.Delete);

        if (result?.Data != null)
        {
            _logger.LogInformation($"User with id = {result.Data.Id} was deleted");
        }

        return result?.Data;
    }
    public async Task<UserResponse> CreateUser(string name, string job)
    {
        var result = await _httpClientService.SendAsync<UserResponse, UserRequest>(
            $"{_options.Host}{_userApi}",
            HttpMethod.Post,
            new UserRequest()
        {
            Job = job,
            Name = name
        });

        if (result != null)
        {
            _logger.LogInformation($"User with id = {result?.Id} was created");
        }

        return result;
    }
    public async Task<UserDto> GetUsersList()
    {
        var result = await _httpClientService.SendAsync<BaseResponse<UserDto>, object>($"{_options.Host}{_userApi}?page=2", HttpMethod.Get);

        if (result?.Data != null)
        {
            _logger.LogInformation($"List of users");
        }

        return result?.Data;
    }
    public async Task<UserResponse> UpDateUser(string name, string job)
    {
        var result = await _httpClientService.SendAsync<UserResponse, UserRequest>(
            $"{_options.Host}{_userApi}",
            HttpMethod.Put,
            new UserRequest()
            {
                Job = job,
                Name = name
            });

        if (result != null)
        {
            _logger.LogInformation($"User with id = {result?.Id} was up dated");
        }

        return result;
    }
    public async Task<UserResponse> PatchUser(string name, string job)
    {
        var result = await _httpClientService.SendAsync<UserResponse, UserRequest>(
            $"{_options.Host}{_userApi}",
            HttpMethod.Patch,
            new UserRequest()
            {
                Job = job,
                Name = name
            });

        if (result != null)
        {
            _logger.LogInformation($"User with id = {result?.Id} was up dated");
        }

        return result;
    }
}
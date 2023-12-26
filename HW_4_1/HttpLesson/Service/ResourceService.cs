using ALevelSample.Config;
using ALevelSample.Services.Abstractions;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using ALevelSample.Dtos.Responses;
using ALevelSample.Dtos;
using System.Net;
using HttpLesson.Service.Abstraction;

namespace HttpLesson.Service
{
    public sealed class ResourceService : IResourceService
    {
        private readonly IInternalHttpClientService _httpClientService;
        private readonly ILogger<ResourceService> _logger;
        private readonly ApiOption _options;
        private readonly string _resourceApi = "api/unknown";

        public ResourceService(
            IInternalHttpClientService httpClientService,
            IOptions<ApiOption> options,
            ILogger<ResourceService> logger)
        {
            _httpClientService = httpClientService;
            _logger = logger;
            _options = options.Value;
        }
        public async Task<UserDto> GetResourceById(int id)
        {
            var result = await _httpClientService.SendAsync<BaseResponse<UserDto>, object>($"{_options.Host}{_resourceApi}/{id}", HttpMethod.Get);

            if (result?.Data != null)
            {
                _logger.LogInformation($"Resource with id = {result.Data.Id} was found");
            }
            else 
            {
                _logger.LogInformation($"{HttpStatusCode.BadRequest}");
            }

            return result?.Data;
        }
        public async Task<UserDto> GetResourcesList()
        {
            var result = await _httpClientService.SendAsync<BaseResponse<UserDto>, object>($"{_options.Host}{_resourceApi}", HttpMethod.Get);

            if (result?.Data != null)
            {
                _logger.LogInformation($"List of resource");
            }

            return result?.Data;
        }
    }

}

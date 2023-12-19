using ALevelSample.Config;
using ALevelSample.Services.Abstractions;
using ALevelSample.Services;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ALevelSample.Dtos.Responses;
using ALevelSample.Dtos;
using HttpLesson.Dtos;
using ALevelSample.Dtos.Requests;
using System.Xml.Linq;
using HttpLesson.Dtos.Requests;
using System.Net;
using HttpLesson.Service.Abstraction;

namespace HttpLesson.Service
{
    internal class RegistrationService : IRegistrationService
    {
        private readonly IInternalHttpClientService _httpClientService;
        private readonly ILogger<RegistrationService> _logger;
        private readonly ApiOption _options;
        private readonly string _loginApi = "api/";

        public RegistrationService(
            IInternalHttpClientService httpClientService,
            IOptions<ApiOption> options,
            ILogger<RegistrationService> logger)
        {
            _httpClientService = httpClientService;
            _logger = logger;
            _options = options.Value;
        }

        public async Task<LoginData> Registration(string email, string password = null)
        {
            var result = await _httpClientService.SendAsync<LoginData, LoginRequest>(
            $"{_options.Host}{_loginApi}/registre",
            HttpMethod.Post,
            new LoginRequest()
            {
                Email = email,
                Password = password
            });

            if (result != null)
            {
                _logger.LogInformation($"Ty for registration, u id = {result?.Id} ");
            }
            else
            {
                _logger.LogInformation($"{HttpStatusCode.BadGateway}");
            }

            return result;
        }
        public async Task<LoginData> LoginIn(string email, string password = null)
        {
            var result = await _httpClientService.SendAsync<LoginData, LoginRequest>(
            $"{_options.Host}{_loginApi}/login",
            HttpMethod.Post,
            new LoginRequest()
            {
                Email = email,
                Password = password
            });

            if (result != null)
            {
                _logger.LogInformation($"You are loged in with id = {result?.Id}");
            }
            else
            {
                _logger.LogInformation($"{HttpStatusCode.BadGateway}");
            }
            return result;
        }
    }
}

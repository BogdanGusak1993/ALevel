using System.Threading.Tasks;
using ALevelSample.Services.Abstractions;
using HttpLesson.Service.Abstraction;

namespace ALevelSample;

public class App
{
    private readonly IUserService _userService;
    private readonly IResourceService _resourceService;
    private readonly IRegistrationService _registrationService;

    public App(IUserService userService, IResourceService resourceService, IRegistrationService registrationService)
    {
        _userService = userService;
        _resourceService = resourceService;
        _registrationService = registrationService;
    }
    public async Task Start()
    {
        //User
        var user = await _userService.GetUserById(2);
        var userInfo = await _userService.CreateUser("morpheus", "leader");
        var userList = await _userService.GetUsersList();
        var updateUser = await _userService.UpDateUser("morpheus", "leader");
        var patchUser = await _userService.PatchUser("morpheus", "leader");
        var failToGetUser = await _userService.GetUserById(23);

        //Authorization
        var registration = await _registrationService.Registration("eve.holt@reqres.in", "pistol");
        var login = await _registrationService.LoginIn("eve.holt@reqres.in", "cityslicka");
        var registrationFaild = await _registrationService.Registration("eve.holt@reqres.in");
        var loginFaild = await _registrationService.LoginIn("eve.holt@reqres.in");

        //Resource
        var resource = await _resourceService.GetResourceById(2);
        var resourceList = await _resourceService.GetResourcesList();
        var failToGetResource = await _resourceService.GetResourceById(23);

    }
}
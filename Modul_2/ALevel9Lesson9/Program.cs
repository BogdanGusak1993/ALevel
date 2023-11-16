using ALevel9Lesson9;
using ALevel9Lesson9.Repositories;
using ALevel9Lesson9.Repositories.Abstractions;
using ALevel9Lesson9.Services;
using ALevel9Lesson9.Services.Abstractions;
using ALevelModul2.Repositories;
using ALevelModul2.Repositories.Abstractions;
using ALevelModul2.Services;
using ALevelModul2.Services.Abstractions;
using Microsoft.Extensions.DependencyInjection;

void ConfigureService(ServiceCollection serviceCollection)
{
    serviceCollection
        .AddTransient<IApplianceService, ApplianceService>()
        .AddScoped<IAppliancesRepository, AppliancesRepository>()
        .AddScoped<IRoomRepository, RoomRepository>()
        .AddTransient<IRoomService, RoomService>()
        .AddTransient<App>();
}


var serviceCollection = new ServiceCollection();
ConfigureService(serviceCollection);
var provider = serviceCollection.BuildServiceProvider();

var app = provider.GetService<App>();
app!.Run();

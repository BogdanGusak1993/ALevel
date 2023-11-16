using HW8;
using HW8.Repositories;
using HW8.Repositories.Abstractions;
using HW8.Serivces;
using HW8.Serivces.Abstractions;
using Microsoft.Extensions.DependencyInjection;

var serviceCollection = new ServiceCollection()
    .AddTransient<ICandyRepository, CandyRepository>()
    .AddTransient<IPresentService, PresentService>()
    .AddTransient<IUserRepository, UserRepository>()
    .AddTransient<ISortCandy, SortCandy>()
    .AddTransient<App>();
   

var provider = serviceCollection.BuildServiceProvider();

var app = provider.GetService<App>();
app!.Start();
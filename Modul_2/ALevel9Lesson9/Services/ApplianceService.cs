using ALevel9Lesson9.Common;
using ALevel9Lesson9.Models;
using ALevel9Lesson9.Repositories.Abstractions;
using ALevel9Lesson9.Services.Abstractions;
using ALevelModul2.Models.CookingAppliance;
using ALevelModul2.Models.Lamps;
using ALevelModul2.Models.None;
using ALevelModul2.Models.OrgAppliance;

namespace ALevel9Lesson9.Services
{
    public class ApplianceService : IApplianceService
    {
        private readonly IAppliancesRepository _applianceRepository;

        public ApplianceService(IAppliancesRepository shoeRepository)
        {
            _applianceRepository = shoeRepository;
        }

        public string AddAppliance(Appliance appliance)
        {
          return _applianceRepository.AddAppliance(appliance);
        }

        public Appliance PlugInAppliance(string id)
        {
            var appliance = _applianceRepository.PlugInAppliance(id);
            
            if(appliance.GetApplianceType() == ApplianceType.None)
            {
                return new NoneTypedAppliance()
                {
                    Id = appliance.Id,
                    Name = appliance.Name,
                    Description = appliance.Description,
                    Voltage = appliance.Voltage,
                    Power = appliance.Power,
                };
            }
            else if (appliance.GetApplianceType() == ApplianceType.OrgAppliance)
            {
                return new OrgAppliance()
                {
                    Id = appliance.Id,
                    Name = appliance.Name,
                    Description = appliance.Description,
                    Voltage = appliance.Voltage,
                    Power = appliance.Power,
                };
            }
            else if (appliance.GetApplianceType() == ApplianceType.ApplianceForCooking)
            {
                return new ApplianceForCooking()
                {
                    Id = appliance.Id,
                    Name = appliance.Name,
                    Description = appliance.Description,
                    Voltage = appliance.Voltage,
                    Power = appliance.Power,
                };
            }
            else 
            {
                return new Lamps()
                {
                    Id = appliance.Id,
                    Name = appliance.Name,
                    Description = appliance.Description,
                    Voltage = appliance.Voltage,
                    Power = appliance.Power,
                };
            }

        }

        public string[] AddAppliances(Appliance[] appliances)
        {
            return _applianceRepository.AddAppliances(appliances);
        }

        public Appliance[] GetApplianceText(string text)
        {
            var appliances = new List<Appliance>();
            var applianceEntity = _applianceRepository.GetAppliancesText(text);

            foreach (var appliance in applianceEntity)
            {
                if (appliance.GetApplianceType() == ApplianceType.None)
                {
                    appliances.Add(new NoneTypedAppliance()
                    {
                        Id = appliance.Id,
                        Name = appliance.Name,
                        Description = appliance.Description,
                        Voltage = appliance.Voltage,
                        Power = appliance.Power,
                    });
                }
                else if (appliance.GetApplianceType() == ApplianceType.ApplianceForCooking)
                {
                    appliances.Add(new ApplianceForCooking()
                    {
                        Id = appliance.Id,
                        Name = appliance.Name,
                        Description = appliance.Description,
                        Voltage = appliance.Voltage,
                        Power = appliance.Power,
                    });
                }
                else if (appliance.GetApplianceType() == ApplianceType.OrgAppliance)
                {
                    appliances.Add(new OrgAppliance()
                    {
                        Id = appliance.Id,
                        Name = appliance.Name,
                        Description = appliance.Description,
                        Voltage = appliance.Voltage,
                        Power = appliance.Power,
                    });
                }
               else
                {
                    appliances.Add(new Lamps()
                    {
                        Id = appliance.Id,
                        Name = appliance.Name,
                        Description = appliance.Description,
                        Voltage = appliance.Voltage,
                        Power = appliance.Power,
                    });
                }
            }
            return appliances.ToArray();
        }
    }
}

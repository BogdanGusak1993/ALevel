using ALevel9Lesson9.Common;
using ALevel9Lesson9.Entities;
using ALevel9Lesson9.Exeptions;
using ALevel9Lesson9.Models;
using ALevel9Lesson9.Repositories.Abstractions;
using ALevelModul2.Entities;

namespace ALevel9Lesson9.Repositories
{
    public class AppliancesRepository : IAppliancesRepository
    {
        private readonly List<AppliancesEntity> _mocAppliance = new List<AppliancesEntity>();
        public AppliancesEntity PlugInAppliance(string id)
        {

            foreach (var item in _mocAppliance)
            {
                if (item.Id.ToString() == id)
                {
                    return item;
                }
            }
            throw new ShowNotFoundExeption($"Appliance with id:{id} not found");
        }

        public string AddAppliance(Appliance appliance)
        {

            if (appliance.GetApplianceType() == ApplianceType.None)
            {
                var noneTypeAppliancEntity = new NoneTypedEntity()
                {
                    Id = Guid.NewGuid(),
                    Description = appliance.Description,
                    Name = appliance.Name,
                    Voltage = appliance.Voltage,
                    Power = appliance.Power,

                };
                _mocAppliance.Add(noneTypeAppliancEntity);
                return noneTypeAppliancEntity.Id.ToString();
            }
            else if (appliance.GetApplianceType() == ApplianceType.ApplianceForCooking)
            {
                var cookingAppliancEntity = new ApplianceForCookingEntity()
                {
                    Id = Guid.NewGuid(),
                    Description = appliance.Description,
                    Name = appliance.Name,
                    Voltage = appliance.Voltage,
                    Power = appliance.Power,

                };
                _mocAppliance.Add(cookingAppliancEntity);
                return cookingAppliancEntity.Id.ToString();
            }
            else if (appliance.GetApplianceType() == ApplianceType.OrgAppliance)
            {
                var orgAppliancEntity = new OrgApplianceEntity()
                {
                    Id = Guid.NewGuid(),
                    Description = appliance.Description,
                    Name = appliance.Name,
                    Voltage = appliance.Voltage,
                    Power = appliance.Power,

                };
                _mocAppliance.Add(orgAppliancEntity);
                return orgAppliancEntity.Id.ToString();
            }
            else
            {
                var lampsEntity = new LampsEntity()
                {
                    Id = Guid.NewGuid(),
                    Description = appliance.Description,
                    Name = appliance.Name,
                    Voltage = appliance.Voltage,
                    Power = appliance.Power,

                };
                _mocAppliance.Add(lampsEntity);
                return lampsEntity.Id.ToString();
            }

        }

        public string[] AddAppliances(Appliance[] appliances)
        {
            var entityAppliances = new List<AppliancesEntity>();
            var ids = new List<string>();
            foreach (var appliance in appliances)
            {
                if (appliance.GetApplianceType() == ApplianceType.None)
                {
                    var noneTypeAppliancEntity = new NoneTypedEntity()
                    {
                        Id = Guid.NewGuid(),
                        Description = appliance.Description,
                        Name = appliance.Name,
                        Voltage = appliance.Voltage,
                        Power = appliance.Power,

                    };
                    ids.Add(noneTypeAppliancEntity.Id.ToString());
                    entityAppliances.Add(noneTypeAppliancEntity);
                    _mocAppliance.Add(noneTypeAppliancEntity);
                }
                else if (appliance.GetApplianceType() == ApplianceType.ApplianceForCooking)
                {
                    var cookingAppliancEntity = new ApplianceForCookingEntity()
                    {
                        Id = Guid.NewGuid(),
                        Description = appliance.Description,
                        Name = appliance.Name,
                        Voltage = appliance.Voltage,
                        Power = appliance.Power,

                    };
                    ids.Add(cookingAppliancEntity.Id.ToString());
                    entityAppliances.Add(cookingAppliancEntity);
                    _mocAppliance.Add(cookingAppliancEntity);
                }
                else if (appliance.GetApplianceType() == ApplianceType.OrgAppliance)
                {
                    var orgAppliancEntity = new OrgApplianceEntity()
                    {
                        Id = Guid.NewGuid(),
                        Description = appliance.Description,
                        Name = appliance.Name,
                        Voltage = appliance.Voltage,
                        Power = appliance.Power,

                    };
                    ids.Add(orgAppliancEntity.Id.ToString());
                    entityAppliances.Add(orgAppliancEntity);
                    _mocAppliance.Add(orgAppliancEntity);
                }
                else
                {
                    var lampsEntity = new LampsEntity()
                    {
                        Id = Guid.NewGuid(),
                        Description = appliance.Description,
                        Name = appliance.Name,
                        Voltage = appliance.Voltage,
                        Power = appliance.Power,

                    };
                    ids.Add(lampsEntity.Id.ToString());
                    entityAppliances.Add(lampsEntity);
                    _mocAppliance.Add(lampsEntity);
                }
                
            }
            return ids.ToArray();
        }

        public AppliancesEntity[] GetAppliancesText(string text)
        {
            var appliances = new List<AppliancesEntity>();

            foreach (var appliance in _mocAppliance)
            {
                if (appliance.Name.Contains(text) & appliance.Description.Contains(text))
                {
                    appliances.Add(appliance);
                }
            }
            return appliances.ToArray();
        }
    }
}

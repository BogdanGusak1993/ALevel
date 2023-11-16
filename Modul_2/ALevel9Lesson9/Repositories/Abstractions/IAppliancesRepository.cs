using ALevel9Lesson9.Entities;
using ALevel9Lesson9.Models;


namespace ALevel9Lesson9.Repositories.Abstractions
{
    public interface IAppliancesRepository
    {
        AppliancesEntity PlugInAppliance(string id);
        string AddAppliance(Appliance appliance);
        string[] AddAppliances(Appliance[] appliance);
        AppliancesEntity[] GetAppliancesText(string text);
    }
}

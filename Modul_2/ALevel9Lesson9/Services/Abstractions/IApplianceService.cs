using ALevel9Lesson9.Entities;
using ALevel9Lesson9.Models;

namespace ALevel9Lesson9.Services.Abstractions
{
    public interface IApplianceService
    {
        Appliance PlugInAppliance(string id);
        string AddAppliance(Appliance appliance);
        Appliance[] GetApplianceText(string text);
        public string[] AddAppliances(Appliance[] appliances);
    }
}

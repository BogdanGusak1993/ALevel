using ALevel9Lesson9.Common;
using ALevel9Lesson9.Models;

namespace ALevelModul2.Models.CookingAppliance
{
    public class ApplianceForCooking : Appliance
    {
        public override ApplianceType GetApplianceType()
        {
            return ApplianceType.ApplianceForCooking;
        }
    }
}

using ALevel9Lesson9.Common;
using ALevel9Lesson9.Models;

namespace ALevelModul2.Models.OrgAppliance
{
    public  class OrgAppliance : Appliance
    {
        public override ApplianceType GetApplianceType()
        {
            return ApplianceType.OrgAppliance;
        }

    }
}

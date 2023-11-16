using ALevel9Lesson9.Common;
using ALevel9Lesson9.Entities;


namespace ALevelModul2.Entities
{
    public class OrgApplianceEntity : AppliancesEntity
    {
        public override ApplianceType GetApplianceType()
        {
            return ApplianceType.OrgAppliance;
        }
    }
}

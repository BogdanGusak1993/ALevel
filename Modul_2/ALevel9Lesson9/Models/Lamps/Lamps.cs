using ALevel9Lesson9.Common;
using ALevel9Lesson9.Models;

namespace ALevelModul2.Models.Lamps
{
    public class Lamps : Appliance
    {
        public override ApplianceType GetApplianceType()
        {
            return ApplianceType.Lamps;
        }
    }
}

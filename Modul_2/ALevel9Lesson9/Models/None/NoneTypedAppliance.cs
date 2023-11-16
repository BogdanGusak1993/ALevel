using ALevel9Lesson9.Common;
using ALevel9Lesson9.Models;

namespace ALevelModul2.Models.None
{
    public class NoneTypedAppliance : Appliance
    {
        public override ApplianceType GetApplianceType()
        {
            return ApplianceType.None;
        }
        public string? SpecialDesription { get; set; }
    }
}

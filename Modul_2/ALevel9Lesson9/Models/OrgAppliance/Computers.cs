using ALevel9Lesson9.Common;

namespace ALevelModul2.Models.OrgAppliance
{
    public class Computers : OrgAppliance
    {
        public string? ProcesorModel {  get; set; }
        public string? GraphicCardModel {  get; set; }
        public PCsType PCsType { get; set; }
    }
}

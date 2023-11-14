using ALevel9Lesson9.Common;

namespace ALevel9Lesson9.Entities
{
    public abstract class AppliancesEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Voltage { get; set; }
        public int Power { get; set; }
        public abstract ApplianceType GetApplianceType();
    }
}

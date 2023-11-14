
using ALevel9Lesson9.Entities;

namespace ALevelModul2.Entities
{
    public class RoomsEntity
    {
        public Guid Id { get; set; }
        public int Number { get; set; }
        public int PowerPlug  { get; set; }
        public AppliancesEntity[] Appliances { get; set; }
    }
}

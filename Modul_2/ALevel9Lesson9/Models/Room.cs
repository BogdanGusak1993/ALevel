using ALevel9Lesson9.Models;

namespace ALevelModul2.Entities
{
    public class Room
    {
        public Guid Id { get; set; }
        public int Number { get; set; }
        public int PowerPlug { get; set; }
        public Appliance[] Appliances { get; set; }
    }
}

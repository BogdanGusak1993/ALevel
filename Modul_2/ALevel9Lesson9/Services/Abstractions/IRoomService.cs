using ALevel9Lesson9.Models;
using ALevelModul2.Entities;


namespace ALevelModul2.Services.Abstractions
{
    public interface IRoomService
    {
        string AddRoom(Room room);
        public Room GetRoom(string id);
        int CalculatePowerPlug(Appliance[] appliance);
    }
}

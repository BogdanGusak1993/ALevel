using ALevel9Lesson9.Models;
using ALevelModul2.Entities;

namespace ALevelModul2.Repositories.Abstractions
{
    public interface IRoomRepository
    {
        string AddRoom(Room room);
        public RoomsEntity GetRoom(string id);
    }
}

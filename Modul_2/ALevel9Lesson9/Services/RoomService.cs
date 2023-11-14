using ALevel9Lesson9.Models;
using ALevelModul2.Entities;
using ALevelModul2.Repositories.Abstractions;
using ALevelModul2.Services.Abstractions;

namespace ALevelModul2.Services
{
    internal class RoomService : IRoomService 
    {
        private readonly IRoomRepository _roomRepository;

        public RoomService(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }

        public string AddRoom(Room room)
        {
            return _roomRepository.AddRoom(room);
        }

        public Room GetRoom(string id)
        {
            var room = _roomRepository.GetRoom(id);

            return new Room
            {
                Number = room.Number,
                PowerPlug = room.PowerPlug,
            };
        }

        public int CalculatePowerPlug(Appliance[] appliance)
        {
            int power = 0;

            foreach(Appliance item in appliance)
            {
                power += item.Power;
            }
            return power;
        }
    }
}

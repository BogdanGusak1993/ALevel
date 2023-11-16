using ALevel9Lesson9.Exeptions;
using ALevelModul2.Entities;
using ALevelModul2.Repositories.Abstractions;

namespace ALevelModul2.Repositories
{
    public class RoomRepository : IRoomRepository
    {
        private  RoomsEntity _mocRooms = new RoomsEntity();
        public string AddRoom(Room room)
        {
            var roomEntity = new RoomsEntity()
            {
                Id = Guid.NewGuid(),
                Number = room.Number,
                PowerPlug = room.PowerPlug,
            };

            _mocRooms = roomEntity;

            return roomEntity.Id.ToString();
        }

        public RoomsEntity GetRoom(string id) 
        {
            try
            {
                return _mocRooms;
            }
            catch (ShowNotFoundExeption ex)
            {
                Console.WriteLine(ex.Message);
                return _mocRooms = GetRoom(id);
            }
        }
    }
}

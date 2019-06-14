using System;

namespace Renting.Domain.Apartments
{
    public class Room
    {
        private Area _area;
        private RoomType _type;

        private Room(Area area, RoomType type)
        {
            _area = area;
            _type = type;
        }

        public static Room From(decimal squareMeters, string type)
        {
            var area = Area.From(squareMeters);
            if (!Enum.TryParse(type, true, out RoomType roomType))
            {
                throw new NotSupportedRoomTypeException(type);
            }
            return new Room(area, roomType);
        }

        private enum RoomType
        {
            Bath = 1,
            DinningRoom = 2,
            Bedroom = 3,
            Corridor = 4,
            LivingRoom = 5
        }
    }
}
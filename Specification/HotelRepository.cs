using System.Collections.Generic;
using System.Linq;

namespace Specification
{
    public class HotelRepository
    {
        private readonly IEnumerable<Hotel> hotels;

        public HotelRepository()
        {
            hotels = new List<Hotel>()
                     {
                         new Hotel()
                         {
                             Name = "Hotel 1",
                             Boutique = false,
                             RoomCount = 100,
                             BookedRoomCount = 60,
                             Star = 5
                         },
                         new Hotel()
                         {
                             Name = "Hotel 2",
                             Boutique = true,
                             RoomCount = 12,
                             BookedRoomCount = 12,
                             Star = 5
                         },
                         new Hotel()
                         {
                             Name = "Hotel 3",
                             Boutique = false,
                             RoomCount = 80,
                             BookedRoomCount = 76,
                             Star = 4
                         },
                         new Hotel()
                         {
                             Name = "Hotel 4",
                             Boutique = true,
                             RoomCount = 20,
                             BookedRoomCount = 10,
                             Star = 5
                         },
                         new Hotel()
                         {
                             Name = "Hotel 5",
                             Boutique = true,
                             RoomCount = 20,
                             BookedRoomCount = 10,
                             Star = 5
                         }
                     };
        }

        public List<Hotel> GetAll()
        {
            return hotels.ToList();
        }

        public List<Hotel> GetFiveStarHotels()
        {
            return hotels.Where(i => i.Star == 5).ToList();
        }
    }
}

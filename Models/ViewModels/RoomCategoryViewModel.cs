using HotelManagementSystem.Models.Room;
using System.Collections.Generic;

namespace HotelManagementSystem.Models.ViewModels
{
    public class RoomCategoryViewModel
    {
        public RoomCategory Category { get; set; }
        public IEnumerable<Room.Room> Rooms { get; set; }
    }
}
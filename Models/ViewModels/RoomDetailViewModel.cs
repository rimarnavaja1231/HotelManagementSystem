using HotelManagementSystem.Models.Room;
using System.Collections.Generic;

namespace HotelManagementSystem.Models.ViewModels
{
    public class RoomDetailViewModel
    {
        public RoomCategory Category { get; set; }
        public IEnumerable<Room.Room> AvailableRooms { get; set; }
    }
}
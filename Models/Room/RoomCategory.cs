using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HotelManagementSystem.Models.Room
{
    public class RoomCategory
    {
        [Key]
        public int CategoryId { get; set; }
        
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        
        public string Description { get; set; }
        
        [Required]
        [DataType(DataType.Currency)]
        public decimal BasePrice { get; set; }
        
        [Required]
        public int Capacity { get; set; }
        
        public string Amenities { get; set; }
        
        public ICollection<Room> Rooms { get; set; }
    }
}
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelManagementSystem.Models.Room
{
    public class Room
    {
        [Key]
        public int RoomId { get; set; }
        
        [Required]
        [StringLength(10)]
        public string RoomNumber { get; set; }
        
        [Required]
        [StringLength(10)]
        public string Floor { get; set; }
        
        [Required]
        [ForeignKey("RoomCategory")]
        public int CategoryId { get; set; }
        
        [Required]
        [StringLength(20)]
        public string Status { get; set; } = "available";
        
        public string Description { get; set; }
        
        public string Features { get; set; }
        
        public DateTime? LastCleaned { get; set; }
        
        public RoomCategory Category { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RoomManagement.Models
{
    public class DetailsRoomTypeViewModel
    {
        public int RoomTypeId { get; set; }
        public string RoomName { get; set; }
        public int RoomPrice { get; set; }
        public int RoomNumber { get; set; }
    }
    public class CreateRoomTypeViewModel
    {
        public int RoomTypeId { get; set; }
        [Required]
        public string RoomName { get; set; }
        public int RoomPrice { get; set; }
        public int RoomNumber { get; set; }
    }
}

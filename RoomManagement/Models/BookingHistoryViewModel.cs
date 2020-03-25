using Microsoft.AspNetCore.Mvc.Rendering;
using RoomManagement.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RoomManagement.Models
{
    public class BookingHistoryViewModel{     
       public int Id { get; set; }
        public EmployeeViewModel EmployeeBookingRoom { get; set; }
        public string EmployeeBookingRoodId { get; set; }
        [Required]
        public DateTime CheckinDate { get; set; }
        [Required]
        public DateTime CheckOutDate { get; set; }
        [Required]
        public DateTime BookingDate { get; set; }

        public DetailsRoomTypeViewModel RoomType { get; set; }
        public int RoomTypeId { get; set; }
        public IEnumerable<SelectListItem> RoomTypes { get; set; } // Drop down list for room types
        public bool? BookingApproved { get; set; }
        public EmployeeViewModel ApprovedBy { get; set; }
        public string BookingApprovedById { get; set; }


    }
}

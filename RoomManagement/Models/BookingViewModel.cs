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
    public class BookingViewModel
    {
            [Required]
            public int BookingId { get; set; }
            [Required]
            public DateTime BookingDate { get; set; }
             [Required]
            public int BookingNumber { get; set; }
            public EmployeeViewModel Employee { get; set; }
            public string EmployeeId { get; set; }
            public DetailsRoomTypeViewModel RoomType { get; set; }
            public int RoomTypeId { get; set; }
            
            public IEnumerable<SelectListItem> Employees { get; set; } // Creates drop down list for employees and room types
            public IEnumerable<SelectListItem> RoomTypes { get; set; }

    }
}

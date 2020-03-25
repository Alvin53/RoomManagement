using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RoomManagement.Data
{
    public class BookingHistory
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("EmployeeBookingRoodId")]
        public Employee EmployeeBookingRoom { get; set; }
        public string EmployeeBookingRoodId { get; set; }
        public DateTime CheckinDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public DateTime BookingDate { get; set; }

        [ForeignKey("RoomTypeId")]
        public RoomType RoomType { get; set; }
        public int RoomTypeId { get; set; }
        public bool? BookingApproved { get; set; }
        [ForeignKey("BookingApprovedById")]
        public Employee ApprovedBy { get; set; }
        public string BookingApprovedById { get; set; }


    }
}

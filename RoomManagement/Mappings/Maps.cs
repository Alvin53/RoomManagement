using AutoMapper;
using RoomManagement.Data;
using RoomManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoomManagement.Mappings
{
    public class Maps : Profile 
    {
        public Maps()
        {
            CreateMap<RoomType, DetailsRoomTypeViewModel>().ReverseMap(); 
            CreateMap<RoomType, CreateRoomTypeViewModel>().ReverseMap(); 
            CreateMap<Employee, EmployeeViewModel>().ReverseMap(); 
            CreateMap<Booking, BookingViewModel>().ReverseMap(); 
            CreateMap<BookingHistory, BookingHistoryViewModel>().ReverseMap(); 
            CreateMap<BookedRoom, BookedRoomViewModel>().ReverseMap(); 

        }

    }
}

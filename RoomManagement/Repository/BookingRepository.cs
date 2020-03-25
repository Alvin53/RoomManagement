using RoomManagement.Contracts;
using RoomManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoomManagement.Repository
{
    public class BookingRepository : IBookingRepository
    {
        private readonly ApplicationDbContext _db;
        public BookingRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public bool Create(Booking entity)
        {
            _db.Bookings.Add(entity);
            return Save();
        }

        public bool Delete(Booking entity)
        {
            _db.Bookings.Remove(entity);
            return Save();
        }

        public ICollection<Booking> FindAll()
        {
            var bookings = _db.Bookings.ToList();
            return bookings;
        }

        public Booking FindById(int id)
        {//ID MAY NEED TO BE CHANGE VARIABLE AND IN DB CONTEXT
            var bookings = _db.Bookings.Find(id);
            return bookings;
        }

        public bool Save()
        {
            var changes = _db.SaveChanges();
            return changes > 0;
        }

        public bool Update(Booking entity)
        {
            _db.Bookings.Update(entity);
            return Save();
        }
    }
}

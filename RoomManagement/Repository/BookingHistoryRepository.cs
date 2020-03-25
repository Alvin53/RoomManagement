using RoomManagement.Contracts;
using RoomManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoomManagement.Repository
{
    public class BookingHistoryRepository : IBookingHistoryRepository
    {
        private readonly ApplicationDbContext _db;
        public BookingHistoryRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public bool Create(BookingHistory entity)
        {
            _db.BookingHistories.Add(entity);
            return Save();
        }

        public bool Delete(BookingHistory entity)
        {
            _db.BookingHistories.Remove(entity);
            return Save();
        }

        public ICollection<BookingHistory> FindAll()
        {
            var BookingHistory = _db.BookingHistories.ToList();
            return BookingHistory;
        }

        public BookingHistory FindById(int id)
        {
            var BookingHistory = _db.BookingHistories.Find(id);
            return BookingHistory;
        }

        public bool Save()
        {
            var changes = _db.SaveChanges();
            return changes > 0;
        }

        public bool Update(BookingHistory entity)
        {
            _db.BookingHistories.Update(entity);
            return Save();
        }
    }
}

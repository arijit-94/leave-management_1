using leave_management.Contracts;
using leave_management.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Repository
{
    public class LeaveHistoryRepository : ILeaveHistoryRepository
    {
        private readonly ApplicationDbContext _db;  //to make connection with database

        public LeaveHistoryRepository(ApplicationDbContext db)  //contsructor
        {
            _db = db;
        }
        public bool Create(LeaveHistory Entity)
        {
            //throw new NotImplementedException();
            _db.LeaveHistories.Add(Entity);
            return Save();

        }

        public bool Delete(LeaveHistory Entity)
        {
            //throw new NotImplementedException();
            _db.LeaveHistories.Remove(Entity);
            return Save();
        }

        public ICollection<LeaveHistory> FindAll()
        {
            throw new NotImplementedException();
        }

        public LeaveHistory FindById(int id)
        {
            //hrow new NotImplementedException();
            var leaveHistory = _db.LeaveHistories.Find(id);
            return leaveHistory;
        }

        //public ICollection<LeaveHistory> GetEmployeeLeaveHistory(int id)
        //{
        //    throw new NotImplementedException();
        //}

        public bool Save()
        {
            //throw new NotImplementedException();
            var changes1 = _db.SaveChanges();
            return changes1 > 0;
        }

        public bool Update(LeaveHistory Entity)
        {
            //throw new NotImplementedException();
            _db.LeaveHistories.Update(Entity);
            return Save();
        }
    }
}

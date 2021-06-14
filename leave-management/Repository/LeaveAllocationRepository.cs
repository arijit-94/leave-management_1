using leave_management.Contracts;
using leave_management.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Repository
{
    public class LeaveAllocationRepository : ILeaveAllocationRepository
    {
        private readonly ApplicationDbContext _db;  //to make connection with database

        public LeaveAllocationRepository(ApplicationDbContext db)  //contsructor
        {
            _db = db;
        }

        public bool Create(LeaveAllocation Entity)
        {
            //throw new NotImplementedException();
            _db.LeaveAllocations.Add(Entity);
            return Save();
        }

        public bool Delete(LeaveAllocation Entity)
        {
            //throw new NotImplementedException();
            _db.LeaveAllocations.Remove(Entity);
            return Save();
        }

        public ICollection<LeaveAllocation> FindAll()
        {
            throw new NotImplementedException();
        }

        public LeaveAllocation FindById(int id)
        {
            //throw new NotImplementedException();
            var leaveAllocation = _db.LeaveAllocations.Find(id);
            return leaveAllocation;        }

        //public ICollection<LeaveAllocation> GetEmployeeLeaveAllocation(int id)
        //{
        //    throw new NotImplementedException();
        //}

        public bool Save()
        {
            //throw new NotImplementedException();
            var changes2 = _db.SaveChanges();
            return changes2 > 0;
        }

        public bool Update(LeaveAllocation Entity)
        {
            //throw new NotImplementedException();
            _db.LeaveAllocations.Update(Entity);
            return Save();
        }
    }
}

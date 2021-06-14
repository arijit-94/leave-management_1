using leave_management.Contracts;
using leave_management.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Repository
{
    public class LeaveTypeRepository : ILeaveTypeRepository
    {
        private readonly ApplicationDbContext _db;  //to make connection with database

        public LeaveTypeRepository(ApplicationDbContext db)  //contsructor
        {
            _db = db;   
        }

        public bool Create(LeaveType Entity)
        {
            //throw new NotImplementedException();
            _db.LeaveTypes.Add(Entity);
            return Save();
        }

        public bool Delete(LeaveType Entity)
        {
            //throw new NotImplementedException();
            _db.LeaveTypes.Remove(Entity);
            return Save();
        }

        public ICollection<LeaveType> FindAll()
        {
            var leaveTypes = _db.LeaveTypes.ToList();   //Find all leave types from the database
            return leaveTypes;
        }

        public LeaveType FindById(int id)
        {
            //throw new NotImplementedException();
            var leaveType = _db.LeaveTypes.Find(id);   // to return particular leave type
            return leaveType;
        }

        public ICollection<LeaveType> GetEmployeeLeaveType(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            //throw new NotImplementedException();
            var changes = _db.SaveChanges();
            return changes > 0;
        }

        public bool Update(LeaveType Entity)
        {
            //throw new NotImplementedException();
            _db.LeaveTypes.Update(Entity);
            return Save();
        }
    }
}

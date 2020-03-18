using FrisbiTestApp.Contexts;
using FrisbiTestApp.Exceptions;
using FrisbiTestApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrisbiTestApp.Repositories
{
   public class StaffRepository : IStaffRepository
    {
        private StaffContext dbcontext;

        public StaffRepository(StaffContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }

        

        public bool AddStaffRecord(StaffModel staff)
        {
            dbcontext.Staffs.Add(staff);
            dbcontext.SaveChanges();
            return true;
        }

        public List<StaffModel> GetStaffRecordByName(string name)
        {
            return dbcontext.Staffs.Where(x => x.Name == name).ToList();
        }

        public List<StaffModel> GetStaffRecordBySurname(string surname)
        {
            return dbcontext.Staffs.Where(x => x.Surname == surname).ToList();
        }

        public bool DismissingStaffRecord(StaffModel staff)
        {
            dbcontext.Entry(staff).State = EntityState.Modified;
            dbcontext.SaveChanges();
            return true;
        }

        public void RingingDb()
        {
           var firstRecord =  dbcontext.Staffs.First();
            if(firstRecord == null)
            {
                throw new ExceptDbAcess("Ошибка доступа к бд");
            }
        }

        public List<StaffModel> GetAllStaffRecords()
        {
            return dbcontext.Staffs.ToList();
        }

        public StaffModel GetStaffRecordById(int id)
        {
            return dbcontext.Staffs.Find(id);
        }
    }
}

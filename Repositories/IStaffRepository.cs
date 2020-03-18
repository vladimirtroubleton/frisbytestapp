using FrisbiTestApp.Models;
using System.Collections.Generic;

namespace FrisbiTestApp.Repositories
{
    public interface IStaffRepository
    {
        
        bool AddStaffRecord(StaffModel staff);
        bool DismissingStaffRecord(StaffModel staff);

        StaffModel GetStaffRecordById(int id);

        List<StaffModel> GetStaffRecordByName(string name);
        List<StaffModel> GetStaffRecordBySurname(string surname);

        void RingingDb();
        List<StaffModel> GetAllStaffRecords();
    }
}
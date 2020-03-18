using FrisbiTestApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FrisbiTestApp.Contexts
{
    public class StaffContext : DbContext
    {
        public DbSet<StaffModel> Staffs { get; set; }


        public StaffContext(DbContextOptions<StaffContext> options) : base(options)
        {
            Database.EnsureCreated();

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StaffModel>().HasData(new StaffModel { Id= 1,Name = "Владимир" , Surname = "Дегтерев" , MiddleName = "Александрович" , Position = "Разработчик" , Salary = 35000 , StartDate = DateTime.Now , DateofDismissal = null});
            
        }
    }
}

using EmployeeData.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData
{
    public class EmployeeDbContext : DbContext
    {
        public DbSet<EmployeeEntity> Employees { get; set; }
        private string DbPath { get; set; }
        public EmployeeDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "employees.db");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
        options.UseSqlite($"Data Source={DbPath}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeEntity>().HasData(
                new EmployeeEntity() { 
                    Id = 1, 
                    Name = "Jan",
                    Surname = "Kowalski",
                    Department = "IT",
                    HireDate = new DateTime(2023, 12, 1),
                    Pesel = "12345678911",
                    Position = 1
                },
                new EmployeeEntity() { 
                    Id = 2,
                    Name = "Anna",
                    Surname = "Nowak",
                    Department = "Biznes",
                    HireDate = new DateTime(2023, 10, 5),
                    Pesel = "78945612388",
                    Position = 2
                }
            );
        }
    }
}

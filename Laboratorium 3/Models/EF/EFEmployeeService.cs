using Data.Entities;
using Data;
using Laboratorium_3.Mappers;
using EmployeeData;
using EmployeeData.Entities;
using Microsoft.EntityFrameworkCore;

namespace Laboratorium_3.Models.EF
{
    public class EFEmployeeService : IEmployeeService
    {
        private EmployeeDbContext _context;

        public EFEmployeeService(EmployeeDbContext context)
        {
            _context = context;
        }

        public int Add(Employee contact)
        {
            var e = _context.Employees.Add(EmployeeMapper.ToEntity(contact));
            _context.SaveChanges();
            return e.Entity.Id;
        }

        public void Delete(int id)
        {
            EmployeeEntity? find = _context.Employees.Find(id);
            if (find != null)
            {
                _context.Employees.Remove(find);
                _context.SaveChanges();
            }
        }

        public List<Employee> FindAll()
        {
            return _context.Employees.AsNoTracking().Select(e => EmployeeMapper.FromEntity(e)).ToList();
        }

        public Employee? FindById(int id)
        {
            return EmployeeMapper.FromEntity(_context.Employees.AsNoTracking().FirstOrDefault(x => x.Id == id));
        }

        public void Update(Employee employee)
        {
            _context.Employees.Update(EmployeeMapper.ToEntity(employee));
            _context.SaveChanges();
        }
    }
}

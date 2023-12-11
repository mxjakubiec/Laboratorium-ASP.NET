using Data.Entities;
using EmployeeData.Entities;
using Laboratorium_3.Models;

namespace Laboratorium_3.Mappers
{
    public class EmployeeMapper
    {
        public static Employee FromEntity(EmployeeEntity entity)
        {
            return new Employee()
            {
                Id = entity.Id,
                Name = entity.Name,
                Surname = entity.Surname,
                Department = entity.Department, 
                HireDate = entity.HireDate,
                Pesel = entity.Pesel,
                Position = (Position)entity.Position,
                ReleaseDate = entity.ReleaseDate 
            };
        }

        public static EmployeeEntity ToEntity(Employee model)
        {
            return new EmployeeEntity()
            {
                Id = model.Id,
                Name = model.Name,
                Surname = model.Surname,
                Department = model.Department,
                HireDate = model.HireDate,
                Pesel = model.Pesel,
                Position = (int)model.Position,
                ReleaseDate = model.ReleaseDate
            };
        }
    }
}

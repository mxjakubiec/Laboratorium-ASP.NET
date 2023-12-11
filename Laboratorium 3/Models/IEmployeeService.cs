namespace Laboratorium_3.Models
{
    public interface IEmployeeService
    {
        int Add(Employee employee);
        void Delete(int id);
        void Update(Employee employee);
        List<Employee> FindAll();
        Employee? FindById(int id);
    }
}

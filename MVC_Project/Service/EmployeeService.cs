using MVC_Project.Models;
using MVC_Project.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Threading.Tasks;

namespace MVC_Project.Service
{
    public class EmployeeService : IEmployeeService
    {
        private IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public IEnumerable<Employee> GetAll()
        {
            return _employeeRepository.GetAll();
        }

        public Employee Get(int id)
        {
            return _employeeRepository.Get(id);
        }
        public IEnumerable<Employee> GetEmployeesByDepartment(int id)
        {
            return _employeeRepository.GetEmployeesByDepartment(id);
        }

        public async Task Create(Employee employee)
        {
            _employeeRepository.Add(employee);
            await _employeeRepository.Update();
        }

        public async Task UpdateUserAsync(int id, Employee updatedEmployee)
        {
            Employee employee = _employeeRepository.Get(id);

            employee.FName = updatedEmployee.FName;
            employee.LName = updatedEmployee.LName;
            employee.Age = updatedEmployee.Age;
            employee.Country = updatedEmployee.Country;
            employee.Department = updatedEmployee.Department;

            await _employeeRepository.Update();
        }
    }
}
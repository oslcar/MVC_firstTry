using MVC_Project.Models;
using MVC_Project.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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
    }
}
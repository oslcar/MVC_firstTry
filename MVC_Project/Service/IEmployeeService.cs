using MVC_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Project.Service
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetAll();
        Employee Get(int id);
        IEnumerable<Employee> GetEmployeesByDepartment(int id);
    }
}

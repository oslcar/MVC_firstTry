using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MVC_Project.Context;
using MVC_Project.Models;

namespace MVC_Project.Repositories
{
    public class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(EmployeeContext context) : base(context)
        {
        }
        public IQueryable<Employee> GetEmployeesByDepartment(int id)
        {
            return _context.Set<Employee>()
                .Where(emp => emp.Department_ID == id);
        }
    }
}
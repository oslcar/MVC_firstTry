using MVC_Project.Context;
using MVC_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Project.Repositories
{
    public class DepartmentRepository : RepositoryBase<Department>, IDepartmentRepository
    {
        public DepartmentRepository(EmployeeContext context) : base(context)
        {
        }
    }
}
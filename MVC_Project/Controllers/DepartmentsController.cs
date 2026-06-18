using MVC_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using MVC_Project.Repositories;
using MVC_Project.Context;

namespace MVC_Project.Controllers
{
    public class DepartmentsController : Controller
    {
        private readonly EmployeeContext db = new EmployeeContext();
        // GET: Departments
        public ActionResult ListOfDepartments()
        {
            RepositoryBase<Department> departments = new RepositoryBase<Department>(db);
            var allDepartments = departments.GetAll();
            return View(allDepartments);
        }

        public ActionResult DepartmentEmployees(int id)
        {
            EmployeeRepository employees = new EmployeeRepository(db);
            return View(employees.GetEmployeesByDepartment(id).ToList());
        }
    }
}
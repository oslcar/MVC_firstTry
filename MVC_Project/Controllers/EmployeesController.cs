using MVC_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using MVC_Project.Context;
using MVC_Project.Repositories;
using MVC_Project.Service;
using System.Threading.Tasks;

namespace MVC_Project.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly IEmployeeService _employeeService;
        private readonly IDepartmentService _departmentService;

        public EmployeesController(IEmployeeService employeeService, IDepartmentService departmentService)
        {
            _departmentService = departmentService;
            _employeeService = employeeService;
        }
        // GET: Employees
        public ActionResult EmployeesToList()
        {
            return View(_employeeService.GetAll());
        }
        
        public ActionResult GetEmployee(int id)
        {
            return View(_employeeService.Get(id));
        }
        public ActionResult DepartmentEmployees(int id)
        {
            return View(_employeeService.GetEmployeesByDepartment(id));
        }
        
        [HttpGet]
        public ActionResult CreateEmployee()
        {
            var viewModel = new EmployeeFormModel
            {
                Employee = new Employee(),
                Departments = _departmentService.GetAll()
                .Select(dep => new SelectListItem { Value = dep.ID.ToString(), Text = dep.Name})
            };
            return View(viewModel);
        }

        [HttpPost]
        public async Task<ActionResult> CreateEmployeePost(Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return View("CreateEmployee", employee);
            }

            await _employeeService.Create(employee);
            return RedirectToAction("EmployeesToList");
        }
    }  
}
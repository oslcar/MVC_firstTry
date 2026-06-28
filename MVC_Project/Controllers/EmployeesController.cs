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

namespace MVC_Project.Controllers
{
    public class EmployeesController : Controller
    {

        private readonly IEmployeeService _employeeService;
        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        // GET: Employees
        public ActionResult EmployeesToList()
        {

            /*IEnumerable<Employee> _employees = db.Employees
                .ToList();*/
            var allEmployees = _employeeService.GetAll();
            return View(allEmployees);

        }
<<<<<<< Updated upstream
=======

        public ActionResult ListOfHardware(int? id)
        {
            HardwareRepository hardware = new HardwareRepository(db);
            return View(hardware.GetHardwareByOwner(id).ToList());
        }
        */
>>>>>>> Stashed changes
        public ActionResult GetEmployee(int id)
        {   
            return View(_employeeService.Get(id));
        }
        public ActionResult DepartmentEmployees(int id)
        {
            ;
            return View(_employeeService.GetEmployeesByDepartment(id));
        }
    }  
}
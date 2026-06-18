using MVC_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using MVC_Project.Context;
using MVC_Project.Repositories;

namespace MVC_Project.Controllers
{
    public class EmployeesController : Controller
    {

        private readonly IEmployeeRepository _employeeRepository;
        public EmployeesController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        // GET: Employees
        public ActionResult EmployeesToList()
        {

            /*IEnumerable<Employee> _employees = db.Employees
                .ToList();*/
            var allEmployees = _employeeRepository.GetAll();
            return View(allEmployees);

        }

        /*public ActionResult ListOfHardware(int? id)
        {
            HardwareRepository hardware = new HardwareRepository(db);
            return View(hardware.GetHardwareByOwner(id).ToList());
        }
        */
        public ActionResult GetEmployee(int id)
        {   
            var employee = _employeeRepository.Get(id);
            return View(employee);
        }
    }  
}
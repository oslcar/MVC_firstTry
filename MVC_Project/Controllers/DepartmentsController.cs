using MVC_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using MVC_Project.Repositories;
using MVC_Project.Context;
using MVC_Project.Service;

namespace MVC_Project.Controllers
{
    public class DepartmentsController : Controller
    {
        private readonly IDepartmentService _departmentService;
        public DepartmentsController(IDepartmentService departmentService)
        {
            _departmentService = departmentService; 
        }
        // GET: Departments
        public ActionResult ListOfDepartments()
        { 
            return View(_departmentService.GetAll());
        }
    }
}
using MVC_Project.Models;
using MVC_Project.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Project.Service
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;
        public DepartmentService(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }
        public IEnumerable<Department> GetAll()
        {
            return _departmentRepository.GetAll();
        }
    }
}
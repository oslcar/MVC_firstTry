using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Project.Models
{
    public class EmployeeFormModel
    {
        public Employee Employee { get; set; }
        public IEnumerable<SelectListItem> Departments { get; set; }
    }
}
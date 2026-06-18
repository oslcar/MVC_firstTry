using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_Project.Models
{
    [Table("Employee_Data")]
    public class Employee
    {
        public int ID { get; set; }
        [Display(Name = "First Name")]
        public string FName { get; set; }
        [Display(Name = "Last Name")]
        public string LName { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
        public int Department_ID { get; set; }

        [ForeignKey("Department_ID")]
        public virtual Department Department { get; set; }
        public virtual ICollection<Hardware> Assets { get; set; }
    }
}
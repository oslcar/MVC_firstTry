using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_Project.Models
{
    [Table("Hardware")]
    public class Hardware
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        [Display(Name = "Serial Number")]
        public string SN { get; set; }
        public int Owner_ID { get; set; }

        [ForeignKey("Owner_ID")]
        public virtual Employee Owner { get; set; }
    }
}
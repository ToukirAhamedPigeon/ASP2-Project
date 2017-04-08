using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCSample.Models
{
    [Table("Employees")]
    public class Employee
    {
        [Display(Name ="ID")]
        [Key]
        public int Employee_ID { get; set; }
        [Display(Name ="Name")]
        public string Employee_Name { get; set; }
        [Display(Name = "Salary")]
        public string Employee_Salary { get; set; }
        [Display(Name = "Department")]
        public int Employee_Department { get; set; }
    }
}
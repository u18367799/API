using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Crayon_Kids.Models
{
    public class Employee_Type
    {
        [Key]
        public int Employee_Type_ID { get; set; }
        public string Teacher { get; set; }
        public string Cook { get; set; }
        public string Gardener { get; set; }
        public string Administrator { get; set; }
        public string Principal { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}

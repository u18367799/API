using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Crayon_Kids.Models
{
    public class Employee
    {
        [Key]
        public int  Employee_ID { get; set; }


        [ForeignKey("Standard")]
        public int  Employee_Type_ID { get; set; }
        public Employee_Type Employee_Type { get; set; }
        public int School_ID { get; set; }
        public int Title_ID { get; set; }
        public int Employment_Status_ID { get; set; }
       public string  Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birth_Date { get; set; }
        public DateTime Hire_Date { get; set; }
        public DateTime Contact_No { get; set; }
        public string Address { get; set; }
        public string Email_Address { get; set; }

    }
}

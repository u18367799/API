using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Crayon_Kids.Models
{
    public class Class_Type
    {
        [Key]
        public int Class_Type_ID { get; set; }
        public int Grade { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Crayon_Kids.Models
{
    public class Assessment
    {
        [Key]
        public int  Assessment_ID { get; set; }
       public string Assessment_Details { get; set; }
    }
}

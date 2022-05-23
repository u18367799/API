using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Crayon_Kids.Models
{
    public class Allergy
    {
       [Key]
       public int  Allergy_ID { get; set; }
       public string Allergy_Details { get; set; }
       public DateTime Allergy_Date { get; set; }


    }

}

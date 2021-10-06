using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PhamBichLuu863.Models
{
    public class PersonPBL863
    {
        [Key]
       
        public string PersonID { get; set; }
       public string PersonName { get; set; }
    }
}

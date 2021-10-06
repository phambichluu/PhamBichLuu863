using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PhamBichLuu863.Models
{
    public class PBL863
    {
        [Key]
        [Column (TypeName="varchar(20)")]
        public int PBLID { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string PBLName { get; set; }
        public string PBLGender { get; set; }
    }
}

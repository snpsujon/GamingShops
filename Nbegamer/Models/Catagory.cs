using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Nbegamer.Models
{
    public class Catagory
    {
        [Key]
        public int CatID { get; set; }
        public string CatName { get; set; }
        public string CatDiscrip { get; set; }
        public string CatImage { get; set; }
    }
}

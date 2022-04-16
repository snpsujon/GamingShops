using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Nbegamer.Models
{
    public class SubCatagory
    {
        [Key]
        public int SubCatID { get; set; }
        public int CatID { get; set; }
        public string SubCatName { get; set; }
        public string Price { get; set; }

    }
}

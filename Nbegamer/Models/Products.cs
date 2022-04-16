using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Nbegamer.Models
{
    public class Products
    {
        [Key]
        public int ProductID { get; set; }
        public int CatID { get; set; }
        public int SubCatID { get; set; }
        public string ProductType { get; set; }
        public string ProductKey { get; set; }
        public bool IsSold { get; set; }

    }
}

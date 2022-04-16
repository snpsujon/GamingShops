using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Nbegamer.Models
{
    public class Orders
    {
        [Key]
        public int OrderPKey { get; set; }
        public int OrderUKey { get; set; }
        public int CatagoryID { get; set; }
        public int SubCatagoryID { get; set; }
        public int ProductID { get; set; }
        public int PurchaseBYid { get; set; }
        public DateTime PurchaseDate { get; set; }



    }
}

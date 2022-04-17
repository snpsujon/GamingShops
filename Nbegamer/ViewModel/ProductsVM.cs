using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nbegamer.ViewModel
{
    public class ProductsVM
    {

        public int ProductID { get; set; }
        public int CatID { get; set; }
        public int SubCatID { get; set; }
        public string ProductType { get; set; }
        public string ProductKey { get; set; }
        public bool IsSold { get; set; }

        public string SubCatName { get; set; }
        public string Price { get; set; }

        public string CatName { get; set; }
        public string CatDiscrip { get; set; }
        public string CatImage { get; set; }

        public IFormFile CatImages { get; set; }
    }
}

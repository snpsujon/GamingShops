using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Nbegamer.DataConnect;
using Nbegamer.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nbegamer.Controllers
{
    public class ProductsController : Controller
    {
        private readonly DataContext _context;
        private readonly IWebHostEnvironment webHostEnvironment;
        


        public ProductsController(DataContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            webHostEnvironment = hostEnvironment;
            
        }


        public IActionResult Index()
        {
            
            var products = (from pro in _context.Products
                            join cat in _context.Catagories
                            on pro.CatID equals cat.CatID
                            
                            
                            select new ProductsVM
                            {
                                CatName = cat.CatName,
                                 ProductType = pro.ProductType,
                                 ProductKey = pro.ProductKey,
                                 IsSold = pro.IsSold
                            }).ToList();
            return View(products);
        }




        public IActionResult CatagoryIndex()
        {
            var Catagory = _context.Catagories.ToList();
            return View(Catagory);
        }
        public IActionResult CatagoryCreate()
        {
            return View();
        }
    }
}

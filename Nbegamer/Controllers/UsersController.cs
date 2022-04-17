using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Nbegamer.DataConnect;
using Nbegamer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Nbegamer.Controllers
{
    public class UsersController : Controller
    {
        private readonly DataContext _context;
        private readonly IWebHostEnvironment webHostEnvironment;
        private IHttpContextAccessor _accessor;


        public UsersController(DataContext context, IWebHostEnvironment hostEnvironment, IHttpContextAccessor accessor)
        {
            _context = context;
            webHostEnvironment = hostEnvironment;
            _accessor = accessor;
        }
        
        
        public IActionResult Index()
        {
            return View();
        }
        [Route("sign-up")]
        public IActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignupAcc(User users)
        {
            

            var user = new User
            {
                UserFullName = users.UserFullName,
                UserEmail = users.UserEmail,
                UserPhoneNumber = users.UserPhoneNumber,
                UserPassword = users.UserPassword,
                JoinDate = DateTime.Now,
                IsActive = true,
                UserTypeID = 2,
                

            };
            _context.Add(user);
            _context.SaveChanges();
            return RedirectToAction("Login");
        }
        [Route("log-in")]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Loginl(User user)
        {
            var suser = _context.Userss.Where(x => x.UserEmail == user.UserEmail && x.UserPassword == user.UserPassword).FirstOrDefault();
            if(suser != null)
            {
                suser.LastLoginIP = user.LastLoginIP;
                _context.Userss.Update(suser);
                _context.SaveChanges();
                return RedirectToAction("Signup");
            }
            return View();
        }

    }
}

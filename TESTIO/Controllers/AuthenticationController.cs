using DAL.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TESTIO.Models;
using TESTIO.Data;

namespace TESTIO.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly ApplicationDbContext _db;
        public AuthenticationController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View("SignUp");
        }

        [HttpPost]
        public IActionResult SignUp(RegistrationModel model)
        {
            User user = new User() { Name = model.Name, Surname = model.Surname, isAdmin = false, Email = model.Email, Password = model.Password};
            _db.Users.Add(user);
            _db.SaveChanges();
            return Redirect("~/Authentication/SignIn");
        }

        [HttpGet]
        public IActionResult SignIn()
        {
            return View("SignIn");
        }

        [HttpPost]
        public IActionResult SignIn(LoginModel model)
        {
            User user = _db.Users.Where(u => u.Email == model.Email).Where(u => u.Password == model.Password).SingleOrDefault();
            if(user!=null)
            {
                return Redirect("~/Home/Index");
            }
            return Redirect("~/Authentication/SignIn");
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TESTIO.Data;
using DAL.Models;

namespace TESTIO.Controllers
{
    public class TestController : Controller
    {
        private readonly ApplicationDbContext _db;
        public TestController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Test> objList = _db.Tests;
            return View(objList);
        }

        //POST-GET
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(User obj)
        {
            _db.Users.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}

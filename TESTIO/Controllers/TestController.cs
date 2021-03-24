using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TESTIO.Data;
using DAL.Models;
using TESTIO.Models;
using System;

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
            return View("CreateTest");
        }
        [HttpPost]
        public IActionResult Create(TestModel model)
        {
            Test test = new Test() { Name = model.Name, Description = model.Description, Lock = model.Lock, CreatedDate = DateTime.Now};
            //_db.Tests.Add(test);
            //_db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}

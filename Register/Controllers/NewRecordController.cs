using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Register.Models;

namespace Register.Controllers
{
    public class NewRecordController : Controller
    {
        private readonly ConnectionStringClass _cc;

        public NewRecordController(ConnectionStringClass cc)
        {
            _cc = cc;
            
            
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(EmpClass ec)
        {
            //_cc.Add(ec);
            _cc.Machines.Add(ec);
            _cc.SaveChanges();
            ViewBag.message = "Rekord " + ec.MachineName + " został zapisany pomyślnie...!";
            return View();
        }
    }
}

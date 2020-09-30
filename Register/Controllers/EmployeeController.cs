using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Register.Models;

namespace Register.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ConnectionStringClass _cc;

        public EmployeeController(ConnectionStringClass cc)
        {
            _cc = cc;
        }
        public IActionResult Index()
        {
            var results = _cc.Machines.ToList();
            return View(results);
        }
    }
}

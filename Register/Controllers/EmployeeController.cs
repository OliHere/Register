using Microsoft.AspNetCore.Mvc;
using Register.Models;
using System.Linq;

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

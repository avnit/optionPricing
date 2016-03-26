using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

using optionPricing.Models;

namespace optionPricing.Controllers
{
    public class HomeController : Controller
    {
        private stockContext _context;
       public HomeController (stockContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        public IActionResult Options()
        {
            ViewData["Message"] = "Options Calculator";
            var options = _context.options.ToList();

            return View(options);
        }
        public IActionResult Error()
        {
            return View();
        }
    }
}

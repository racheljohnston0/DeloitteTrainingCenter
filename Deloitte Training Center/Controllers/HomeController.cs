using Deloitte_Training_Center.Data;
using Deloitte_Training_Center.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Deloitte_Training_Center.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Deloitte_Training_CenterContext _context;

        public HomeController(ILogger<HomeController> logger, Deloitte_Training_CenterContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Training.ToList());
        }


        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Logon()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

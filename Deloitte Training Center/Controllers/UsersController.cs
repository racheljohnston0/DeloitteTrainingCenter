using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Deloitte_Training_Center.Data;
using Deloitte_Training_Center.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace Deloitte_Training_Center.Controllers
{
    public class UsersController : Controller
    {
        public const string SessionKeyName = "_Name";
        public const string SessionKeyAge = "_Age";
        private readonly Deloitte_Training_CenterContext _context;

        public UsersController(Deloitte_Training_CenterContext context)
        {
            _context = context;
        }

        // GET: Users
        public async Task<IActionResult> Index()
        {
            return View(await _context.User.ToListAsync());
        }

        // GET: Users/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User
                .FirstOrDefaultAsync(m => m.id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // GET: Users/Register
        public IActionResult Register()
        {
            return View();
        }

        // POST: Users/Register
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register([Bind("id,email,password")] User user)
        {
            if (ModelState.IsValid)
            {
                _context.Add(user);
                await _context.SaveChangesAsync();
                HttpContext.Session.SetString(SessionKeyName, user.email.ToString());
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("Register", "Users");
        }

        // GET: Users/Login/5
        public IActionResult Login()
        {
            return View();
        }

        // POST: Users/Login/5
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login([Bind("id,email,password")] User user)
        {

            if (ModelState.IsValid)
            {
                using (_context)
                {
                    var obj = _context.User.Where(a => (a.email.Equals(user.email)) && (a.password.Equals(user.password))).FirstOrDefault();
                    if (obj != null)
                    {
                        HttpContext.Session.SetString(SessionKeyName, user.email.ToString());
                        return RedirectToAction("Index", "Home");
                    }
                }
            }
            return View(user);
        }

        // GET: Users/Logout/5
        public async Task<IActionResult> Logout(int? id)
        {

            HttpContext.Session.SetString(SessionKeyName, "");
            return RedirectToAction("Index", "Home");
        }

        private bool UserExists(int id)
        {
            return _context.User.Any(e => e.id == id);
        }
    }
}

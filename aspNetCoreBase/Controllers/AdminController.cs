using aspNetCoreBase.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspNetCoreBase.Controllers
{
    public class AdminController : Controller
    {
        private AppDbContext _context;

        public AdminController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var users = _context.Users.ToList();
            
            return View(users);
        }
    }
}

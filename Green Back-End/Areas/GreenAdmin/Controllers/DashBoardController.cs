using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Green_Back_End.DAL;
using Microsoft.AspNetCore.Mvc;

namespace Green_Back_End.Areas.GreenAdmin.Controllers
{
    [Area("GreenAdmin")]
    public class DashBoardController : Controller
    {
        private readonly AppDbContext _context;

        public DashBoardController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}

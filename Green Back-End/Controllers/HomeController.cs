using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Green_Back_End.DAL;
using Green_Back_End.Models;
using Green_Back_End.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Green_Back_End.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Slider> sliders = await _context.Sliders.ToListAsync();
            List<Green_Back_End.Models.Service> services = await _context.Services.ToListAsync();

            HomeVM model = new HomeVM
            {
                sliders = sliders,
                Services = services
            };
            return View(model);
        }
    }
}

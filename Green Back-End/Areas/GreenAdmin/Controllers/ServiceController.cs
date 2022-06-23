using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Green_Back_End.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Green_Back_End.Areas.GreenAdmin.Controllers
{
    [Area("GreenAdmin")]
    public class ServiceController : Controller
    {
        private readonly AppDbContext _context;

        public ServiceController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Green_Back_End.Models.Service> services = await _context.Services.ToListAsync(); 
            return View(services);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public async Task<IActionResult> Create(Green_Back_End.Models.Service service)
        {
            if (ModelState.IsValid)
            {
                _context.Services.Add(service);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            else
            {
                return NotFound();
            }
        }

        public async Task<IActionResult> Edit(int id)
        {
            Green_Back_End.Models.Service service = await _context.Services.FirstOrDefaultAsync(x => x.Id == id);

            if (service == null) return NotFound();

            return View(service);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public async Task<IActionResult> Edit(int id, Green_Back_End.Models.Service service)
        {
             if (!ModelState.IsValid) return NotFound();
             Green_Back_End.Models.Service existed = await _context.Services.FirstOrDefaultAsync(x => x.Id == id);

            if(service.Id != id)
            {
                return BadRequest();
            }

            existed.Icon = service.Icon;
            existed.Title = service.Title;
            existed.Description = service.Description;

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));

        }

        public async Task<IActionResult> Delete(int id)
        {
            Green_Back_End.Models.Service existed = await _context.Services.FirstOrDefaultAsync(x => x.Id == id);
            if (existed == null) return NotFound();

            return View(existed);
        }
        
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        [ActionName("Delete")]

        public async Task<IActionResult> DeleteService(int id)
        {
            if (!ModelState.IsValid) return NotFound();
            Green_Back_End.Models.Service existed = await _context.Services.FirstOrDefaultAsync(x => x.Id == id);

            _context.Services.Remove(existed);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Detail(int id)
        {
            Green_Back_End.Models.Service existed = await _context.Services.FirstOrDefaultAsync(x => x.Id == id);

            return View(existed);
        }
    }
}

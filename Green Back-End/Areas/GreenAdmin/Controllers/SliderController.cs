using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Green_Back_End.DAL;
using Green_Back_End.Extensions;
using Green_Back_End.Models;
using Green_Back_End.Utilities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Green_Back_End.Areas.GreenAdmin.Controllers
{
    [Area("GreenAdmin")]
    public class SliderController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public SliderController(AppDbContext context,IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            List<Slider> sliders = await _context.Sliders.ToListAsync();
            return View(sliders);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public async Task<IActionResult> Create(Slider slider)
        {
            if (!ModelState.IsValid) return NotFound();

            if(slider.Photo != null)
            {
                if (slider.Photo.IsOkay(1))
                {
                    slider.Image = await slider.Photo.PathFile(_env.WebRootPath, @"assets\Image");
                }
                _context.Sliders.Add(slider);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            else
            {
                ModelState.AddModelError("Photo", "Please choose anything image file");
                return View();
            }
        }

        public async Task<IActionResult> Edit(int id)
        {
            Slider slider = await _context.Sliders.FindAsync(id);
            if (slider == null) return NotFound();

            return View(slider);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public async Task<IActionResult> Edit(int id,Slider slider)
        {
            if (!ModelState.IsValid) return NotFound();
            Slider existed = await _context.Sliders.FindAsync(id);

            if(slider.Photo != null)
            {
                if (slider.Photo.IsOkay(1))
                {
                    existed.Image = await slider.Photo.PathFile(_env.WebRootPath, @"assets\Image");
                }

                string anyPath = _env.WebRootPath + @"assets\Image" + existed.Image;

                if (System.IO.File.Exists(anyPath))
                {
                    System.IO.File.Delete(anyPath);
                }
            }
            else
            {
                ModelState.AddModelError("Photo", "Please choose anything image file");
                return View();
            }

            existed.Title = slider.Title;
            existed.Description = slider.Description;
            existed.Order = slider.Order;

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            Slider slider = await _context.Sliders.FindAsync(id);

            if (slider == null) return NotFound();

            return View(slider);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        [ActionName("Delete")]

        public async Task<IActionResult> DeleteSlider(int id)
        {
            if (!ModelState.IsValid) return NotFound();
            Slider slider = await _context.Sliders.FindAsync(id);

            string path = _env.WebRootPath + @"assets\Image" + slider.Image;

            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }

            _context.Sliders.Remove(slider);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Detail(int id)
        {
            if (!ModelState.IsValid) return NotFound();
            Slider slider = await _context.Sliders.FindAsync(id);

            return View(slider);
        }
    }
}

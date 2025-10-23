using Pschool.Data;
using Pschool.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Pschool.Controllers
{
    public class ParentsController : Controller
    {
        private readonly PschoolContext _context;
        public ParentsController(PschoolContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var parents = await _context.Parents.ToListAsync();
            return View(parents);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Parent parent)
        {
            if (ModelState.IsValid)
            {
                _context.Parents.Add(parent);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
using Pschool.Data;
using Pschool.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Pschool.Data.Services;

namespace Pschool.Controllers
{
    public class ParentsController : Controller
    {
        private readonly IParentsService _parentsService;
        public ParentsController(IParentsService parentsService)
        {
            _parentsService = parentsService;
        }
        public async Task<IActionResult> Index()
        {
            var parents = await _parentsService.GetAll();
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
                await _parentsService.Add(parent);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
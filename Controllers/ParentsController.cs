using Pschool.Data;
using Microsoft.AspNetCore.Mvc;

namespace Pschool.Controllers
{
    public class ParentsController : Controller
    {
        private readonly PschoolContext _context;
        public ParentsController(PschoolContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var parents = _context.Parents.ToList();
            return View(parents);
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
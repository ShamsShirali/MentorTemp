using MentorProject.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MentorProject.ViewModels.Home;

namespace MentorProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context) 
        { 
            _context= context;
        }

        public async Task<IActionResult> Index()
        {
            HomeVM vm = new HomeVM
            {
                Trainers = await _context.Trainers.Where(t => t.IsDeleted == false).ToListAsync(),
                Courses = await _context.Courses.Include(c=>c.Category).Where(c => c.IsDeleted == false).ToListAsync()
            };

            return View(vm);
        }
    }
}
